namespace DreamLock
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "admin" && passwordTextBox.Text == "admin")
            {
                this.Hide();
                Panel panel = new Panel();
                panel.ShowDialog();
                this.Close();
            }
        }
    }
}
