namespace SubprocesosWinforms
{
    partial class frmFiobnacciEjemplo
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
            numericUpDown1 = new NumericUpDown();
            textBox1 = new TextBox();
            cancelAsyncButton = new Button();
            startAsyncButton = new Button();
            resultLabel = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            progressBar1 = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(49, 45);
            numericUpDown1.Margin = new Padding(3, 4, 3, 4);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(137, 27);
            numericUpDown1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(209, 44);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(254, 27);
            textBox1.TabIndex = 1;
            // 
            // cancelAsyncButton
            // 
            cancelAsyncButton.Location = new Point(281, 180);
            cancelAsyncButton.Margin = new Padding(3, 4, 3, 4);
            cancelAsyncButton.Name = "cancelAsyncButton";
            cancelAsyncButton.Size = new Size(135, 43);
            cancelAsyncButton.TabIndex = 3;
            cancelAsyncButton.Text = "Cancel";
            cancelAsyncButton.UseVisualStyleBackColor = true;
            cancelAsyncButton.Click += cancelAsyncButton_Click;
            // 
            // startAsyncButton
            // 
            startAsyncButton.Location = new Point(108, 180);
            startAsyncButton.Margin = new Padding(3, 4, 3, 4);
            startAsyncButton.Name = "startAsyncButton";
            startAsyncButton.Size = new Size(120, 43);
            startAsyncButton.TabIndex = 2;
            startAsyncButton.Text = "Start";
            startAsyncButton.UseVisualStyleBackColor = true;
            startAsyncButton.Click += startAsyncButton_Click;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(226, 150);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(50, 20);
            resultLabel.TabIndex = 4;
            resultLabel.Text = "label1";
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(49, 104);
            progressBar1.Margin = new Padding(3, 4, 3, 4);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(415, 31);
            progressBar1.TabIndex = 5;
            // 
            // frmFiobnacciEjemplo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(507, 249);
            Controls.Add(progressBar1);
            Controls.Add(resultLabel);
            Controls.Add(cancelAsyncButton);
            Controls.Add(startAsyncButton);
            Controls.Add(textBox1);
            Controls.Add(numericUpDown1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmFiobnacciEjemplo";
            Text = "Fibonacci Calculator";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDown1;
        private TextBox textBox1;
        private Button cancelAsyncButton;
        private Button startAsyncButton;
        private Label resultLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ProgressBar progressBar1;
    }
}