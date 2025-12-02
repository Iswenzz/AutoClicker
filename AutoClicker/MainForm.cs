using System;
using System.Drawing;
using System.Windows.Forms;

using NHotkey;
using NHotkey.WindowsForms;

namespace AutoClicker
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            TopMost = true;
            KeyPreview = true;
            KeyDown += OnKeyDown;

            HotkeyManager.Current.AddOrReplace("Clicker", Keys.F6, OnHotKeyPress);
        }

        private void DisableButton(Button button)
        {
            button.Enabled = false;
            button.BackColor = Color.DimGray;
            button.Invalidate();
        }

        private void EnableButton(Button button)
        {
            button.Enabled = true;
            button.BackColor = Color.RoyalBlue;
            button.Invalidate();
        }

        public void OnStartButtonClick(object sender = null, EventArgs e = null)
        {
            DisableButton(StartButton);
            EnableButton(StopButton);

            Info info = new()
            {
                Left = LeftTick.Checked,
                Right = RightTick.Checked,
                Middle = MiddleTick.Checked,
                Max = int.TryParse(RepeatBox.Text, out int max) ? max : 0,
                DoubleClick = ClickCombo.SelectedIndex == 1,
                Loop = RepeatRadioLoop.Checked,
                Hours = int.TryParse(HourBox.Text, out int hours) ? hours : 0,
                Minutes = int.TryParse(HourBox.Text, out int minutes) ? minutes : 0,
                Seconds = int.TryParse(HourBox.Text, out int seconds) ? seconds : 0,
                Milliseconds = int.TryParse(HourBox.Text, out int milliseconds) ? milliseconds : 0,
            };
            Clicker.Start(info);
        }

        public void OnStopButtonClick(object sender = null, EventArgs e = null)
        {
            DisableButton(StopButton);
            EnableButton(StartButton);

            Clicker.Stop();
        }

        private void OnAlwaysTopChanged(object sender, EventArgs e) =>
            TopMost = !TopMost;

        private void OnHotKeyBoxClick(object sender, EventArgs e) =>
            HotKeyBox.Text = "Press any key...";

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (HotKeyBox.Text == "Press any key...")
            {
                HotKeyBox.Text = e.KeyCode.ToString();
                HotkeyManager.Current.AddOrReplace("Clicker", e.KeyCode, OnHotKeyPress);
            }
        }

        private void OnHotKeyPress(object sender, HotkeyEventArgs e)
        {
            if (Clicker.Running)
                OnStopButtonClick();
            else
                OnStartButtonClick();
        }

        public new void Dispose()
        {
            HotkeyManager.Current.Remove("Clicker");
            base.Dispose(true);
        }
    }
}
