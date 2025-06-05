namespace Names
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(txtName.Text) && (!lstNames.Items.Contains(txtName.Text))) {
                lstNames.Items.Add(txtName.Text);
                txtName.Clear();
            }
            else{
                MessageBox.Show("No es posible ingrear cadenas vacias, con espacios en blanco o nombres repetidos");
            }
        }
    }
}
