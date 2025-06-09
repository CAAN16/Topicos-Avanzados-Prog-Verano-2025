namespace Visor_Imagen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.IO.Stream mystream = null;
            openFileDialog1.Title = "Seleccione una imagen";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((mystream = openFileDialog1.OpenFile()) != null)
                    {
                        using (mystream)
                        {
                            pictureBox1.Image = Image.FromStream(mystream);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la imagen" + ex.Message);
                }
            }
        }

        private void btnBorrarImg_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            else
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void btnEstColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                flowLayoutPanel1.BackColor = colorDialog1.Color;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
