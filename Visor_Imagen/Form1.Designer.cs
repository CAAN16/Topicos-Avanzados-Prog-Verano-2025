namespace Visor_Imagen
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
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            checkBox1 = new CheckBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnMostrarImg = new Button();
            btnBorrarImg = new Button();
            btnEstColor = new Button();
            btnCerrar = new Button();
            openFileDialog1 = new OpenFileDialog();
            colorDialog1 = new ColorDialog();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.728549F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 86.2714539F));
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 1, 1);
            tableLayoutPanel1.Controls.Add(checkBox1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 90.4884338F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.511568F));
            tableLayoutPanel1.Size = new Size(711, 389);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            tableLayoutPanel1.SetColumnSpan(pictureBox1, 2);
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(705, 346);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(3, 355);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(63, 19);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "Ajustar";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnMostrarImg);
            flowLayoutPanel1.Controls.Add(btnBorrarImg);
            flowLayoutPanel1.Controls.Add(btnEstColor);
            flowLayoutPanel1.Controls.Add(btnCerrar);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(100, 355);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(608, 31);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // btnMostrarImg
            // 
            btnMostrarImg.Location = new Point(477, 3);
            btnMostrarImg.Name = "btnMostrarImg";
            btnMostrarImg.Size = new Size(128, 23);
            btnMostrarImg.TabIndex = 0;
            btnMostrarImg.Text = "Mostrar Imagen";
            btnMostrarImg.UseVisualStyleBackColor = true;
            btnMostrarImg.Click += button1_Click;
            // 
            // btnBorrarImg
            // 
            btnBorrarImg.Location = new Point(341, 3);
            btnBorrarImg.Name = "btnBorrarImg";
            btnBorrarImg.Size = new Size(130, 23);
            btnBorrarImg.TabIndex = 1;
            btnBorrarImg.Text = "Borrar Imagen";
            btnBorrarImg.UseVisualStyleBackColor = true;
            btnBorrarImg.Click += btnBorrarImg_Click;
            // 
            // btnEstColor
            // 
            btnEstColor.Location = new Point(210, 3);
            btnEstColor.Name = "btnEstColor";
            btnEstColor.Size = new Size(125, 23);
            btnEstColor.TabIndex = 2;
            btnEstColor.Text = "Establecer Color";
            btnEstColor.UseVisualStyleBackColor = true;
            btnEstColor.Click += btnEstColor_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(110, 3);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(94, 23);
            btnCerrar.TabIndex = 3;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "PNG|*.png|JPG|*.jpg|GIF|*.gif|JPEG|*.jpeg";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(711, 389);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private CheckBox checkBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnMostrarImg;
        private Button btnBorrarImg;
        private Button btnEstColor;
        private Button btnCerrar;
        private OpenFileDialog openFileDialog1;
        private ColorDialog colorDialog1;
    }
}
