using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rezervace.UserControls
{
    public partial class ChangePassword : Form
    {
        private readonly string _username;
        public ChangePassword()
        {
            _username = MainForm.Username;
            InitializeComponent();
        }

        public ChangePassword(string username)
        {
            _username = username;
            InitializeComponent();
        }

        private void ConfirmBttn_Click(object sender, EventArgs e)
        {
            if (!NewPasswordTextbox.Text.Equals(NewPasswordAgainTextbox.Text))
            {
                MessageBox.Show("New passwords missmatch");
            } else if (!LoginController.CheckLogin(_username, OldPassword.Text) && !MainForm.IsAdmin) {
                MessageBox.Show("Old password is invalid");
            } else
            {
                if (Controller.Conn.changePassword(_username, LoginController.ComputeHash(NewPasswordTextbox.Text)).Result) {
                    MessageBox.Show("Password has been changed");
                    DialogResult = DialogResult.OK;
                }
            }
        }
    }
}
