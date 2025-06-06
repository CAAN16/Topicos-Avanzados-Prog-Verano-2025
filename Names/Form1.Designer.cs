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
            label1 = new Label();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.MenuHighlight;
            btnAdd.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = SystemColors.ButtonHighlight;
            btnAdd.Location = new Point(164, 87);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(128, 42);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add Name";
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
            lstNames.Location = new Point(12, 36);
            lstNames.Name = "lstNames";
            lstNames.Size = new Size(129, 119);
            lstNames.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.BackColor = Color.CornflowerBlue;
            txtName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.ForeColor = SystemColors.ButtonHighlight;
            txtName.Location = new Point(164, 36);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(128, 34);
            txtName.TabIndex = 2;
            txtName.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 3;
            label1.Text = "Names";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(308, 176);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(lstNames);
            Controls.Add(btnAdd);
            Name = "Form1";
            Text = "Names";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private ListBox lstNames;
        private TextBox txtName;
        private Label label1;
    }
}
