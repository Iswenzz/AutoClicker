using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Runtime.InteropServices;

using GlobalHotKey;
using System.Diagnostics;

namespace Iswenzz.Tools
{
    /// <summary>
    /// Clicker class.
    /// </summary>
    public class Clicker : IDisposable
    {
        private const int MOUSEEVENTF_LEFTDOWN = 0x2;
        private const int MOUSEEVENTF_LEFTUP = 0x4;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x8;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;
        private const int MOUSEEVENTF_MIDDLEDOWN = 0x20;
        private const int MOUSEEVENTF_MIDDLEUP = 0x40;

        public Application Application { get; set; }
        public Task ClickerTask { get; set; }
        public CancellationTokenSource CancellationTokenSource { get; set; }

        public HotKeyManager HotKeyManager { get; set; }
        public HotKey HotKey { get; set; }

        [DllImport("user32.dll")]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        /// <summary>
        /// Initialize a new <see cref="Clicker"/>.
        /// </summary>
        /// <param name="application">The clicker form application instance.</param>
        public Clicker(Application application)
        {
            Application = application;
            HotKeyManager = new HotKeyManager();
            CancellationTokenSource = new CancellationTokenSource();

            // Start/Pause HotKey Event
            HotKey = HotKeyManager.Register(Key.F6, ModifierKeys.None);
            HotKeyManager.KeyPressed += OnHotKeyPress;
        }

        /// <summary>
        /// Unregister hotkey.
        /// </summary>
        public void UnregisterHotKey()
        {
            if (HotKey != null)
                HotKeyManager.Unregister(HotKey);
        }

        /// <summary>
        /// Register a specific hotkey.
        /// </summary>
        /// <param name="key">The hotkey to register.</param>
        public void RegisterHotKey(Key key)
        {
            UnregisterHotKey();
            HotKey = HotKeyManager.Register(key, ModifierKeys.None);
        }

        /// <summary>
        /// Start the auto clicker.
        /// </summary>
        public Task Start() => Task.Run(async () =>
        {
            if (CancellationTokenSource.IsCancellationRequested)
            {
                CancellationTokenSource.Dispose();
                CancellationTokenSource = new CancellationTokenSource();
            }

            // Get Interval
            int intervalms = ComputeInterval();

            // Get Amount
            int index = 0;
            int.TryParse(Application.RepeatBox.Text, out int maxIndex);

            while (!Application.RepeatAmountButton.Checked || index < maxIndex)
            {
                if (CancellationTokenSource.IsCancellationRequested)
                    break;

                index++;
                bool isDoubleClick = Application.Invoker(Application.ClickCombo,
                    () => Application.ClickCombo.SelectedIndex == 1);
                int clickAmount = 1 + Convert.ToInt32(isDoubleClick);

                if (Application.LeftTick.Checked)
                {
                    for (int i = 0; i < clickAmount; i++)
                    {
                        mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                        mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                    }
                }
                if (Application.RightTick.Checked)
                {
                    for (int i = 0; i < clickAmount; i++)
                    {
                        mouse_event(MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
                        mouse_event(MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0);
                    }
                }
                if (Application.MiddleTick.Checked)
                {
                    for (int i = 0; i < clickAmount; i++)
                    {
                        mouse_event(MOUSEEVENTF_MIDDLEUP, 0, 0, 0, 0);
                        mouse_event(MOUSEEVENTF_MIDDLEDOWN, 0, 0, 0, 0);
                    }
                }
                await Task.Delay(intervalms);
            }
        });

        /// <summary>
        /// Stop the auto clicker.
        /// </summary>
        public void Stop()
        {
            CancellationTokenSource.Cancel();

            if (Application.LeftTick.Checked)
                mouse_event(MOUSEEVENTF_LEFTUP | MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
            if (Application.RightTick.Checked)
                mouse_event(MOUSEEVENTF_RIGHTUP | MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0);
            if (Application.MiddleTick.Checked)
                mouse_event(MOUSEEVENTF_MIDDLEUP | MOUSEEVENTF_MIDDLEDOWN, 0, 0, 0, 0);
        }

        /// <summary>
        /// On hotkey press.
        /// </summary>
        public void OnHotKeyPress(object sender, KeyPressedEventArgs e)
        {
            if (CancellationTokenSource.IsCancellationRequested)
                Application.Invoker(Application, () => Application.OnStartButtonClick());
            else
                Application.Invoker(Application, () => Application.OnStopButtonClick());
        }

        /// <summary>
        /// Compute the clicking interval.
        /// </summary>
        /// <returns></returns>
        int ComputeInterval()
        {
            try
            {
                return (string.IsNullOrEmpty(Application.HourBox.Text) ? 0 
                    : int.Parse(Application.HourBox.Text) * 3600000)
                    + (string.IsNullOrEmpty(Application.MinBox.Text) ? 0 
                    : int.Parse(Application.MinBox.Text) * 60000)
                    + (string.IsNullOrEmpty(Application.SecBox.Text) ? 0 
                    : int.Parse(Application.SecBox.Text) * 1000)
                    + (string.IsNullOrEmpty(Application.MSBox.Text) ? 0 
                    : int.Parse(Application.MSBox.Text));
            }
            catch 
            {
                return 100;
            }
        }

        /// <summary>
        /// Release all resources.
        /// </summary>
        public void Dispose()
        {
            UnregisterHotKey();
            HotKeyManager.Dispose();
        }
    }
}
