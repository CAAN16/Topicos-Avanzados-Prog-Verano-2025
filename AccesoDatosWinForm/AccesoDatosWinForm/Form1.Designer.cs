namespace AccesoDatosWinForm
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
            btnGuardar = new Button();
            cboCAtegory = new ComboBox();
            dgv = new DataGridView();
            btnSaveAsync = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(458, 212);
            btnGuardar.Margin = new Padding(2, 2, 2, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(78, 20);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // cboCAtegory
            // 
            cboCAtegory.FormattingEnabled = true;
            cboCAtegory.Location = new Point(8, 7);
            cboCAtegory.Margin = new Padding(2, 2, 2, 2);
            cboCAtegory.Name = "cboCAtegory";
            cboCAtegory.Size = new Size(237, 23);
            cboCAtegory.TabIndex = 1;
            // 
            // dgv
            // 
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(8, 39);
            dgv.Margin = new Padding(2, 2, 2, 2);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 62;
            dgv.Size = new Size(541, 143);
            dgv.TabIndex = 2;
            // 
            // btnSaveAsync
            // 
            btnSaveAsync.Location = new Point(412, 236);
            btnSaveAsync.Margin = new Padding(2, 2, 2, 2);
            btnSaveAsync.Name = "btnSaveAsync";
            btnSaveAsync.Size = new Size(130, 20);
            btnSaveAsync.TabIndex = 3;
            btnSaveAsync.Text = "Guardar Async";
            btnSaveAsync.UseVisualStyleBackColor = true;
            btnSaveAsync.Click += btnSaveAsync_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(btnSaveAsync);
            Controls.Add(dgv);
            Controls.Add(cboCAtegory);
            Controls.Add(btnGuardar);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnGuardar;
        private ComboBox cboCAtegory;
        private DataGridView dgv;
        private Button btnSaveAsync;
    }
}
