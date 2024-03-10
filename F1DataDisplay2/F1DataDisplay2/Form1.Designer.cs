namespace F1DataDisplay2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelDate = new Label();
            labelMeetingKey = new Label();
            labelSessionKey = new Label();
            labelDriverNumber = new Label();
            labelSpeed = new Label();
            labelGear = new Label();
            labelDRS = new Label();
            barThrottle = new ProgressBar();
            barBrake = new ProgressBar();
            barRPM = new ProgressBar();
            labelBrake = new Label();
            labelThrottle = new Label();
            labelRPM = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            progressBar1 = new ProgressBar();
            progressBar2 = new ProgressBar();
            progressBar3 = new ProgressBar();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            labelDriver = new Label();
            SuspendLayout();
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelDate.ForeColor = SystemColors.ButtonHighlight;
            labelDate.Location = new Point(12, 9);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(202, 19);
            labelDate.TabIndex = 0;
            labelDate.Text = "2024-03-01T17:03:36.050000";
            // 
            // labelMeetingKey
            // 
            labelMeetingKey.AutoSize = true;
            labelMeetingKey.Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelMeetingKey.ForeColor = SystemColors.ButtonHighlight;
            labelMeetingKey.Location = new Point(240, 9);
            labelMeetingKey.Name = "labelMeetingKey";
            labelMeetingKey.Size = new Size(127, 19);
            labelMeetingKey.TabIndex = 1;
            labelMeetingKey.Text = "Meeting Key: 1229";
            // 
            // labelSessionKey
            // 
            labelSessionKey.AutoSize = true;
            labelSessionKey.Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelSessionKey.ForeColor = SystemColors.ButtonHighlight;
            labelSessionKey.Location = new Point(391, 9);
            labelSessionKey.Name = "labelSessionKey";
            labelSessionKey.Size = new Size(122, 19);
            labelSessionKey.TabIndex = 2;
            labelSessionKey.Text = "Session Key: 9427";
            // 
            // labelDriverNumber
            // 
            labelDriverNumber.AutoSize = true;
            labelDriverNumber.Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelDriverNumber.ForeColor = SystemColors.ButtonHighlight;
            labelDriverNumber.Location = new Point(12, 38);
            labelDriverNumber.Name = "labelDriverNumber";
            labelDriverNumber.Size = new Size(72, 19);
            labelDriverNumber.TabIndex = 3;
            labelDriverNumber.Text = "Driver: 44";
            // 
            // labelSpeed
            // 
            labelSpeed.AutoSize = true;
            labelSpeed.Font = new Font("Sylfaen", 36F, FontStyle.Regular, GraphicsUnit.Point);
            labelSpeed.ForeColor = SystemColors.ButtonHighlight;
            labelSpeed.Location = new Point(12, 57);
            labelSpeed.Name = "labelSpeed";
            labelSpeed.Size = new Size(124, 79);
            labelSpeed.TabIndex = 4;
            labelSpeed.Text = "275";
            // 
            // labelGear
            // 
            labelGear.AutoSize = true;
            labelGear.Font = new Font("Sylfaen", 36F, FontStyle.Regular, GraphicsUnit.Point);
            labelGear.ForeColor = SystemColors.ButtonHighlight;
            labelGear.Location = new Point(150, 57);
            labelGear.Name = "labelGear";
            labelGear.Size = new Size(64, 79);
            labelGear.TabIndex = 5;
            labelGear.Text = "7";
            // 
            // labelDRS
            // 
            labelDRS.AutoSize = true;
            labelDRS.Font = new Font("Sylfaen", 36F, FontStyle.Regular, GraphicsUnit.Point);
            labelDRS.ForeColor = SystemColors.ButtonHighlight;
            labelDRS.Location = new Point(240, 57);
            labelDRS.Name = "labelDRS";
            labelDRS.Size = new Size(205, 79);
            labelDRS.TabIndex = 7;
            labelDRS.Text = "DRS: 2";
            // 
            // barThrottle
            // 
            barThrottle.Location = new Point(12, 149);
            barThrottle.Name = "barThrottle";
            barThrottle.Size = new Size(374, 122);
            barThrottle.TabIndex = 8;
            barThrottle.Value = 35;
            // 
            // barBrake
            // 
            barBrake.Location = new Point(12, 292);
            barBrake.Name = "barBrake";
            barBrake.Size = new Size(374, 122);
            barBrake.TabIndex = 9;
            barBrake.Value = 85;
            // 
            // barRPM
            // 
            barRPM.Location = new Point(12, 434);
            barRPM.Name = "barRPM";
            barRPM.Size = new Size(374, 122);
            barRPM.TabIndex = 10;
            barRPM.Value = 75;
            // 
            // labelBrake
            // 
            labelBrake.AutoSize = true;
            labelBrake.Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelBrake.ForeColor = SystemColors.ButtonHighlight;
            labelBrake.Location = new Point(12, 270);
            labelBrake.Name = "labelBrake";
            labelBrake.Size = new Size(49, 19);
            labelBrake.TabIndex = 12;
            labelBrake.Text = "Brake:";
            // 
            // labelThrottle
            // 
            labelThrottle.AutoSize = true;
            labelThrottle.Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelThrottle.ForeColor = SystemColors.ButtonHighlight;
            labelThrottle.Location = new Point(12, 127);
            labelThrottle.Name = "labelThrottle";
            labelThrottle.Size = new Size(62, 19);
            labelThrottle.TabIndex = 13;
            labelThrottle.Text = "Throttle:";
            // 
            // labelRPM
            // 
            labelRPM.AutoSize = true;
            labelRPM.Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelRPM.ForeColor = SystemColors.ButtonHighlight;
            labelRPM.Location = new Point(12, 412);
            labelRPM.Name = "labelRPM";
            labelRPM.Size = new Size(45, 19);
            labelRPM.TabIndex = 14;
            labelRPM.Text = "RPM:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(737, 412);
            label1.Name = "label1";
            label1.Size = new Size(45, 19);
            label1.TabIndex = 24;
            label1.Text = "RPM:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(737, 127);
            label2.Name = "label2";
            label2.Size = new Size(62, 19);
            label2.TabIndex = 23;
            label2.Text = "Throttle:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(737, 270);
            label3.Name = "label3";
            label3.Size = new Size(49, 19);
            label3.TabIndex = 22;
            label3.Text = "Brake:";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(737, 434);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(374, 122);
            progressBar1.TabIndex = 21;
            progressBar1.Value = 95;
            // 
            // progressBar2
            // 
            progressBar2.Location = new Point(737, 292);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(374, 122);
            progressBar2.TabIndex = 20;
            progressBar2.Value = 7;
            // 
            // progressBar3
            // 
            progressBar3.Location = new Point(737, 149);
            progressBar3.Name = "progressBar3";
            progressBar3.Size = new Size(374, 122);
            progressBar3.TabIndex = 19;
            progressBar3.Value = 90;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sylfaen", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(965, 57);
            label4.Name = "label4";
            label4.Size = new Size(205, 79);
            label4.TabIndex = 18;
            label4.Text = "DRS: 2";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sylfaen", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(875, 57);
            label5.Name = "label5";
            label5.Size = new Size(64, 79);
            label5.TabIndex = 17;
            label5.Text = "5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sylfaen", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(737, 57);
            label6.Name = "label6";
            label6.Size = new Size(124, 79);
            label6.TabIndex = 16;
            label6.Text = "133";
            // 
            // labelDriver
            // 
            labelDriver.AutoSize = true;
            labelDriver.Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelDriver.ForeColor = SystemColors.ButtonHighlight;
            labelDriver.Location = new Point(737, 38);
            labelDriver.Name = "labelDriver";
            labelDriver.Size = new Size(72, 19);
            labelDriver.TabIndex = 15;
            labelDriver.Text = "Driver: 63";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1227, 803);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(progressBar1);
            Controls.Add(progressBar2);
            Controls.Add(progressBar3);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(labelDriver);
            Controls.Add(labelRPM);
            Controls.Add(labelThrottle);
            Controls.Add(labelBrake);
            Controls.Add(barRPM);
            Controls.Add(barBrake);
            Controls.Add(barThrottle);
            Controls.Add(labelDRS);
            Controls.Add(labelGear);
            Controls.Add(labelSpeed);
            Controls.Add(labelDriverNumber);
            Controls.Add(labelSessionKey);
            Controls.Add(labelMeetingKey);
            Controls.Add(labelDate);
            ForeColor = SystemColors.ControlText;
            Name = "Form1";
            Text = "F1 Data Display";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelDate;
        private Label labelMeetingKey;
        private Label labelSessionKey;
        private Label labelDriverNumber;
        private Label labelSpeed;
        private Label labelGear;
        private Label labelDRS;
        private ProgressBar barThrottle;
        private ProgressBar barBrake;
        private ProgressBar barRPM;
        private Label labelBrake;
        private Label labelThrottle;
        private Label labelRPM;
        private Label label1;
        private Label label2;
        private Label label3;
        private ProgressBar progressBar1;
        private ProgressBar progressBar2;
        private ProgressBar progressBar3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label labelDriver;
    }
}