using System;
using System.Drawing;
using System.Windows.Forms;

using NHotkey;
using NHotkey.WindowsForms;

using AutoClicker.Core;

using Button = IzUI.WinForms.UI.Controls.Inputs.Button;

namespace AutoClicker.WinForms
{
    /// <summary>
    /// Auto Clicker.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Initialize a <see cref="MainForm"/> form.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            TopMost = true;
            KeyPreview = true;
            KeyDown += OnKeyDown;

            HotkeyManager.Current.AddOrReplace("Clicker", Keys.F6, OnHotKeyPress);
        }

        /// <summary>
        /// Disable a button.
        /// </summary>
        /// <param name="button">The button to disable.</param>
        private void DisableButton(Button button)
        {
            button.Enabled = false;
            button.BackColor = Color.DimGray;
            button.Animations.Disable();
            button.Invalidate();
        }

        /// <summary>
        /// Enable a button.
        /// </summary>
        /// <param name="button">The button to enable.</param>
        private void EnableButton(Button button)
        {
            button.Enabled = true;
            button.BackColor = Color.RoyalBlue;
            button.Animations.Enable();
            button.Invalidate();
        }

        /// <summary>
        /// Start button click.
        /// </summary>
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

        /// <summary>
        /// Stop button click.
        /// </summary>
        public void OnStopButtonClick(object sender = null, EventArgs e = null)
        {
            DisableButton(StopButton);
            EnableButton(StartButton);

            Clicker.Stop();
        }

        /// <summary>
        /// Always on top.
        /// </summary>
        private void OnAlwaysTopChanged(object sender, EventArgs e) =>
            TopMost = !TopMost;

        /// <summary>
        /// Hotkey capture box.
        /// </summary>
        private void OnHotKeyBoxClick(object sender, EventArgs e) =>
            HotKeyBox.Text = "Press any key...";

        /// <summary>
        /// On keydown event.
        /// </summary>
        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (HotKeyBox.Text == "Press any key...")
            {
                HotKeyBox.Text = e.KeyCode.ToString();
                HotkeyManager.Current.AddOrReplace("Clicker", e.KeyCode, OnHotKeyPress);
            }
        }

        /// <summary>
        /// On hotkey press.
        /// </summary>
        private void OnHotKeyPress(object sender, HotkeyEventArgs e)
        {
            if (Clicker.Running)
                OnStopButtonClick();
            else
                OnStartButtonClick();
        }

        /// <summary>
        /// Release resources.
        /// </summary>
        public new void Dispose()
        {
            HotkeyManager.Current.Remove("Clicker");
            base.Dispose(true);
        }
    }
}
