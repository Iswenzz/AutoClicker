namespace AutoClicker
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
            StartButton = new System.Windows.Forms.Button();
            StopButton = new System.Windows.Forms.Button();
            separatorPanel3 = new System.Windows.Forms.Panel();
            label8 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            MSBox = new System.Windows.Forms.TextBox();
            SecBox = new System.Windows.Forms.TextBox();
            MinBox = new System.Windows.Forms.TextBox();
            HourBox = new System.Windows.Forms.TextBox();
            separatorPanel2 = new System.Windows.Forms.Panel();
            ClickCombo = new System.Windows.Forms.ComboBox();
            MiddleTick = new System.Windows.Forms.CheckBox();
            LeftTick = new System.Windows.Forms.CheckBox();
            RightTick = new System.Windows.Forms.CheckBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            separatorPanel1 = new System.Windows.Forms.Panel();
            HotKeyBox = new System.Windows.Forms.Label();
            AlwaysTopTick = new System.Windows.Forms.CheckBox();
            label10 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            RepeatRadioTimes = new System.Windows.Forms.RadioButton();
            RepeatRadioLoop = new System.Windows.Forms.RadioButton();
            RepeatBox = new System.Windows.Forms.TextBox();
            label9 = new System.Windows.Forms.Label();
            separatorPanel4 = new System.Windows.Forms.Panel();
            separatorPanel3.SuspendLayout();
            separatorPanel2.SuspendLayout();
            separatorPanel1.SuspendLayout();
            separatorPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // StartButton
            // 
            StartButton.BackColor = System.Drawing.Color.DodgerBlue;
            StartButton.FlatAppearance.BorderSize = 0;
            StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            StartButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            StartButton.ForeColor = System.Drawing.Color.White;
            StartButton.Location = new System.Drawing.Point(18, 303);
            StartButton.Name = "StartButton";
            StartButton.Size = new System.Drawing.Size(193, 48);
            StartButton.TabIndex = 0;
            StartButton.Text = "Start";
            StartButton.UseVisualStyleBackColor = false;
            StartButton.Click += OnStartButtonClick;
            // 
            // StopButton
            // 
            StopButton.BackColor = System.Drawing.Color.DimGray;
            StopButton.Enabled = false;
            StopButton.FlatAppearance.BorderSize = 0;
            StopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            StopButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            StopButton.ForeColor = System.Drawing.Color.White;
            StopButton.Location = new System.Drawing.Point(239, 303);
            StopButton.Name = "StopButton";
            StopButton.Size = new System.Drawing.Size(193, 48);
            StopButton.TabIndex = 1;
            StopButton.Text = "Stop";
            StopButton.UseVisualStyleBackColor = false;
            StopButton.Click += OnStopButtonClick;
            // 
            // separatorPanel3
            // 
            separatorPanel3.Controls.Add(label8);
            separatorPanel3.Controls.Add(label7);
            separatorPanel3.Controls.Add(label6);
            separatorPanel3.Controls.Add(label5);
            separatorPanel3.Controls.Add(MSBox);
            separatorPanel3.Controls.Add(SecBox);
            separatorPanel3.Controls.Add(MinBox);
            separatorPanel3.Controls.Add(HourBox);
            separatorPanel3.ForeColor = System.Drawing.Color.Black;
            separatorPanel3.Location = new System.Drawing.Point(18, 30);
            separatorPanel3.Name = "separatorPanel3";
            separatorPanel3.Size = new System.Drawing.Size(416, 40);
            separatorPanel3.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Segoe UI", 9F);
            label8.ForeColor = System.Drawing.Color.Black;
            label8.Location = new System.Drawing.Point(384, 15);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(23, 15);
            label8.TabIndex = 7;
            label8.Text = "ms";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Segoe UI", 9F);
            label7.ForeColor = System.Drawing.Color.Black;
            label7.Location = new System.Drawing.Point(286, 15);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(29, 15);
            label7.TabIndex = 6;
            label7.Text = "secs";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 9F);
            label6.ForeColor = System.Drawing.Color.Black;
            label6.Location = new System.Drawing.Point(183, 15);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(33, 15);
            label6.TabIndex = 5;
            label6.Text = "mins";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 9F);
            label5.ForeColor = System.Drawing.Color.Black;
            label5.Location = new System.Drawing.Point(76, 15);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(37, 15);
            label5.TabIndex = 4;
            label5.Text = "hours";
            // 
            // MSBox
            // 
            MSBox.BackColor = System.Drawing.Color.Gainsboro;
            MSBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            MSBox.ForeColor = System.Drawing.SystemColors.WindowText;
            MSBox.Location = new System.Drawing.Point(323, 12);
            MSBox.Name = "MSBox";
            MSBox.Size = new System.Drawing.Size(59, 23);
            MSBox.TabIndex = 3;
            MSBox.Text = "50";
            MSBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SecBox
            // 
            SecBox.BackColor = System.Drawing.Color.Gainsboro;
            SecBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            SecBox.ForeColor = System.Drawing.SystemColors.WindowText;
            SecBox.Location = new System.Drawing.Point(221, 12);
            SecBox.Name = "SecBox";
            SecBox.Size = new System.Drawing.Size(59, 23);
            SecBox.TabIndex = 2;
            SecBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MinBox
            // 
            MinBox.BackColor = System.Drawing.Color.Gainsboro;
            MinBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            MinBox.ForeColor = System.Drawing.SystemColors.WindowText;
            MinBox.Location = new System.Drawing.Point(119, 12);
            MinBox.Name = "MinBox";
            MinBox.Size = new System.Drawing.Size(59, 23);
            MinBox.TabIndex = 1;
            MinBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HourBox
            // 
            HourBox.BackColor = System.Drawing.Color.Gainsboro;
            HourBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            HourBox.ForeColor = System.Drawing.SystemColors.WindowText;
            HourBox.Location = new System.Drawing.Point(11, 12);
            HourBox.Name = "HourBox";
            HourBox.Size = new System.Drawing.Size(59, 23);
            HourBox.TabIndex = 0;
            HourBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // separatorPanel2
            // 
            separatorPanel2.Controls.Add(ClickCombo);
            separatorPanel2.Controls.Add(MiddleTick);
            separatorPanel2.Controls.Add(LeftTick);
            separatorPanel2.Controls.Add(RightTick);
            separatorPanel2.ForeColor = System.Drawing.Color.Black;
            separatorPanel2.Location = new System.Drawing.Point(18, 121);
            separatorPanel2.Name = "separatorPanel2";
            separatorPanel2.Size = new System.Drawing.Size(206, 68);
            separatorPanel2.TabIndex = 3;
            // 
            // ClickCombo
            // 
            ClickCombo.BackColor = System.Drawing.Color.Gainsboro;
            ClickCombo.Font = new System.Drawing.Font("Segoe UI", 9F);
            ClickCombo.ForeColor = System.Drawing.SystemColors.WindowText;
            ClickCombo.FormattingEnabled = true;
            ClickCombo.Items.AddRange(new object[] { "Click", "Double Click" });
            ClickCombo.Location = new System.Drawing.Point(87, 37);
            ClickCombo.Name = "ClickCombo";
            ClickCombo.Size = new System.Drawing.Size(99, 23);
            ClickCombo.TabIndex = 3;
            ClickCombo.Text = "Click";
            // 
            // MiddleTick
            // 
            MiddleTick.AutoSize = true;
            MiddleTick.Font = new System.Drawing.Font("Segoe UI", 9F);
            MiddleTick.ForeColor = System.Drawing.Color.Black;
            MiddleTick.Location = new System.Drawing.Point(108, 11);
            MiddleTick.Name = "MiddleTick";
            MiddleTick.Size = new System.Drawing.Size(63, 19);
            MiddleTick.TabIndex = 2;
            MiddleTick.Text = "Middle";
            MiddleTick.UseVisualStyleBackColor = true;
            // 
            // LeftTick
            // 
            LeftTick.AutoSize = true;
            LeftTick.Checked = true;
            LeftTick.CheckState = System.Windows.Forms.CheckState.Checked;
            LeftTick.Font = new System.Drawing.Font("Segoe UI", 9F);
            LeftTick.ForeColor = System.Drawing.Color.Black;
            LeftTick.Location = new System.Drawing.Point(11, 37);
            LeftTick.Name = "LeftTick";
            LeftTick.Size = new System.Drawing.Size(46, 19);
            LeftTick.TabIndex = 1;
            LeftTick.Text = "Left";
            LeftTick.UseVisualStyleBackColor = true;
            // 
            // RightTick
            // 
            RightTick.AutoSize = true;
            RightTick.Font = new System.Drawing.Font("Segoe UI", 9F);
            RightTick.ForeColor = System.Drawing.Color.Black;
            RightTick.Location = new System.Drawing.Point(11, 11);
            RightTick.Name = "RightTick";
            RightTick.Size = new System.Drawing.Size(54, 19);
            RightTick.TabIndex = 0;
            RightTick.Text = "Right";
            RightTick.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            label1.ForeColor = System.Drawing.Color.Black;
            label1.Location = new System.Drawing.Point(15, 7);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(75, 15);
            label1.TabIndex = 5;
            label1.Text = "Click Interval";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            label2.ForeColor = System.Drawing.Color.Black;
            label2.Location = new System.Drawing.Point(15, 95);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(78, 15);
            label2.TabIndex = 6;
            label2.Text = "Click Options";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = System.Drawing.Color.Black;
            label4.Location = new System.Drawing.Point(223, 95);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(72, 15);
            label4.TabIndex = 8;
            label4.Text = "Click Repeat";
            // 
            // separatorPanel1
            // 
            separatorPanel1.Controls.Add(HotKeyBox);
            separatorPanel1.Controls.Add(AlwaysTopTick);
            separatorPanel1.Controls.Add(label10);
            separatorPanel1.ForeColor = System.Drawing.Color.Black;
            separatorPanel1.Location = new System.Drawing.Point(18, 241);
            separatorPanel1.Name = "separatorPanel1";
            separatorPanel1.Size = new System.Drawing.Size(414, 40);
            separatorPanel1.TabIndex = 11;
            // 
            // HotKeyBox
            // 
            HotKeyBox.BackColor = System.Drawing.Color.Gainsboro;
            HotKeyBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            HotKeyBox.ForeColor = System.Drawing.SystemColors.WindowText;
            HotKeyBox.Location = new System.Drawing.Point(11, 10);
            HotKeyBox.Name = "HotKeyBox";
            HotKeyBox.Size = new System.Drawing.Size(102, 20);
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
            AlwaysTopTick.Font = new System.Drawing.Font("Segoe UI", 9F);
            AlwaysTopTick.ForeColor = System.Drawing.Color.Black;
            AlwaysTopTick.Location = new System.Drawing.Point(277, 13);
            AlwaysTopTick.Name = "AlwaysTopTick";
            AlwaysTopTick.Size = new System.Drawing.Size(101, 19);
            AlwaysTopTick.TabIndex = 11;
            AlwaysTopTick.Text = "Always on top";
            AlwaysTopTick.UseVisualStyleBackColor = true;
            AlwaysTopTick.CheckedChanged += OnAlwaysTopChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Segoe UI", 9F);
            label10.ForeColor = System.Drawing.Color.Black;
            label10.Location = new System.Drawing.Point(119, 12);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(101, 15);
            label10.TabIndex = 0;
            label10.Text = "Start/Stop Hotkey";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            label3.ForeColor = System.Drawing.Color.Black;
            label3.Location = new System.Drawing.Point(15, 215);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(49, 15);
            label3.TabIndex = 13;
            label3.Text = "Settings";
            // 
            // RepeatRadioTimes
            // 
            RepeatRadioTimes.AutoSize = true;
            RepeatRadioTimes.Font = new System.Drawing.Font("Segoe UI", 9F);
            RepeatRadioTimes.ForeColor = System.Drawing.Color.Black;
            RepeatRadioTimes.Location = new System.Drawing.Point(17, 11);
            RepeatRadioTimes.Name = "RepeatRadioTimes";
            RepeatRadioTimes.Size = new System.Drawing.Size(61, 19);
            RepeatRadioTimes.TabIndex = 0;
            RepeatRadioTimes.Text = "Repeat";
            RepeatRadioTimes.UseVisualStyleBackColor = true;
            // 
            // RepeatRadioLoop
            // 
            RepeatRadioLoop.AutoSize = true;
            RepeatRadioLoop.Checked = true;
            RepeatRadioLoop.Font = new System.Drawing.Font("Segoe UI", 9F);
            RepeatRadioLoop.ForeColor = System.Drawing.Color.Black;
            RepeatRadioLoop.Location = new System.Drawing.Point(17, 37);
            RepeatRadioLoop.Name = "RepeatRadioLoop";
            RepeatRadioLoop.Size = new System.Drawing.Size(134, 19);
            RepeatRadioLoop.TabIndex = 1;
            RepeatRadioLoop.TabStop = true;
            RepeatRadioLoop.Text = "Repeat until stopped";
            RepeatRadioLoop.UseVisualStyleBackColor = true;
            // 
            // RepeatBox
            // 
            RepeatBox.BackColor = System.Drawing.Color.Gainsboro;
            RepeatBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            RepeatBox.ForeColor = System.Drawing.SystemColors.WindowText;
            RepeatBox.Location = new System.Drawing.Point(91, 11);
            RepeatBox.Name = "RepeatBox";
            RepeatBox.Size = new System.Drawing.Size(59, 23);
            RepeatBox.TabIndex = 8;
            RepeatBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Segoe UI", 9F);
            label9.ForeColor = System.Drawing.Color.Black;
            label9.Location = new System.Drawing.Point(162, 13);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(36, 15);
            label9.TabIndex = 9;
            label9.Text = "times";
            // 
            // separatorPanel4
            // 
            separatorPanel4.Controls.Add(label9);
            separatorPanel4.Controls.Add(RepeatBox);
            separatorPanel4.Controls.Add(RepeatRadioLoop);
            separatorPanel4.Controls.Add(RepeatRadioTimes);
            separatorPanel4.ForeColor = System.Drawing.Color.Black;
            separatorPanel4.Location = new System.Drawing.Point(223, 121);
            separatorPanel4.Name = "separatorPanel4";
            separatorPanel4.Size = new System.Drawing.Size(212, 68);
            separatorPanel4.TabIndex = 4;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(454, 370);
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
            Font = new System.Drawing.Font("Segoe UI", 9F);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
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

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Panel separatorPanel3;
        private System.Windows.Forms.Panel separatorPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel separatorPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox AlwaysTopTick;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel separatorPanel4;
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

