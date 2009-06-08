namespace SpeakingClock
{
    partial class SettingsConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsConfig));
            this.uxOK = new System.Windows.Forms.Button();
            this.uxFrequency = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.uxVolume = new System.Windows.Forms.TrackBar();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.uxHuman = new System.Windows.Forms.RadioButton();
            this.ux12Hour = new System.Windows.Forms.RadioButton();
            this.ux24Hour = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.uxAlarmOn = new System.Windows.Forms.RadioButton();
            this.uxAlarmOff = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.uxMinutes = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.uxRepeatDaily = new System.Windows.Forms.RadioButton();
            this.uxRepeatMonFri = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.uxHours = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxVolume)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxMinutes)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxHours)).BeginInit();
            this.SuspendLayout();
            // 
            // uxOK
            // 
            this.uxOK.Location = new System.Drawing.Point(232, 372);
            this.uxOK.Name = "uxOK";
            this.uxOK.Size = new System.Drawing.Size(48, 23);
            this.uxOK.TabIndex = 0;
            this.uxOK.Text = "OK";
            this.uxOK.UseVisualStyleBackColor = true;
            this.uxOK.Click += new System.EventHandler(this.uxOK_Click);
            // 
            // uxFrequency
            // 
            this.uxFrequency.FormattingEnabled = true;
            this.uxFrequency.Location = new System.Drawing.Point(128, 21);
            this.uxFrequency.Name = "uxFrequency";
            this.uxFrequency.Size = new System.Drawing.Size(121, 24);
            this.uxFrequency.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.uxFrequency);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 187);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Frequency";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.uxVolume);
            this.groupBox5.Location = new System.Drawing.Point(9, 102);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(253, 79);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Volume";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(207, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "max";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "min";
            // 
            // uxVolume
            // 
            this.uxVolume.Location = new System.Drawing.Point(4, 21);
            this.uxVolume.Maximum = 100;
            this.uxVolume.Name = "uxVolume";
            this.uxVolume.Size = new System.Drawing.Size(243, 50);
            this.uxVolume.TabIndex = 0;
            this.uxVolume.TickFrequency = 10;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.uxHuman);
            this.groupBox4.Controls.Add(this.ux12Hour);
            this.groupBox4.Controls.Add(this.ux24Hour);
            this.groupBox4.Location = new System.Drawing.Point(9, 51);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(253, 45);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Time Format";
            // 
            // uxHuman
            // 
            this.uxHuman.AutoSize = true;
            this.uxHuman.Location = new System.Drawing.Point(163, 19);
            this.uxHuman.Name = "uxHuman";
            this.uxHuman.Size = new System.Drawing.Size(69, 20);
            this.uxHuman.TabIndex = 2;
            this.uxHuman.TabStop = true;
            this.uxHuman.Text = "Human";
            this.uxHuman.UseVisualStyleBackColor = true;
            // 
            // ux12Hour
            // 
            this.ux12Hour.AutoSize = true;
            this.ux12Hour.Location = new System.Drawing.Point(85, 19);
            this.ux12Hour.Name = "ux12Hour";
            this.ux12Hour.Size = new System.Drawing.Size(72, 20);
            this.ux12Hour.TabIndex = 1;
            this.ux12Hour.TabStop = true;
            this.ux12Hour.Text = "12 Hour";
            this.ux12Hour.UseVisualStyleBackColor = true;
            // 
            // ux24Hour
            // 
            this.ux24Hour.AutoSize = true;
            this.ux24Hour.Location = new System.Drawing.Point(7, 19);
            this.ux24Hour.Name = "ux24Hour";
            this.ux24Hour.Size = new System.Drawing.Size(72, 20);
            this.ux24Hour.TabIndex = 0;
            this.ux24Hour.TabStop = true;
            this.ux24Hour.Text = "24 Hour";
            this.ux24Hour.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Announce every :";
            // 
            // uxAlarmOn
            // 
            this.uxAlarmOn.AutoSize = true;
            this.uxAlarmOn.Location = new System.Drawing.Point(81, 24);
            this.uxAlarmOn.Name = "uxAlarmOn";
            this.uxAlarmOn.Size = new System.Drawing.Size(43, 20);
            this.uxAlarmOn.TabIndex = 0;
            this.uxAlarmOn.TabStop = true;
            this.uxAlarmOn.Text = "On";
            this.uxAlarmOn.UseVisualStyleBackColor = true;
            // 
            // uxAlarmOff
            // 
            this.uxAlarmOff.AutoSize = true;
            this.uxAlarmOff.Location = new System.Drawing.Point(130, 24);
            this.uxAlarmOff.Name = "uxAlarmOff";
            this.uxAlarmOff.Size = new System.Drawing.Size(42, 20);
            this.uxAlarmOff.TabIndex = 1;
            this.uxAlarmOff.TabStop = true;
            this.uxAlarmOff.Text = "Off";
            this.uxAlarmOff.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Alarm is :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Trigger Time :";
            // 
            // uxMinutes
            // 
            this.uxMinutes.Location = new System.Drawing.Point(158, 79);
            this.uxMinutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.uxMinutes.Name = "uxMinutes";
            this.uxMinutes.Size = new System.Drawing.Size(43, 22);
            this.uxMinutes.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.uxHours);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.uxMinutes);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.uxAlarmOff);
            this.groupBox2.Controls.Add(this.uxAlarmOn);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 205);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(268, 161);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Alarm Options";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.uxRepeatDaily);
            this.groupBox3.Controls.Add(this.uxRepeatMonFri);
            this.groupBox3.Location = new System.Drawing.Point(9, 107);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(253, 47);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Repeat Options";
            // 
            // uxRepeatDaily
            // 
            this.uxRepeatDaily.AutoSize = true;
            this.uxRepeatDaily.Location = new System.Drawing.Point(13, 19);
            this.uxRepeatDaily.Name = "uxRepeatDaily";
            this.uxRepeatDaily.Size = new System.Drawing.Size(89, 20);
            this.uxRepeatDaily.TabIndex = 15;
            this.uxRepeatDaily.TabStop = true;
            this.uxRepeatDaily.Text = "Every Day";
            this.uxRepeatDaily.UseVisualStyleBackColor = true;
            // 
            // uxRepeatMonFri
            // 
            this.uxRepeatMonFri.AutoSize = true;
            this.uxRepeatMonFri.Location = new System.Drawing.Point(110, 19);
            this.uxRepeatMonFri.Name = "uxRepeatMonFri";
            this.uxRepeatMonFri.Size = new System.Drawing.Size(130, 20);
            this.uxRepeatMonFri.TabIndex = 14;
            this.uxRepeatMonFri.TabStop = true;
            this.uxRepeatMonFri.Text = "Monday to Friday";
            this.uxRepeatMonFri.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(103, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Hours";
            // 
            // uxHours
            // 
            this.uxHours.Location = new System.Drawing.Point(158, 53);
            this.uxHours.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.uxHours.Name = "uxHours";
            this.uxHours.Size = new System.Drawing.Size(43, 22);
            this.uxHours.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Minutes";
            // 
            // SettingsConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 404);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.uxOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxVolume)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxMinutes)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxHours)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uxOK;
        private System.Windows.Forms.ComboBox uxFrequency;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton uxAlarmOn;
        private System.Windows.Forms.RadioButton uxAlarmOff;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown uxMinutes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown uxHours;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton uxRepeatDaily;
        private System.Windows.Forms.RadioButton uxRepeatMonFri;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton uxHuman;
        private System.Windows.Forms.RadioButton ux12Hour;
        private System.Windows.Forms.RadioButton ux24Hour;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TrackBar uxVolume;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}