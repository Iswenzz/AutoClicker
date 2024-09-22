namespace AutoClicker.WinForms
{
    partial class MainForm
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
            StartButton = new IzUI.WinForms.UI.Controls.Inputs.Button();
            StopButton = new IzUI.WinForms.UI.Controls.Inputs.Button();
            separatorPanel3 = new IzUI.WinForms.UI.Controls.Layout.PanelSeparator();
            label8 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            MSBox = new System.Windows.Forms.TextBox();
            SecBox = new System.Windows.Forms.TextBox();
            MinBox = new System.Windows.Forms.TextBox();
            HourBox = new System.Windows.Forms.TextBox();
            separatorPanel2 = new IzUI.WinForms.UI.Controls.Layout.PanelSeparator();
            ClickCombo = new System.Windows.Forms.ComboBox();
            MiddleTick = new System.Windows.Forms.CheckBox();
            LeftTick = new System.Windows.Forms.CheckBox();
            RightTick = new System.Windows.Forms.CheckBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            separatorPanel1 = new IzUI.WinForms.UI.Controls.Layout.PanelSeparator();
            HotKeyBox = new System.Windows.Forms.Label();
            AlwaysTopTick = new System.Windows.Forms.CheckBox();
            label10 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            RepeatRadioTimes = new System.Windows.Forms.RadioButton();
            RepeatRadioLoop = new System.Windows.Forms.RadioButton();
            RepeatBox = new System.Windows.Forms.TextBox();
            label9 = new System.Windows.Forms.Label();
            separatorPanel4 = new IzUI.WinForms.UI.Controls.Layout.PanelSeparator();
            separatorPanel3.SuspendLayout();
            separatorPanel2.SuspendLayout();
            separatorPanel1.SuspendLayout();
            separatorPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // StartButton
            // 
            StartButton.Alpha.Enabled = true;
            StartButton.Animations.ColorHover = System.Drawing.Color.RoyalBlue;
            StartButton.Animations.CursorHover = System.Windows.Forms.Cursors.Hand;
            StartButton.Animations.Enabled = true;
            StartButton.Animations.TextColorHover = System.Drawing.Color.DarkOrange;
            StartButton.BackColor = System.Drawing.Color.SteelBlue;
            StartButton.Border.Color = System.Drawing.Color.SteelBlue;
            StartButton.Border.Enabled = true;
            StartButton.Border.Radius = new System.Drawing.Size(0, 0);
            StartButton.Border.Width = 4F;
            StartButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            StartButton.Icon.Enabled = true;
            StartButton.Icon.IconImage = null;
            StartButton.Icon.IconSize = 0;
            StartButton.Layouts.Angle = 0;
            StartButton.Layouts.Enabled = true;
            StartButton.Location = new System.Drawing.Point(26, 505);
            StartButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            StartButton.Name = "StartButton";
            StartButton.Size = new System.Drawing.Size(276, 80);
            StartButton.TabIndex = 0;
            StartButton.Text = "Start";
            StartButton.TextLayouts.Angle = 0;
            StartButton.TextLayouts.ContentAlign = System.Drawing.ContentAlignment.MiddleCenter;
            StartButton.TextLayouts.Enabled = true;
            StartButton.Click += OnStartButtonClick;
            // 
            // StopButton
            // 
            StopButton.Alpha.Enabled = true;
            StopButton.Animations.ColorHover = System.Drawing.Color.RoyalBlue;
            StopButton.Animations.CursorHover = System.Windows.Forms.Cursors.Hand;
            StopButton.Animations.Enabled = true;
            StopButton.Animations.TextColorHover = System.Drawing.Color.DarkOrange;
            StopButton.BackColor = System.Drawing.Color.DimGray;
            StopButton.Border.Color = System.Drawing.Color.SteelBlue;
            StopButton.Border.Enabled = true;
            StopButton.Border.Radius = new System.Drawing.Size(0, 0);
            StopButton.Border.Width = 4F;
            StopButton.Enabled = false;
            StopButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            StopButton.Icon.Enabled = true;
            StopButton.Icon.IconImage = null;
            StopButton.Icon.IconSize = 0;
            StopButton.Layouts.Angle = 0;
            StopButton.Layouts.Enabled = true;
            StopButton.Location = new System.Drawing.Point(342, 505);
            StopButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            StopButton.Name = "StopButton";
            StopButton.Size = new System.Drawing.Size(276, 80);
            StopButton.TabIndex = 1;
            StopButton.Text = "Stop";
            StopButton.TextLayouts.Angle = 0;
            StopButton.TextLayouts.ContentAlign = System.Drawing.ContentAlignment.MiddleCenter;
            StopButton.TextLayouts.Enabled = true;
            StopButton.Click += OnStopButtonClick;
            // 
            // separatorPanel3
            // 
            separatorPanel3.Animations.ColorHover = System.Drawing.Color.Empty;
            separatorPanel3.Animations.CursorHover = null;
            separatorPanel3.Animations.Enabled = false;
            separatorPanel3.Animations.TextColorHover = System.Drawing.Color.Empty;
            separatorPanel3.Border.Color = System.Drawing.Color.DimGray;
            separatorPanel3.Border.Enabled = true;
            separatorPanel3.Border.Locations = IzUI.WinForms.UI.Data.RectLocation.Top;
            separatorPanel3.Border.Radius = new System.Drawing.Size(0, 0);
            separatorPanel3.Border.Width = 1F;
            separatorPanel3.Controls.Add(label8);
            separatorPanel3.Controls.Add(label7);
            separatorPanel3.Controls.Add(label6);
            separatorPanel3.Controls.Add(label5);
            separatorPanel3.Controls.Add(MSBox);
            separatorPanel3.Controls.Add(SecBox);
            separatorPanel3.Controls.Add(MinBox);
            separatorPanel3.Controls.Add(HourBox);
            separatorPanel3.Layouts.Angle = 0;
            separatorPanel3.Layouts.Enabled = true;
            separatorPanel3.Location = new System.Drawing.Point(26, 50);
            separatorPanel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            separatorPanel3.Name = "separatorPanel3";
            separatorPanel3.Size = new System.Drawing.Size(595, 67);
            separatorPanel3.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = System.Drawing.SystemColors.WindowText;
            label8.Location = new System.Drawing.Point(549, 25);
            label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(36, 25);
            label8.TabIndex = 7;
            label8.Text = "ms";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = System.Drawing.SystemColors.WindowText;
            label7.Location = new System.Drawing.Point(408, 25);
            label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(45, 25);
            label7.TabIndex = 6;
            label7.Text = "secs";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = System.Drawing.SystemColors.WindowText;
            label6.Location = new System.Drawing.Point(261, 25);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(50, 25);
            label6.TabIndex = 5;
            label6.Text = "mins";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = System.Drawing.SystemColors.WindowText;
            label5.Location = new System.Drawing.Point(108, 25);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(57, 25);
            label5.TabIndex = 4;
            label5.Text = "hours";
            // 
            // MSBox
            // 
            MSBox.BackColor = System.Drawing.Color.Gainsboro;
            MSBox.ForeColor = System.Drawing.SystemColors.WindowText;
            MSBox.Location = new System.Drawing.Point(461, 20);
            MSBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            MSBox.Name = "MSBox";
            MSBox.Size = new System.Drawing.Size(83, 31);
            MSBox.TabIndex = 3;
            MSBox.Text = "50";
            MSBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SecBox
            // 
            SecBox.BackColor = System.Drawing.Color.Gainsboro;
            SecBox.ForeColor = System.Drawing.SystemColors.WindowText;
            SecBox.Location = new System.Drawing.Point(316, 20);
            SecBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            SecBox.Name = "SecBox";
            SecBox.Size = new System.Drawing.Size(83, 31);
            SecBox.TabIndex = 2;
            SecBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MinBox
            // 
            MinBox.BackColor = System.Drawing.Color.Gainsboro;
            MinBox.ForeColor = System.Drawing.SystemColors.WindowText;
            MinBox.Location = new System.Drawing.Point(170, 20);
            MinBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            MinBox.Name = "MinBox";
            MinBox.Size = new System.Drawing.Size(83, 31);
            MinBox.TabIndex = 1;
            MinBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HourBox
            // 
            HourBox.BackColor = System.Drawing.Color.Gainsboro;
            HourBox.ForeColor = System.Drawing.SystemColors.WindowText;
            HourBox.Location = new System.Drawing.Point(16, 20);
            HourBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            HourBox.Name = "HourBox";
            HourBox.Size = new System.Drawing.Size(83, 31);
            HourBox.TabIndex = 0;
            HourBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // separatorPanel2
            // 
            separatorPanel2.Animations.ColorHover = System.Drawing.Color.Empty;
            separatorPanel2.Animations.CursorHover = null;
            separatorPanel2.Animations.Enabled = false;
            separatorPanel2.Animations.TextColorHover = System.Drawing.Color.Empty;
            separatorPanel2.Border.Color = System.Drawing.Color.DimGray;
            separatorPanel2.Border.Enabled = true;
            separatorPanel2.Border.Locations = IzUI.WinForms.UI.Data.RectLocation.Top;
            separatorPanel2.Border.Radius = new System.Drawing.Size(0, 0);
            separatorPanel2.Border.Width = 1F;
            separatorPanel2.Controls.Add(ClickCombo);
            separatorPanel2.Controls.Add(MiddleTick);
            separatorPanel2.Controls.Add(LeftTick);
            separatorPanel2.Controls.Add(RightTick);
            separatorPanel2.Layouts.Angle = 0;
            separatorPanel2.Layouts.Enabled = true;
            separatorPanel2.Location = new System.Drawing.Point(26, 202);
            separatorPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            separatorPanel2.Name = "separatorPanel2";
            separatorPanel2.Size = new System.Drawing.Size(295, 114);
            separatorPanel2.TabIndex = 3;
            // 
            // ClickCombo
            // 
            ClickCombo.BackColor = System.Drawing.Color.Gainsboro;
            ClickCombo.ForeColor = System.Drawing.SystemColors.WindowText;
            ClickCombo.FormattingEnabled = true;
            ClickCombo.Items.AddRange(new object[] { "Click", "Double Click" });
            ClickCombo.Location = new System.Drawing.Point(124, 61);
            ClickCombo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            ClickCombo.Name = "ClickCombo";
            ClickCombo.Size = new System.Drawing.Size(140, 33);
            ClickCombo.TabIndex = 3;
            ClickCombo.Text = "Click";
            // 
            // MiddleTick
            // 
            MiddleTick.AutoSize = true;
            MiddleTick.ForeColor = System.Drawing.SystemColors.WindowText;
            MiddleTick.Location = new System.Drawing.Point(154, 19);
            MiddleTick.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            MiddleTick.Name = "MiddleTick";
            MiddleTick.Size = new System.Drawing.Size(93, 29);
            MiddleTick.TabIndex = 2;
            MiddleTick.Text = "Middle";
            MiddleTick.UseVisualStyleBackColor = true;
            // 
            // LeftTick
            // 
            LeftTick.AutoSize = true;
            LeftTick.Checked = true;
            LeftTick.CheckState = System.Windows.Forms.CheckState.Checked;
            LeftTick.ForeColor = System.Drawing.SystemColors.WindowText;
            LeftTick.Location = new System.Drawing.Point(16, 61);
            LeftTick.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            LeftTick.Name = "LeftTick";
            LeftTick.Size = new System.Drawing.Size(67, 29);
            LeftTick.TabIndex = 1;
            LeftTick.Text = "Left";
            LeftTick.UseVisualStyleBackColor = true;
            // 
            // RightTick
            // 
            RightTick.AutoSize = true;
            RightTick.ForeColor = System.Drawing.SystemColors.WindowText;
            RightTick.Location = new System.Drawing.Point(16, 19);
            RightTick.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            RightTick.Name = "RightTick";
            RightTick.Size = new System.Drawing.Size(80, 29);
            RightTick.TabIndex = 0;
            RightTick.Text = "Right";
            RightTick.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = System.Drawing.SystemColors.WindowText;
            label1.Location = new System.Drawing.Point(22, 11);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(111, 25);
            label1.TabIndex = 5;
            label1.Text = "Click Interval";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = System.Drawing.SystemColors.WindowText;
            label2.Location = new System.Drawing.Point(22, 159);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(117, 25);
            label2.TabIndex = 6;
            label2.Text = "Click Options";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = System.Drawing.SystemColors.WindowText;
            label4.Location = new System.Drawing.Point(318, 159);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(107, 25);
            label4.TabIndex = 8;
            label4.Text = "Click Repeat";
            // 
            // separatorPanel1
            // 
            separatorPanel1.Animations.ColorHover = System.Drawing.Color.Empty;
            separatorPanel1.Animations.CursorHover = null;
            separatorPanel1.Animations.Enabled = false;
            separatorPanel1.Animations.TextColorHover = System.Drawing.Color.Empty;
            separatorPanel1.Border.Color = System.Drawing.Color.DimGray;
            separatorPanel1.Border.Enabled = true;
            separatorPanel1.Border.Locations = IzUI.WinForms.UI.Data.RectLocation.Top;
            separatorPanel1.Border.Radius = new System.Drawing.Size(0, 0);
            separatorPanel1.Border.Width = 1F;
            separatorPanel1.Controls.Add(HotKeyBox);
            separatorPanel1.Controls.Add(AlwaysTopTick);
            separatorPanel1.Controls.Add(label10);
            separatorPanel1.Layouts.Angle = 0;
            separatorPanel1.Layouts.Enabled = true;
            separatorPanel1.Location = new System.Drawing.Point(26, 402);
            separatorPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            separatorPanel1.Name = "separatorPanel1";
            separatorPanel1.Size = new System.Drawing.Size(592, 67);
            separatorPanel1.TabIndex = 11;
            // 
            // HotKeyBox
            // 
            HotKeyBox.BackColor = System.Drawing.Color.Gainsboro;
            HotKeyBox.ForeColor = System.Drawing.SystemColors.WindowText;
            HotKeyBox.Location = new System.Drawing.Point(16, 17);
            HotKeyBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            HotKeyBox.Name = "HotKeyBox";
            HotKeyBox.Size = new System.Drawing.Size(146, 34);
            HotKeyBox.TabIndex = 12;
            HotKeyBox.Text = "F6";
            HotKeyBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            HotKeyBox.Click += OnHotKeyBoxClick;
            // 
            // AlwaysTopTick
            // 
            AlwaysTopTick.AutoSize = true;
            AlwaysTopTick.Checked = true;
            AlwaysTopTick.CheckState = System.Windows.Forms.CheckState.Checked;
            AlwaysTopTick.ForeColor = System.Drawing.SystemColors.WindowText;
            AlwaysTopTick.Location = new System.Drawing.Point(396, 21);
            AlwaysTopTick.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            AlwaysTopTick.Name = "AlwaysTopTick";
            AlwaysTopTick.Size = new System.Drawing.Size(152, 29);
            AlwaysTopTick.TabIndex = 11;
            AlwaysTopTick.Text = "Always on top";
            AlwaysTopTick.UseVisualStyleBackColor = true;
            AlwaysTopTick.CheckedChanged += OnAlwaysTopChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = System.Drawing.SystemColors.WindowText;
            label10.Location = new System.Drawing.Point(170, 20);
            label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(154, 25);
            label10.TabIndex = 0;
            label10.Text = "Start/Stop Hotkey";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = System.Drawing.SystemColors.WindowText;
            label3.Location = new System.Drawing.Point(22, 359);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(76, 25);
            label3.TabIndex = 13;
            label3.Text = "Settings";
            // 
            // RepeatRadioTimes
            // 
            RepeatRadioTimes.AutoSize = true;
            RepeatRadioTimes.ForeColor = System.Drawing.SystemColors.WindowText;
            RepeatRadioTimes.Location = new System.Drawing.Point(24, 19);
            RepeatRadioTimes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            RepeatRadioTimes.Name = "RepeatRadioTimes";
            RepeatRadioTimes.Size = new System.Drawing.Size(91, 29);
            RepeatRadioTimes.TabIndex = 0;
            RepeatRadioTimes.Text = "Repeat";
            RepeatRadioTimes.UseVisualStyleBackColor = true;
            // 
            // RepeatRadioLoop
            // 
            RepeatRadioLoop.AutoSize = true;
            RepeatRadioLoop.Checked = true;
            RepeatRadioLoop.ForeColor = System.Drawing.SystemColors.WindowText;
            RepeatRadioLoop.Location = new System.Drawing.Point(24, 61);
            RepeatRadioLoop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            RepeatRadioLoop.Name = "RepeatRadioLoop";
            RepeatRadioLoop.Size = new System.Drawing.Size(202, 29);
            RepeatRadioLoop.TabIndex = 1;
            RepeatRadioLoop.TabStop = true;
            RepeatRadioLoop.Text = "Repeat until stopped";
            RepeatRadioLoop.UseVisualStyleBackColor = true;
            // 
            // RepeatBox
            // 
            RepeatBox.BackColor = System.Drawing.Color.Gainsboro;
            RepeatBox.ForeColor = System.Drawing.SystemColors.WindowText;
            RepeatBox.Location = new System.Drawing.Point(130, 19);
            RepeatBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            RepeatBox.Name = "RepeatBox";
            RepeatBox.Size = new System.Drawing.Size(83, 31);
            RepeatBox.TabIndex = 8;
            RepeatBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = System.Drawing.SystemColors.WindowText;
            label9.Location = new System.Drawing.Point(231, 22);
            label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(55, 25);
            label9.TabIndex = 9;
            label9.Text = "times";
            // 
            // separatorPanel4
            // 
            separatorPanel4.Animations.ColorHover = System.Drawing.Color.Empty;
            separatorPanel4.Animations.CursorHover = null;
            separatorPanel4.Animations.Enabled = false;
            separatorPanel4.Animations.TextColorHover = System.Drawing.Color.Empty;
            separatorPanel4.Border.Color = System.Drawing.Color.DimGray;
            separatorPanel4.Border.Enabled = true;
            separatorPanel4.Border.Locations = IzUI.WinForms.UI.Data.RectLocation.Top;
            separatorPanel4.Border.Radius = new System.Drawing.Size(0, 0);
            separatorPanel4.Border.Width = 1F;
            separatorPanel4.Controls.Add(label9);
            separatorPanel4.Controls.Add(RepeatBox);
            separatorPanel4.Controls.Add(RepeatRadioLoop);
            separatorPanel4.Controls.Add(RepeatRadioTimes);
            separatorPanel4.Layouts.Angle = 0;
            separatorPanel4.Layouts.Enabled = true;
            separatorPanel4.Location = new System.Drawing.Point(318, 202);
            separatorPanel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            separatorPanel4.Name = "separatorPanel4";
            separatorPanel4.Size = new System.Drawing.Size(303, 114);
            separatorPanel4.TabIndex = 4;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Window;
            ClientSize = new System.Drawing.Size(648, 617);
            Controls.Add(label3);
            Controls.Add(separatorPanel1);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(separatorPanel4);
            Controls.Add(separatorPanel3);
            Controls.Add(separatorPanel2);
            Controls.Add(StopButton);
            Controls.Add(StartButton);
            DoubleBuffered = true;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "MainForm";
            Text = "Auto Clicker";
            separatorPanel3.ResumeLayout(false);
            separatorPanel3.PerformLayout();
            separatorPanel2.ResumeLayout(false);
            separatorPanel2.PerformLayout();
            separatorPanel1.ResumeLayout(false);
            separatorPanel1.PerformLayout();
            separatorPanel4.ResumeLayout(false);
            separatorPanel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private IzUI.WinForms.UI.Controls.Inputs.Button StartButton;
        private IzUI.WinForms.UI.Controls.Inputs.Button StopButton;
        private IzUI.WinForms.UI.Controls.Layout.PanelSeparator separatorPanel3;
        private IzUI.WinForms.UI.Controls.Layout.PanelSeparator separatorPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private IzUI.WinForms.UI.Controls.Layout.PanelSeparator separatorPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox AlwaysTopTick;
        private System.Windows.Forms.Label label9;
        private IzUI.WinForms.UI.Controls.Layout.PanelSeparator separatorPanel4;
        public System.Windows.Forms.TextBox MSBox;
        public System.Windows.Forms.TextBox SecBox;
        public System.Windows.Forms.TextBox MinBox;
        public System.Windows.Forms.TextBox HourBox;
        public System.Windows.Forms.CheckBox MiddleTick;
        public System.Windows.Forms.CheckBox LeftTick;
        public System.Windows.Forms.CheckBox RightTick;
        public System.Windows.Forms.Label HotKeyBox;
        public System.Windows.Forms.ComboBox ClickCombo;
        public System.Windows.Forms.RadioButton RepeatRadioTimes;
        public System.Windows.Forms.RadioButton RepeatRadioLoop;
        public System.Windows.Forms.TextBox RepeatBox;
    }
}

