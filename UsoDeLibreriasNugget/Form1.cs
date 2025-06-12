namespace UsoDeLibreriasNugget
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSerializar_Click(object sender, EventArgs e)
        {
            string json = accountJson(
                    new Account
                    {
                        name = txtName.Text.Trim(),
                        email = txtEmail.Text.Trim(),
                        DOB = dtpDOB.Value
                    }
                );
            lblSerializar.Text = json;
        }
        private string accountJson(Account account)
        {
            // Serializa el objeto account a JSON 
            return Newtonsoft.Json.JsonConvert.SerializeObject(account);
        }

    }
}
