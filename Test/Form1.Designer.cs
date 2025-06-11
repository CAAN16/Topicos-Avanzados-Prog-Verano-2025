namespace Test
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
            ctlAlarmClock1 = new ctlClockLib.ctlAlarmClock();
            dtpTest = new DateTimePicker();
            lblTest = new Label();
            SuspendLayout();
            // 
            // ctlAlarmClock1
            // 
            ctlAlarmClock1.AlarmSet = false;
            ctlAlarmClock1.AlarmTime = new DateTime(0L);
            ctlAlarmClock1.BackColor = SystemColors.GradientInactiveCaption;
            ctlAlarmClock1.ClockBackColor = Color.Empty;
            ctlAlarmClock1.ClockForeColor = Color.Empty;
            ctlAlarmClock1.Location = new Point(12, 12);
            ctlAlarmClock1.Name = "ctlAlarmClock1";
            ctlAlarmClock1.Size = new Size(260, 118);
            ctlAlarmClock1.TabIndex = 0;
            // 
            // dtpTest
            // 
            dtpTest.Format = DateTimePickerFormat.Time;
            dtpTest.Location = new Point(62, 147);
            dtpTest.Name = "dtpTest";
            dtpTest.Size = new Size(136, 27);
            dtpTest.TabIndex = 1;
            dtpTest.ValueChanged += dtpTest_ValueChanged;
            // 
            // lblTest
            // 
            lblTest.AutoSize = true;
            lblTest.Location = new Point(53, 191);
            lblTest.Name = "lblTest";
            lblTest.Size = new Size(0, 20);
            lblTest.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(286, 234);
            Controls.Add(lblTest);
            Controls.Add(dtpTest);
            Controls.Add(ctlAlarmClock1);
            Name = "Form1";
            Text = "Test";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ctlClockLib.ctlAlarmClock ctlAlarmClock1;
        private DateTimePicker dtpTest;
        private Label lblTest;
    }
}
