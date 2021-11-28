using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Threading;
using System.Windows.Input;
using GlobalHotKey;

namespace Iswenzz.Tools
{
    public partial class Clicker : Form
    {
        [DllImport("user32.dll")]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        private const int MOUSEEVENTF_LEFTDOWN = 0x2;
        private const int MOUSEEVENTF_LEFTUP = 0x4;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x8;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;
        private const int MOUSEEVENTF_MIDDLEDOWN = 0x20;
        private const int MOUSEEVENTF_MIDDLEUP = 0x40;

        private Thread ClickTask { get; set; }
        private bool IsClickerStarted { get; set; }
        private HotKeyManager HotKeyManager { get; set; }
        private HotKey HotKey { get; set; }

        public Clicker()
        {
            InitializeComponent();
            TopMost = true;
            KeyPreview = true;
            HotKeyManager = new HotKeyManager();

            // Capture Input
            KeyDown += Form1_KeyDown;

            // Start/Pause HotKey Event
            HotKey = HotKeyManager.Register(Key.F6, System.Windows.Input.ModifierKeys.None);
            HotKeyManager.KeyPressed += StartPauseEvent;
        }

        /// <summary>
        /// Autoclicking task.
        /// </summary>
        public void ClickerTask()
        {
            if (IsClickerStarted) return;
            IsClickerStarted = true;
            ClickTask = new Thread(() =>
            {
                // Get Interval
                int intervalms = 5;
                try
                {
                    intervalms = (string.IsNullOrEmpty(HourBox.Text) ? 0 : int.Parse(HourBox.Text) * 3600000)
                        + (string.IsNullOrEmpty(MinBox.Text) ? 0 : int.Parse(MinBox.Text) * 60000)
                        + (string.IsNullOrEmpty(SecBox.Text) ? 0 : int.Parse(SecBox.Text) * 1000)
                        + (string.IsNullOrEmpty(MSBox.Text) ? 0 : int.Parse(MSBox.Text));
                }
                catch { }

                // Get Amount
                int index = 0;
                int maxIndex = 1;
                try { maxIndex = int.Parse(RepeatBox.Text); } catch { }

                while (RepeatAmountButton.Checked ? index < maxIndex : true)
                {
                    index++;
                    bool isDoubleClick = (bool)ClickCombo.Invoke(
                        new Func<bool>(() => ClickCombo.SelectedIndex == 1));

                    if (LeftTick.Checked)
                    {
                        for (int i = 0; i < (isDoubleClick ? 2 : 1); i++)
                        {
                            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                        }
                    }
                    if (RightTick.Checked)
                    {
                        for (int i = 0; i < (isDoubleClick ? 2 : 1); i++)
                        {
                            mouse_event(MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
                            mouse_event(MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0);
                        }
                    }
                    if (MiddleTick.Checked)
                    {
                        for (int i = 0; i < (isDoubleClick ? 2 : 1); i++)
                        {
                            mouse_event(MOUSEEVENTF_MIDDLEUP, 0, 0, 0, 0);
                            mouse_event(MOUSEEVENTF_MIDDLEDOWN, 0, 0, 0, 0);
                        }
                    }

                    Thread.Sleep(intervalms);
                }
                StopButton.Invoke(new Action(() => StopButton_Click(null, null)));
            });
            ClickTask.IsBackground = true;
            ClickTask.Start();
        }

        /// <summary>
        /// Function called when firing clicker hotkey.
        /// </summary>
        public void StartPauseEvent(object sender, KeyPressedEventArgs e)
        {
            if (IsClickerStarted)
                StopButton.Invoke(new Action(() => StopButton_Click(null, null)));
            else
                StartButton.Invoke(new Action(() => StartButton_Click(null, null)));
        }

        /// <summary>
        /// Start button.
        /// </summary>
        private void StartButton_Click(object sender, EventArgs e)
        {
            StopButton.HoverColor = Color.RoyalBlue;
            StopButton.HoverColorLeave = Color.RoyalBlue;
            StopButton.BackColor = Color.RoyalBlue;
            StopButton.Enabled = true;
            StopButton.Invalidate();

            StartButton.HoverColor = Color.DimGray;
            StartButton.HoverColorLeave = Color.DimGray;
            StartButton.BackColor = Color.DimGray;
            StartButton.Enabled = false;
            StartButton.Invalidate();

            ClickerTask();
        }

        /// <summary>
        /// Stop button.
        /// </summary>
        private void StopButton_Click(object sender, EventArgs e)
        {
            StopButton.HoverColor = Color.DimGray;
            StopButton.HoverColorLeave = Color.DimGray;
            StopButton.BackColor = Color.DimGray;
            StopButton.Enabled = false;
            StopButton.Invalidate();

            StartButton.HoverColor = Color.RoyalBlue;
            StartButton.HoverColorLeave = Color.RoyalBlue;
            StartButton.BackColor = Color.RoyalBlue;
            StartButton.Enabled = true;
            StartButton.Invalidate();

            ClickTask.Abort();
            IsClickerStarted = false;

            if (LeftTick.Checked)
                mouse_event(MOUSEEVENTF_LEFTUP | MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
            if (RightTick.Checked)
                mouse_event(MOUSEEVENTF_RIGHTUP | MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0);
            if (MiddleTick.Checked)
                mouse_event(MOUSEEVENTF_MIDDLEUP | MOUSEEVENTF_MIDDLEDOWN, 0, 0, 0, 0);
        }

        /// <summary>
        /// Always on top <see cref="CheckBox"/>.
        /// </summary>
        private void AlwaysTopTick_CheckedChanged(object sender, EventArgs e) => TopMost = !TopMost;

        /// <summary>
        /// Form keydown event.
        /// </summary>
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (HotKeyBox.Text == "Press any key...")
            {
                HotKeyManager.Unregister(HotKey);
                HotKeyBox.Text = e.KeyCode.ToString();
                Array keys = typeof(System.Windows.Input.Key).GetEnumValues();
                Key key = Key.None;
                
                foreach (object k in keys)
                {
                    if (((Key)k).ToString() == HotKeyBox.Text)
                    {
                        key = (Key)k;
                        break;
                    }
                }
                HotKey = HotKeyManager.Register(key, System.Windows.Input.ModifierKeys.None);
            }
        }

        /// <summary>
        /// Hotkey capture box.
        /// </summary>
        private void HotKeyBox_Click(object sender, EventArgs e) => HotKeyBox.Text = "Press any key...";

        /// <summary>
        /// Form closing event.
        /// </summary>
        private void Clicker_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (HotKey != null)
                HotKeyManager.Unregister(HotKey);
        }
    }
}
