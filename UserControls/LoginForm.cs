namespace Rezervace
{
    public partial class Login : Form
    {
        public string Username;
        public Login()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (LoginController.CheckLogin(LoginTextBox.Text, PasswordTextBox.Text))
            {
                Username = LoginTextBox.Text;
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Invalid credentials");
            }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            Hide();
            RegisterForm registerDialog = new();
            if (registerDialog.ShowDialog() == DialogResult.OK)
            {
                if (registerDialog.Username != null && registerDialog.Password != null)
                {
                    Username = registerDialog.Username;
                    if (LoginController.CheckLogin(registerDialog.Username, registerDialog.Password))
                    {
                        DialogResult = DialogResult.OK;
                    }
                }
            }
            else
            {
                Show();
            }
        }
    }
}