namespace ctlClockLib
{
    partial class ctlAlarmClock
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblAlarm = new Label();
            btnAlarmOff = new Button();
            SuspendLayout();
            // 
            // lblAlarm
            // 
            lblAlarm.AutoSize = true;
            lblAlarm.Font = new Font("Segoe UI", 13F);
            lblAlarm.Location = new Point(0, 0);
            lblAlarm.Name = "lblAlarm";
            lblAlarm.Size = new Size(93, 30);
            lblAlarm.TabIndex = 0;
            lblAlarm.Text = "¡Alarma!";
            lblAlarm.TextAlign = ContentAlignment.MiddleCenter;
            lblAlarm.Visible = false;
            // 
            // btnAlarmOff
            // 
            btnAlarmOff.Location = new Point(43, 58);
            btnAlarmOff.Name = "btnAlarmOff";
            btnAlarmOff.Size = new Size(169, 29);
            btnAlarmOff.TabIndex = 1;
            btnAlarmOff.Text = "Deshabilitar alarma";
            btnAlarmOff.UseVisualStyleBackColor = true;
            btnAlarmOff.Click += btnAlarmOff_Click;
            // 
            // ctlAlarmClock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            Controls.Add(btnAlarmOff);
            Controls.Add(lblAlarm);
            Name = "ctlAlarmClock";
            Size = new Size(258, 134);
            Controls.SetChildIndex(lblAlarm, 0);
            Controls.SetChildIndex(btnAlarmOff, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAlarm;
        private Button btnAlarmOff;
    }
}
