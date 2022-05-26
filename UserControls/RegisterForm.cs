using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rezervace
{
    public partial class RegisterForm : Form
    {
        public string? Username;
        public string? Password;
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterBttn_Click(object sender, EventArgs e)
        {
            if (LoginTextbox.Text.Length == 0 || PasswordTextbox.Text.Length == 0 || PasswordAgainTextbox.Text.Length == 0)
            {
                MessageBox.Show("Fill all fields please");
            } else if (!PasswordTextbox.Text.Equals(PasswordTextbox.Text))
            {
                MessageBox.Show("Passwords missmatch");
            } else if (Controller.Conn.CheckUserExist(LoginTextbox.Text).Result)
            {
                MessageBox.Show("This username is taken");
            } else
            {
                if (LoginController.Register(LoginTextbox.Text, PasswordTextbox.Text).Result)
                {
                    Username = LoginTextbox.Text;
                    Password = PasswordTextbox.Text;
                    DialogResult = DialogResult.OK;
                }
            }
        }
    }
}
