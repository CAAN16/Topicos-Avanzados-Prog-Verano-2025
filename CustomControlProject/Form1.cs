namespace CustomControlProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UpdateNameLabel()
        {
            if (string.IsNullOrWhiteSpace(ctlFirstName.Text) || (string.IsNullOrWhiteSpace(ctlLastName.Text)))
            {
                lblFullName.Text = "Please fill out both the first name and the last name";
            }
            else
            {
                lblFullName.Text = $"Hola {ctlFirstName.Text} {ctlLastName.Text}, ¡ Que tengas un buen día !";
            }
        }

        private void ctlFirstName_TextChanged(object sender, EventArgs e)
        {
            UpdateNameLabel();
        }

        private void ctlLastName_TextChanged(object sender, EventArgs e)
        {
            UpdateNameLabel();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateNameLabel();
        }
    }
}
