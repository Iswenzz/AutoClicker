namespace Iswenzz.Tools
{
    partial class Clicker
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
            this.StartButton = new Iswenzz.UI.Controls.Buttons.FlatButton();
            this.StopButton = new Iswenzz.UI.Controls.Buttons.FlatButton();
            this.separatorPanel3 = new Iswenzz.UI.Controls.Containers.SeparatorPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MSBox = new System.Windows.Forms.TextBox();
            this.SecBox = new System.Windows.Forms.TextBox();
            this.MinBox = new System.Windows.Forms.TextBox();
            this.HourBox = new System.Windows.Forms.TextBox();
            this.separatorPanel4 = new Iswenzz.UI.Controls.Containers.SeparatorPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.RepeatBox = new System.Windows.Forms.TextBox();
            this.RepeatButton = new System.Windows.Forms.RadioButton();
            this.RepeatAmountButton = new System.Windows.Forms.RadioButton();
            this.separatorPanel2 = new Iswenzz.UI.Controls.Containers.SeparatorPanel();
            this.ClickCombo = new System.Windows.Forms.ComboBox();
            this.MiddleTick = new System.Windows.Forms.CheckBox();
            this.LeftTick = new System.Windows.Forms.CheckBox();
            this.RightTick = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.separator2 = new Iswenzz.UI.Controls.Separator();
            this.separator3 = new Iswenzz.UI.Controls.Separator();
            this.separatorPanel1 = new Iswenzz.UI.Controls.Containers.SeparatorPanel();
            this.HotKeyBox = new System.Windows.Forms.Label();
            this.AlwaysTopTick = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.separator1 = new Iswenzz.UI.Controls.Separator();
            this.label3 = new System.Windows.Forms.Label();
            this.separatorPanel3.SuspendLayout();
            this.separatorPanel4.SuspendLayout();
            this.separatorPanel2.SuspendLayout();
            this.separatorPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Angles = 0;
            this.StartButton.BackColor = System.Drawing.Color.SteelBlue;
            this.StartButton.FlatAppearance.BorderSize = 0;
            this.StartButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.StartButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.StartButton.HoverColor = System.Drawing.Color.RoyalBlue;
            this.StartButton.HoverColorLeave = System.Drawing.Color.RoyalBlue;
            this.StartButton.HoverColorText = System.Drawing.Color.WhiteSmoke;
            this.StartButton.HoverColorTextLeave = System.Drawing.Color.WhiteSmoke;
            this.StartButton.Icon = null;
            this.StartButton.IconAutoPlacement = false;
            this.StartButton.IconSize = 0;
            this.StartButton.Location = new System.Drawing.Point(21, 265);
            this.StartButton.Name = "StartButton";
            this.StartButton.RoundedCorner = 0;
            this.StartButton.Size = new System.Drawing.Size(221, 51);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Angles = 0;
            this.StopButton.BackColor = System.Drawing.Color.DimGray;
            this.StopButton.Enabled = false;
            this.StopButton.FlatAppearance.BorderSize = 0;
            this.StopButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.StopButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.StopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StopButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.StopButton.HoverColor = System.Drawing.Color.DimGray;
            this.StopButton.HoverColorLeave = System.Drawing.Color.DimGray;
            this.StopButton.HoverColorText = System.Drawing.Color.WhiteSmoke;
            this.StopButton.HoverColorTextLeave = System.Drawing.Color.WhiteSmoke;
            this.StopButton.Icon = null;
            this.StopButton.IconAutoPlacement = false;
            this.StopButton.IconSize = 0;
            this.StopButton.Location = new System.Drawing.Point(274, 265);
            this.StopButton.Name = "StopButton";
            this.StopButton.RoundedCorner = 0;
            this.StopButton.Size = new System.Drawing.Size(221, 51);
            this.StopButton.TabIndex = 1;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = false;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // separatorPanel3
            // 
            this.separatorPanel3.BorderColor = System.Drawing.Color.DimGray;
            this.separatorPanel3.Controls.Add(this.label8);
            this.separatorPanel3.Controls.Add(this.label7);
            this.separatorPanel3.Controls.Add(this.label6);
            this.separatorPanel3.Controls.Add(this.label5);
            this.separatorPanel3.Controls.Add(this.MSBox);
            this.separatorPanel3.Controls.Add(this.SecBox);
            this.separatorPanel3.Controls.Add(this.MinBox);
            this.separatorPanel3.Controls.Add(this.HourBox);
            this.separatorPanel3.Location = new System.Drawing.Point(21, 32);
            this.separatorPanel3.Name = "separatorPanel3";
            this.separatorPanel3.Size = new System.Drawing.Size(476, 43);
            this.separatorPanel3.TabIndex = 4;
            this.separatorPanel3.Thickness = 2F;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(439, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "ms";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(326, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "secs";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(209, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "mins";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(86, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "hours";
            // 
            // MSBox
            // 
            this.MSBox.BackColor = System.Drawing.Color.Gainsboro;
            this.MSBox.ForeColor = System.Drawing.Color.DimGray;
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
            this.SecBox.ForeColor = System.Drawing.Color.DimGray;
            this.SecBox.Location = new System.Drawing.Point(253, 13);
            this.SecBox.Name = "SecBox";
            this.SecBox.Size = new System.Drawing.Size(67, 22);
            this.SecBox.TabIndex = 2;
            this.SecBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MinBox
            // 
            this.MinBox.BackColor = System.Drawing.Color.Gainsboro;
            this.MinBox.ForeColor = System.Drawing.Color.DimGray;
            this.MinBox.Location = new System.Drawing.Point(136, 13);
            this.MinBox.Name = "MinBox";
            this.MinBox.Size = new System.Drawing.Size(67, 22);
            this.MinBox.TabIndex = 1;
            this.MinBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HourBox
            // 
            this.HourBox.BackColor = System.Drawing.Color.Gainsboro;
            this.HourBox.ForeColor = System.Drawing.Color.DimGray;
            this.HourBox.Location = new System.Drawing.Point(13, 13);
            this.HourBox.Name = "HourBox";
            this.HourBox.Size = new System.Drawing.Size(67, 22);
            this.HourBox.TabIndex = 0;
            this.HourBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // separatorPanel4
            // 
            this.separatorPanel4.BorderColor = System.Drawing.Color.DimGray;
            this.separatorPanel4.Controls.Add(this.label9);
            this.separatorPanel4.Controls.Add(this.RepeatBox);
            this.separatorPanel4.Controls.Add(this.RepeatButton);
            this.separatorPanel4.Controls.Add(this.RepeatAmountButton);
            this.separatorPanel4.Location = new System.Drawing.Point(255, 105);
            this.separatorPanel4.Name = "separatorPanel4";
            this.separatorPanel4.Size = new System.Drawing.Size(242, 73);
            this.separatorPanel4.TabIndex = 4;
            this.separatorPanel4.Thickness = 2F;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Gainsboro;
            this.label9.Location = new System.Drawing.Point(185, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "times";
            // 
            // RepeatBox
            // 
            this.RepeatBox.BackColor = System.Drawing.Color.Gainsboro;
            this.RepeatBox.ForeColor = System.Drawing.Color.DimGray;
            this.RepeatBox.Location = new System.Drawing.Point(104, 12);
            this.RepeatBox.Name = "RepeatBox";
            this.RepeatBox.Size = new System.Drawing.Size(67, 22);
            this.RepeatBox.TabIndex = 8;
            this.RepeatBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RepeatButton
            // 
            this.RepeatButton.AutoSize = true;
            this.RepeatButton.Checked = true;
            this.RepeatButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.RepeatButton.Location = new System.Drawing.Point(19, 39);
            this.RepeatButton.Name = "RepeatButton";
            this.RepeatButton.Size = new System.Drawing.Size(160, 21);
            this.RepeatButton.TabIndex = 1;
            this.RepeatButton.TabStop = true;
            this.RepeatButton.Text = "Repeat until stopped";
            this.RepeatButton.UseVisualStyleBackColor = true;
            // 
            // RepeatAmountButton
            // 
            this.RepeatAmountButton.AutoSize = true;
            this.RepeatAmountButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.RepeatAmountButton.Location = new System.Drawing.Point(19, 12);
            this.RepeatAmountButton.Name = "RepeatAmountButton";
            this.RepeatAmountButton.Size = new System.Drawing.Size(75, 21);
            this.RepeatAmountButton.TabIndex = 0;
            this.RepeatAmountButton.Text = "Repeat";
            this.RepeatAmountButton.UseVisualStyleBackColor = true;
            // 
            // separatorPanel2
            // 
            this.separatorPanel2.BorderColor = System.Drawing.Color.DimGray;
            this.separatorPanel2.Controls.Add(this.ClickCombo);
            this.separatorPanel2.Controls.Add(this.MiddleTick);
            this.separatorPanel2.Controls.Add(this.LeftTick);
            this.separatorPanel2.Controls.Add(this.RightTick);
            this.separatorPanel2.Location = new System.Drawing.Point(21, 105);
            this.separatorPanel2.Name = "separatorPanel2";
            this.separatorPanel2.Size = new System.Drawing.Size(228, 73);
            this.separatorPanel2.TabIndex = 3;
            this.separatorPanel2.Thickness = 2F;
            // 
            // ClickCombo
            // 
            this.ClickCombo.BackColor = System.Drawing.Color.Gainsboro;
            this.ClickCombo.ForeColor = System.Drawing.Color.DimGray;
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
            this.MiddleTick.ForeColor = System.Drawing.Color.Gainsboro;
            this.MiddleTick.Location = new System.Drawing.Point(123, 12);
            this.MiddleTick.Name = "MiddleTick";
            this.MiddleTick.Size = new System.Drawing.Size(71, 21);
            this.MiddleTick.TabIndex = 2;
            this.MiddleTick.Text = "Middle";
            this.MiddleTick.UseVisualStyleBackColor = true;
            // 
            // LeftTick
            // 
            this.LeftTick.AutoSize = true;
            this.LeftTick.Checked = true;
            this.LeftTick.CheckState = System.Windows.Forms.CheckState.Checked;
            this.LeftTick.ForeColor = System.Drawing.Color.Gainsboro;
            this.LeftTick.Location = new System.Drawing.Point(13, 39);
            this.LeftTick.Name = "LeftTick";
            this.LeftTick.Size = new System.Drawing.Size(54, 21);
            this.LeftTick.TabIndex = 1;
            this.LeftTick.Text = "Left";
            this.LeftTick.UseVisualStyleBackColor = true;
            // 
            // RightTick
            // 
            this.RightTick.AutoSize = true;
            this.RightTick.ForeColor = System.Drawing.Color.Gainsboro;
            this.RightTick.Location = new System.Drawing.Point(13, 12);
            this.RightTick.Name = "RightTick";
            this.RightTick.Size = new System.Drawing.Size(63, 21);
            this.RightTick.TabIndex = 0;
            this.RightTick.Text = "Right";
            this.RightTick.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(18, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Click Interval";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(18, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Click Options";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(254, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Click Repeat";
            // 
            // separator2
            // 
            this.separator2.BackColor = System.Drawing.Color.Transparent;
            this.separator2.ForeColor = System.Drawing.Color.DimGray;
            this.separator2.Location = new System.Drawing.Point(21, 98);
            this.separator2.Name = "separator2";
            this.separator2.SeparatorThickness = 0F;
            this.separator2.Size = new System.Drawing.Size(475, 10);
            this.separator2.TabIndex = 1;
            this.separator2.Text = "separator2";
            // 
            // separator3
            // 
            this.separator3.BackColor = System.Drawing.Color.Transparent;
            this.separator3.ForeColor = System.Drawing.Color.DimGray;
            this.separator3.Location = new System.Drawing.Point(21, 23);
            this.separator3.Name = "separator3";
            this.separator3.SeparatorThickness = 0F;
            this.separator3.Size = new System.Drawing.Size(476, 10);
            this.separator3.TabIndex = 10;
            this.separator3.Text = "separator3";
            // 
            // separatorPanel1
            // 
            this.separatorPanel1.BorderColor = System.Drawing.Color.DimGray;
            this.separatorPanel1.Controls.Add(this.HotKeyBox);
            this.separatorPanel1.Controls.Add(this.AlwaysTopTick);
            this.separatorPanel1.Controls.Add(this.label10);
            this.separatorPanel1.Location = new System.Drawing.Point(21, 208);
            this.separatorPanel1.Name = "separatorPanel1";
            this.separatorPanel1.Size = new System.Drawing.Size(474, 38);
            this.separatorPanel1.TabIndex = 11;
            this.separatorPanel1.Thickness = 0F;
            // 
            // HotKeyBox
            // 
            this.HotKeyBox.BackColor = System.Drawing.Color.Gainsboro;
            this.HotKeyBox.ForeColor = System.Drawing.Color.DimGray;
            this.HotKeyBox.Location = new System.Drawing.Point(10, 7);
            this.HotKeyBox.Name = "HotKeyBox";
            this.HotKeyBox.Size = new System.Drawing.Size(117, 22);
            this.HotKeyBox.TabIndex = 12;
            this.HotKeyBox.Text = "F6";
            this.HotKeyBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HotKeyBox.Click += new System.EventHandler(this.HotKeyBox_Click);
            // 
            // AlwaysTopTick
            // 
            this.AlwaysTopTick.AutoSize = true;
            this.AlwaysTopTick.Checked = true;
            this.AlwaysTopTick.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AlwaysTopTick.ForeColor = System.Drawing.Color.Gainsboro;
            this.AlwaysTopTick.Location = new System.Drawing.Point(306, 6);
            this.AlwaysTopTick.Name = "AlwaysTopTick";
            this.AlwaysTopTick.Size = new System.Drawing.Size(117, 21);
            this.AlwaysTopTick.TabIndex = 11;
            this.AlwaysTopTick.Text = "Always on top";
            this.AlwaysTopTick.UseVisualStyleBackColor = true;
            this.AlwaysTopTick.CheckedChanged += new System.EventHandler(this.AlwaysTopTick_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Gainsboro;
            this.label10.Location = new System.Drawing.Point(133, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Start/Stop Hotkey";
            // 
            // separator1
            // 
            this.separator1.BackColor = System.Drawing.Color.Transparent;
            this.separator1.ForeColor = System.Drawing.Color.DimGray;
            this.separator1.Location = new System.Drawing.Point(21, 201);
            this.separator1.Name = "separator1";
            this.separator1.SeparatorThickness = 0F;
            this.separator1.Size = new System.Drawing.Size(475, 10);
            this.separator1.TabIndex = 12;
            this.separator1.Text = "separator1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(18, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Settings";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(514, 332);
            this.Controls.Add(this.separator1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.separatorPanel1);
            this.Controls.Add(this.separator3);
            this.Controls.Add(this.separator2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.separatorPanel4);
            this.Controls.Add(this.separatorPanel3);
            this.Controls.Add(this.separatorPanel2);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartButton);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Auto Clicker";
            this.separatorPanel3.ResumeLayout(false);
            this.separatorPanel3.PerformLayout();
            this.separatorPanel4.ResumeLayout(false);
            this.separatorPanel4.PerformLayout();
            this.separatorPanel2.ResumeLayout(false);
            this.separatorPanel2.PerformLayout();
            this.separatorPanel1.ResumeLayout(false);
            this.separatorPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Iswenzz.UI.Controls.Buttons.FlatButton StartButton;
        private Iswenzz.UI.Controls.Buttons.FlatButton StopButton;
        private Iswenzz.UI.Controls.Containers.SeparatorPanel separatorPanel3;
        private Iswenzz.UI.Controls.Containers.SeparatorPanel separatorPanel4;
        private Iswenzz.UI.Controls.Containers.SeparatorPanel separatorPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MSBox;
        private System.Windows.Forms.TextBox SecBox;
        private System.Windows.Forms.TextBox MinBox;
        private System.Windows.Forms.TextBox HourBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox MiddleTick;
        private System.Windows.Forms.CheckBox LeftTick;
        private System.Windows.Forms.CheckBox RightTick;
        private System.Windows.Forms.RadioButton RepeatButton;
        private System.Windows.Forms.RadioButton RepeatAmountButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox RepeatBox;
        private Iswenzz.UI.Controls.Separator separator3;
        private Iswenzz.UI.Controls.Separator separator2;
        private Iswenzz.UI.Controls.Containers.SeparatorPanel separatorPanel1;
        private Iswenzz.UI.Controls.Separator separator1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox AlwaysTopTick;
        private System.Windows.Forms.Label HotKeyBox;
        private System.Windows.Forms.ComboBox ClickCombo;
    }
}

