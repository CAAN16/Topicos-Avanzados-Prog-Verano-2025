namespace Names
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
            btnAdd = new Button();
            lstNames = new ListBox();
            txtName = new TextBox();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.MenuHighlight;
            btnAdd.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = SystemColors.ButtonHighlight;
            btnAdd.Location = new Point(249, 120);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(114, 42);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Agregar";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // lstNames
            // 
            lstNames.BackColor = Color.CornflowerBlue;
            lstNames.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lstNames.ForeColor = SystemColors.ButtonHighlight;
            lstNames.FormattingEnabled = true;
            lstNames.ItemHeight = 23;
            lstNames.Location = new Point(30, 43);
            lstNames.Name = "lstNames";
            lstNames.Size = new Size(129, 119);
            lstNames.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.BackColor = Color.CornflowerBlue;
            txtName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.ForeColor = SystemColors.ButtonHighlight;
            txtName.Location = new Point(194, 57);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(231, 34);
            txtName.TabIndex = 2;
            txtName.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(481, 207);
            Controls.Add(txtName);
            Controls.Add(lstNames);
            Controls.Add(btnAdd);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private ListBox lstNames;
        private TextBox txtName;
    }
}
