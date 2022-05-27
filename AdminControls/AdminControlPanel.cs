using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rezervace.AdminControls
{
    public partial class AdminControlPanel : Form
    {
        public AdminControlPanel()
        {
            InitializeComponent();
        }

        private void ChangeUserPasswordBttn_Click(object sender, EventArgs e)
        {
            string username = Interaction.InputBox("Specify users username", "Speicfy user");
            if (username == "")
            {
                return;
            }
            if (!Controller.Conn.CheckUserExist(username).Result)
            {
                MessageBox.Show("This username does not exist");
            }
            else
            {
                UserControls.ChangePassword changePassword = new(username);
                changePassword.ShowDialog();
            }
        }

        private void ListAllReservationsBttn_Click(object sender, EventArgs e)
        {
            ReservationsDisplay? rd = ReservationsDisplay.GetInstance(true);
            if (rd == null)
            {
                MessageBox.Show("Error occured, repeat action");
                return;
            }

            rd.ShowDialog();
        }
    }
}
