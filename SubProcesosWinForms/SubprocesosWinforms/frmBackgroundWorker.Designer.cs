namespace SubprocesosWinforms
{
    partial class frmBackgroundWorker
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            startAsyncButton = new Button();
            cancelAsyncButton = new Button();
            resultLabel = new Label();
            SuspendLayout();
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
            // 
            // startAsyncButton
            // 
            startAsyncButton.Location = new Point(93, 131);
            startAsyncButton.Margin = new Padding(3, 4, 3, 4);
            startAsyncButton.Name = "startAsyncButton";
            startAsyncButton.Size = new Size(86, 31);
            startAsyncButton.TabIndex = 0;
            startAsyncButton.Text = "Start";
            startAsyncButton.UseVisualStyleBackColor = true;
            startAsyncButton.Click += startAsyncButton_Click;
            // 
            // cancelAsyncButton
            // 
            cancelAsyncButton.Location = new Point(217, 131);
            cancelAsyncButton.Margin = new Padding(3, 4, 3, 4);
            cancelAsyncButton.Name = "cancelAsyncButton";
            cancelAsyncButton.Size = new Size(86, 31);
            cancelAsyncButton.TabIndex = 1;
            cancelAsyncButton.Text = "Cancel";
            cancelAsyncButton.UseVisualStyleBackColor = true;
            cancelAsyncButton.Click += cancelAsyncButton_Click;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(33, 53);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(50, 20);
            resultLabel.TabIndex = 2;
            resultLabel.Text = "label1";
            // 
            // frmBackgroundWorker
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 239);
            Controls.Add(resultLabel);
            Controls.Add(cancelAsyncButton);
            Controls.Add(startAsyncButton);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmBackgroundWorker";
            Text = "Background Worker";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button startAsyncButton;
        private Button cancelAsyncButton;
        private Label resultLabel;
    }
}