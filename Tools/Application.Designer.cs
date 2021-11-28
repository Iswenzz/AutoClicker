namespace Iswenzz.Tools
{
    partial class Application
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.StartButton = new Iswenzz.UI.Controls.Inputs.Button();
            this.StopButton = new Iswenzz.UI.Controls.Inputs.Button();
            this.separatorPanel3 = new Iswenzz.UI.Controls.Layout.PanelSeparator();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MSBox = new System.Windows.Forms.TextBox();
            this.SecBox = new System.Windows.Forms.TextBox();
            this.MinBox = new System.Windows.Forms.TextBox();
            this.HourBox = new System.Windows.Forms.TextBox();
            this.separatorPanel2 = new Iswenzz.UI.Controls.Layout.PanelSeparator();
            this.ClickCombo = new System.Windows.Forms.ComboBox();
            this.MiddleTick = new System.Windows.Forms.CheckBox();
            this.LeftTick = new System.Windows.Forms.CheckBox();
            this.RightTick = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.separatorPanel1 = new Iswenzz.UI.Controls.Layout.PanelSeparator();
            this.HotKeyBox = new System.Windows.Forms.Label();
            this.AlwaysTopTick = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RepeatAmountButton = new System.Windows.Forms.RadioButton();
            this.RepeatButton = new System.Windows.Forms.RadioButton();
            this.RepeatBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.separatorPanel4 = new Iswenzz.UI.Controls.Layout.PanelSeparator();
            this.separatorPanel3.SuspendLayout();
            this.separatorPanel2.SuspendLayout();
            this.separatorPanel1.SuspendLayout();
            this.separatorPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Animations.ColorHover = System.Drawing.Color.RoyalBlue;
            this.StartButton.Animations.ColorHoverLeave = System.Drawing.Color.Empty;
            this.StartButton.Animations.CursorHover = System.Windows.Forms.Cursors.Hand;
            this.StartButton.Animations.CursorHoverLeave = null;
            this.StartButton.Animations.TextColorHover = System.Drawing.Color.DarkOrange;
            this.StartButton.Animations.TextColorHoverLeave = System.Drawing.Color.Empty;
            this.StartButton.BackColor = System.Drawing.Color.SteelBlue;
            this.StartButton.Border.Radius = new System.Drawing.Size(0, 0);
            this.StartButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.StartButton.Icon.IconImage = null;
            this.StartButton.Icon.IconSize = 0;
            this.StartButton.Location = new System.Drawing.Point(21, 323);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(221, 51);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.TextLayouts.Angle = 0;
            this.StartButton.Click += new System.EventHandler(this.OnStartButtonClick);
            // 
            // StopButton
            // 
            this.StopButton.Animations.ColorHover = System.Drawing.Color.RoyalBlue;
            this.StopButton.Animations.ColorHoverLeave = System.Drawing.Color.Empty;
            this.StopButton.Animations.CursorHover = System.Windows.Forms.Cursors.Hand;
            this.StopButton.Animations.CursorHoverLeave = null;
            this.StopButton.Animations.TextColorHover = System.Drawing.Color.DarkOrange;
            this.StopButton.Animations.TextColorHoverLeave = System.Drawing.Color.Empty;
            this.StopButton.BackColor = System.Drawing.Color.DimGray;
            this.StopButton.Border.Radius = new System.Drawing.Size(0, 0);
            this.StopButton.Enabled = false;
            this.StopButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.StopButton.Icon.IconImage = null;
            this.StopButton.Icon.IconSize = 0;
            this.StopButton.Location = new System.Drawing.Point(274, 323);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(221, 51);
            this.StopButton.TabIndex = 1;
            this.StopButton.Text = "Stop";
            this.StopButton.TextLayouts.Angle = 0;
            this.StopButton.Click += new System.EventHandler(this.OnStopButtonClick);
            // 
            // separatorPanel3
            // 
            this.separatorPanel3.Animations.ColorHover = System.Drawing.Color.Empty;
            this.separatorPanel3.Animations.ColorHoverLeave = System.Drawing.Color.Empty;
            this.separatorPanel3.Animations.CursorHover = null;
            this.separatorPanel3.Animations.CursorHoverLeave = null;
            this.separatorPanel3.Animations.TextColorHover = System.Drawing.Color.Empty;
            this.separatorPanel3.Animations.TextColorHoverLeave = System.Drawing.Color.Empty;
            this.separatorPanel3.Border.Color = System.Drawing.Color.DimGray;
            this.separatorPanel3.Border.Locations = Iswenzz.UI.Data.RectLocation.Top;
            this.separatorPanel3.Border.Radius = new System.Drawing.Size(0, 0);
            this.separatorPanel3.Border.Width = 1F;
            this.separatorPanel3.Controls.Add(this.label8);
            this.separatorPanel3.Controls.Add(this.label7);
            this.separatorPanel3.Controls.Add(this.label6);
            this.separatorPanel3.Controls.Add(this.label5);
            this.separatorPanel3.Controls.Add(this.MSBox);
            this.separatorPanel3.Controls.Add(this.SecBox);
            this.separatorPanel3.Controls.Add(this.MinBox);
            this.separatorPanel3.Controls.Add(this.HourBox);
            this.separatorPanel3.Layouts.Angle = 0;
            this.separatorPanel3.Location = new System.Drawing.Point(21, 32);
            this.separatorPanel3.Name = "separatorPanel3";
            this.separatorPanel3.Size = new System.Drawing.Size(476, 43);
            this.separatorPanel3.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label8.Location = new System.Drawing.Point(439, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "ms";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label7.Location = new System.Drawing.Point(326, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "secs";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label6.Location = new System.Drawing.Point(209, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "mins";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label5.Location = new System.Drawing.Point(86, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "hours";
            // 
            // MSBox
            // 
            this.MSBox.BackColor = System.Drawing.Color.Gainsboro;
            this.MSBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.MSBox.Location = new System.Drawing.Point(369, 13);
            this.MSBox.Name = "MSBox";
            this.MSBox.Size = new System.Drawing.Size(67, 22);
            this.MSBox.TabIndex = 3;
            this.MSBox.Text = "50";
            this.MSBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SecBox
            // 
            this.SecBox.BackColor = System.Drawing.Color.Gainsboro;
            this.SecBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.SecBox.Location = new System.Drawing.Point(253, 13);
            this.SecBox.Name = "SecBox";
            this.SecBox.Size = new System.Drawing.Size(67, 22);
            this.SecBox.TabIndex = 2;
            this.SecBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MinBox
            // 
            this.MinBox.BackColor = System.Drawing.Color.Gainsboro;
            this.MinBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.MinBox.Location = new System.Drawing.Point(136, 13);
            this.MinBox.Name = "MinBox";
            this.MinBox.Size = new System.Drawing.Size(67, 22);
            this.MinBox.TabIndex = 1;
            this.MinBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HourBox
            // 
            this.HourBox.BackColor = System.Drawing.Color.Gainsboro;
            this.HourBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.HourBox.Location = new System.Drawing.Point(13, 13);
            this.HourBox.Name = "HourBox";
            this.HourBox.Size = new System.Drawing.Size(67, 22);
            this.HourBox.TabIndex = 0;
            this.HourBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // separatorPanel2
            // 
            this.separatorPanel2.Animations.ColorHover = System.Drawing.Color.Empty;
            this.separatorPanel2.Animations.ColorHoverLeave = System.Drawing.Color.Empty;
            this.separatorPanel2.Animations.CursorHover = null;
            this.separatorPanel2.Animations.CursorHoverLeave = null;
            this.separatorPanel2.Animations.TextColorHover = System.Drawing.Color.Empty;
            this.separatorPanel2.Animations.TextColorHoverLeave = System.Drawing.Color.Empty;
            this.separatorPanel2.Border.Color = System.Drawing.Color.DimGray;
            this.separatorPanel2.Border.Locations = Iswenzz.UI.Data.RectLocation.Top;
            this.separatorPanel2.Border.Radius = new System.Drawing.Size(0, 0);
            this.separatorPanel2.Border.Width = 1F;
            this.separatorPanel2.Controls.Add(this.ClickCombo);
            this.separatorPanel2.Controls.Add(this.MiddleTick);
            this.separatorPanel2.Controls.Add(this.LeftTick);
            this.separatorPanel2.Controls.Add(this.RightTick);
            this.separatorPanel2.Layouts.Angle = 0;
            this.separatorPanel2.Location = new System.Drawing.Point(21, 129);
            this.separatorPanel2.Name = "separatorPanel2";
            this.separatorPanel2.Size = new System.Drawing.Size(236, 73);
            this.separatorPanel2.TabIndex = 3;
            // 
            // ClickCombo
            // 
            this.ClickCombo.BackColor = System.Drawing.Color.Gainsboro;
            this.ClickCombo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ClickCombo.FormattingEnabled = true;
            this.ClickCombo.Items.AddRange(new object[] {
            "Click",
            "Double Click"});
            this.ClickCombo.Location = new System.Drawing.Point(99, 39);
            this.ClickCombo.Name = "ClickCombo";
            this.ClickCombo.Size = new System.Drawing.Size(113, 24);
            this.ClickCombo.TabIndex = 3;
            this.ClickCombo.Text = "Click";
            // 
            // MiddleTick
            // 
            this.MiddleTick.AutoSize = true;
            this.MiddleTick.ForeColor = System.Drawing.SystemColors.WindowText;
            this.MiddleTick.Location = new System.Drawing.Point(123, 12);
            this.MiddleTick.Name = "MiddleTick";
            this.MiddleTick.Size = new System.Drawing.Size(70, 20);
            this.MiddleTick.TabIndex = 2;
            this.MiddleTick.Text = "Middle";
            this.MiddleTick.UseVisualStyleBackColor = true;
            // 
            // LeftTick
            // 
            this.LeftTick.AutoSize = true;
            this.LeftTick.Checked = true;
            this.LeftTick.CheckState = System.Windows.Forms.CheckState.Checked;
            this.LeftTick.ForeColor = System.Drawing.SystemColors.WindowText;
            this.LeftTick.Location = new System.Drawing.Point(13, 39);
            this.LeftTick.Name = "LeftTick";
            this.LeftTick.Size = new System.Drawing.Size(50, 20);
            this.LeftTick.TabIndex = 1;
            this.LeftTick.Text = "Left";
            this.LeftTick.UseVisualStyleBackColor = true;
            // 
            // RightTick
            // 
            this.RightTick.AutoSize = true;
            this.RightTick.ForeColor = System.Drawing.SystemColors.WindowText;
            this.RightTick.Location = new System.Drawing.Point(13, 12);
            this.RightTick.Name = "RightTick";
            this.RightTick.Size = new System.Drawing.Size(60, 20);
            this.RightTick.TabIndex = 0;
            this.RightTick.Text = "Right";
            this.RightTick.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(18, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Click Interval";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(18, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Click Options";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Location = new System.Drawing.Point(254, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Click Repeat";
            // 
            // separatorPanel1
            // 
            this.separatorPanel1.Animations.ColorHover = System.Drawing.Color.Empty;
            this.separatorPanel1.Animations.ColorHoverLeave = System.Drawing.Color.Empty;
            this.separatorPanel1.Animations.CursorHover = null;
            this.separatorPanel1.Animations.CursorHoverLeave = null;
            this.separatorPanel1.Animations.TextColorHover = System.Drawing.Color.Empty;
            this.separatorPanel1.Animations.TextColorHoverLeave = System.Drawing.Color.Empty;
            this.separatorPanel1.Border.Color = System.Drawing.Color.DimGray;
            this.separatorPanel1.Border.Locations = Iswenzz.UI.Data.RectLocation.Top;
            this.separatorPanel1.Border.Radius = new System.Drawing.Size(0, 0);
            this.separatorPanel1.Border.Width = 1F;
            this.separatorPanel1.Controls.Add(this.HotKeyBox);
            this.separatorPanel1.Controls.Add(this.AlwaysTopTick);
            this.separatorPanel1.Controls.Add(this.label10);
            this.separatorPanel1.Layouts.Angle = 0;
            this.separatorPanel1.Location = new System.Drawing.Point(21, 257);
            this.separatorPanel1.Name = "separatorPanel1";
            this.separatorPanel1.Size = new System.Drawing.Size(474, 38);
            this.separatorPanel1.TabIndex = 11;
            // 
            // HotKeyBox
            // 
            this.HotKeyBox.BackColor = System.Drawing.Color.Gainsboro;
            this.HotKeyBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.HotKeyBox.Location = new System.Drawing.Point(10, 7);
            this.HotKeyBox.Name = "HotKeyBox";
            this.HotKeyBox.Size = new System.Drawing.Size(117, 22);
            this.HotKeyBox.TabIndex = 12;
            this.HotKeyBox.Text = "F6";
            this.HotKeyBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HotKeyBox.Click += new System.EventHandler(this.OnHotKeyBoxClick);
            // 
            // AlwaysTopTick
            // 
            this.AlwaysTopTick.AutoSize = true;
            this.AlwaysTopTick.Checked = true;
            this.AlwaysTopTick.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AlwaysTopTick.ForeColor = System.Drawing.SystemColors.WindowText;
            this.AlwaysTopTick.Location = new System.Drawing.Point(306, 6);
            this.AlwaysTopTick.Name = "AlwaysTopTick";
            this.AlwaysTopTick.Size = new System.Drawing.Size(112, 20);
            this.AlwaysTopTick.TabIndex = 11;
            this.AlwaysTopTick.Text = "Always on top";
            this.AlwaysTopTick.UseVisualStyleBackColor = true;
            this.AlwaysTopTick.CheckedChanged += new System.EventHandler(this.OnAlwaysTopChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label10.Location = new System.Drawing.Point(133, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Start/Stop Hotkey";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(18, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Settings";
            // 
            // RepeatAmountButton
            // 
            this.RepeatAmountButton.AutoSize = true;
            this.RepeatAmountButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.RepeatAmountButton.Location = new System.Drawing.Point(19, 12);
            this.RepeatAmountButton.Name = "RepeatAmountButton";
            this.RepeatAmountButton.Size = new System.Drawing.Size(73, 20);
            this.RepeatAmountButton.TabIndex = 0;
            this.RepeatAmountButton.Text = "Repeat";
            this.RepeatAmountButton.UseVisualStyleBackColor = true;
            // 
            // RepeatButton
            // 
            this.RepeatButton.AutoSize = true;
            this.RepeatButton.Checked = true;
            this.RepeatButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.RepeatButton.Location = new System.Drawing.Point(19, 39);
            this.RepeatButton.Name = "RepeatButton";
            this.RepeatButton.Size = new System.Drawing.Size(152, 20);
            this.RepeatButton.TabIndex = 1;
            this.RepeatButton.TabStop = true;
            this.RepeatButton.Text = "Repeat until stopped";
            this.RepeatButton.UseVisualStyleBackColor = true;
            // 
            // RepeatBox
            // 
            this.RepeatBox.BackColor = System.Drawing.Color.Gainsboro;
            this.RepeatBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.RepeatBox.Location = new System.Drawing.Point(104, 12);
            this.RepeatBox.Name = "RepeatBox";
            this.RepeatBox.Size = new System.Drawing.Size(67, 22);
            this.RepeatBox.TabIndex = 8;
            this.RepeatBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label9.Location = new System.Drawing.Point(185, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "times";
            // 
            // separatorPanel4
            // 
            this.separatorPanel4.Animations.ColorHover = System.Drawing.Color.Empty;
            this.separatorPanel4.Animations.ColorHoverLeave = System.Drawing.Color.Empty;
            this.separatorPanel4.Animations.CursorHover = null;
            this.separatorPanel4.Animations.CursorHoverLeave = null;
            this.separatorPanel4.Animations.TextColorHover = System.Drawing.Color.Empty;
            this.separatorPanel4.Animations.TextColorHoverLeave = System.Drawing.Color.Empty;
            this.separatorPanel4.Border.Color = System.Drawing.Color.DimGray;
            this.separatorPanel4.Border.Locations = Iswenzz.UI.Data.RectLocation.Top;
            this.separatorPanel4.Border.Radius = new System.Drawing.Size(0, 0);
            this.separatorPanel4.Border.Width = 1F;
            this.separatorPanel4.Controls.Add(this.label9);
            this.separatorPanel4.Controls.Add(this.RepeatBox);
            this.separatorPanel4.Controls.Add(this.RepeatButton);
            this.separatorPanel4.Controls.Add(this.RepeatAmountButton);
            this.separatorPanel4.Layouts.Angle = 0;
            this.separatorPanel4.Location = new System.Drawing.Point(257, 129);
            this.separatorPanel4.Name = "separatorPanel4";
            this.separatorPanel4.Size = new System.Drawing.Size(240, 73);
            this.separatorPanel4.TabIndex = 4;
            // 
            // Application
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(518, 395);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.separatorPanel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.separatorPanel4);
            this.Controls.Add(this.separatorPanel3);
            this.Controls.Add(this.separatorPanel2);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Application";
            this.Text = "Auto Clicker";
            this.separatorPanel3.ResumeLayout(false);
            this.separatorPanel3.PerformLayout();
            this.separatorPanel2.ResumeLayout(false);
            this.separatorPanel2.PerformLayout();
            this.separatorPanel1.ResumeLayout(false);
            this.separatorPanel1.PerformLayout();
            this.separatorPanel4.ResumeLayout(false);
            this.separatorPanel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Iswenzz.UI.Controls.Inputs.Button StartButton;
        private Iswenzz.UI.Controls.Inputs.Button StopButton;
        private Iswenzz.UI.Controls.Layout.PanelSeparator separatorPanel3;
        private Iswenzz.UI.Controls.Layout.PanelSeparator separatorPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private Iswenzz.UI.Controls.Layout.PanelSeparator separatorPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox AlwaysTopTick;
        private System.Windows.Forms.Label label9;
        private UI.Controls.Layout.PanelSeparator separatorPanel4;
        public System.Windows.Forms.TextBox MSBox;
        public System.Windows.Forms.TextBox SecBox;
        public System.Windows.Forms.TextBox MinBox;
        public System.Windows.Forms.TextBox HourBox;
        public System.Windows.Forms.CheckBox MiddleTick;
        public System.Windows.Forms.CheckBox LeftTick;
        public System.Windows.Forms.CheckBox RightTick;
        public System.Windows.Forms.Label HotKeyBox;
        public System.Windows.Forms.ComboBox ClickCombo;
        public System.Windows.Forms.RadioButton RepeatAmountButton;
        public System.Windows.Forms.RadioButton RepeatButton;
        public System.Windows.Forms.TextBox RepeatBox;
    }
}

