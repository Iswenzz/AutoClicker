using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Input;
using System.Linq;

namespace Iswenzz.Tools
{
    /// <summary>
    /// Auto Clicker Application.
    /// </summary>
    public partial class Application : Form
    {
        public Clicker Clicker { get; set; }

        /// <summary>
        /// Initialize a <see cref="Application"/> form.
        /// </summary>
        public Application()
        {
            InitializeComponent();
            Clicker = new Clicker(this);
            KeyDown += OnFormKeyDown;

            TopMost = true;
            KeyPreview = true;
        }

        /// <summary>
        /// Start button click.
        /// </summary>
        public void OnStartButtonClick(object sender = null, EventArgs e = null)
        {
            DisableButton(StartButton);
            EnableButton(StopButton);

            Clicker.Start();
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
        /// Disable a button.
        /// </summary>
        /// <param name="button">The button to disable.</param>
        private void DisableButton(UI.Controls.Inputs.Button button)
        {
            button.Animations.ColorHover = Color.DimGray;
            button.Animations.ColorHoverLeave = Color.DimGray;
            button.BackColor = Color.DimGray;
            button.Enabled = false;
            button.Invalidate();
        }

        /// <summary>
        /// Enable a button.
        /// </summary>
        /// <param name="button">The button to enable.</param>
        private void EnableButton(UI.Controls.Inputs.Button button)
        {
            button.Animations.ColorHover = Color.RoyalBlue;
            button.Animations.ColorHoverLeave = Color.RoyalBlue;
            button.BackColor = Color.RoyalBlue;
            button.Enabled = true;
            button.Invalidate();
        }

        /// <summary>
        /// Form keydown event.
        /// </summary>
        private void OnFormKeyDown(object sender, KeyEventArgs e)
        {
            if (HotKeyBox.Text == "Press any key...")
            {
                Clicker.HotKeyManager.Unregister(Clicker.HotKey);
                HotKeyBox.Text = e.KeyCode.ToString();

                Key[] keys = (Key[])typeof(Key).GetEnumValues();
                Key pickedKey = keys.FirstOrDefault(k => k.ToString() == HotKeyBox.Text);

                Clicker.RegisterHotKey(pickedKey);
            }
        }

        /// <summary>
        /// Always on top <see cref="CheckBox"/>.
        /// </summary>
        private void OnAlwaysTopChanged(object sender, EventArgs e) =>
            TopMost = !TopMost;

        /// <summary>
        /// Hotkey capture box.
        /// </summary>
        private void OnHotKeyBoxClick(object sender, EventArgs e) => 
            HotKeyBox.Text = "Press any key...";

        /// <summary>
        /// Invoke a func method on the control's thread.
        /// </summary>
        /// <typeparam name="T">The return type of the method.</typeparam>
        /// <param name="control">The control to invoke to.</param>
        /// <param name="method">The method to invoke.</param>
        /// <returns></returns>
        public T Invoker<T>(Control control, Func<T> method) =>
            (T)control.Invoke(method);

        /// <summary>
        /// Invoke an action method on the control's thread.
        /// </summary>
        /// <param name="control">The control to invoke to.</param>
        /// <param name="method">The method to invoke.</param>
        /// <returns></returns>
        public void Invoker(Control control, Action method) =>
            control.Invoke(method);

        /// <summary>
        /// Release resources.
        /// </summary>
        public new void Dispose()
        {
            Clicker.Dispose();
            base.Dispose(true);
        }
    }
}
