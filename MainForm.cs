using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rezervace
{
    public partial class MainForm : Form
    {
        private static string _Username;
        private static bool _IsAdmin = false;

        public static string Username 
        {
            get => _Username;
            set => _Username = value; 
        }
        public static bool IsAdmin 
        {
            get => _IsAdmin;
            set => _IsAdmin = value;
        }
        private MainForm(string Username, bool isAdmin)
        {
            MainForm.Username = Username;
            MainForm.IsAdmin = isAdmin;

            InitializeComponent();
            UsernameLabel.Text = Username;
            SystemControl.Visible = isAdmin;
        }

        public static MainForm? GetInstance(string Username, bool isAdmin, DBController conn)
        {
            if (Username == null || conn == null)
            {
                return null;
            }
            return new MainForm(Username, isAdmin);
        }

        private void ExitIcon_Click(object sender, EventArgs e)
        {
            ConfirmExit dialog = new();
            DialogResult resut = dialog.ShowDialog();
            if (resut == DialogResult.OK)
            {
                Close();
            }
        }

        private void ModifyUserData(object sender, EventArgs e)
        {
            try
            {
                UserDataDto? data = Controller.Conn.GetUserData(Username).Result;
                if (data == null)
                {
                    MessageBox.Show("DB error");
                    return;
                }

                UserDetails dialog = new((UserDataDto)(data!));
                DialogResult res = dialog.ShowDialog();
                if (res == DialogResult.OK)
                {
                    UserDataDto userData = new();
                    userData.name = dialog.nameValue;
                    userData.surname = dialog.surnameValue;
                    userData.licence = dialog.licenceValue;
                    userData.dob = dialog.DoBvalue;
                    userData.sex = dialog.sexValue;

                    Controller.Conn.SetUserData(userData);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void DisplayVehiclesBttn_Click(object sender, EventArgs e)
        {

            VehicleDisplay vd = new(null, false);
            vd.ShowDialog();
        }

        private void CreateReservationBttn_Click(object sender, EventArgs e)
        {
            ReservationCreator.Create();
        }

        private void DisplayReservationsBttn_Click(object sender, EventArgs e)
        {
            ReservationsDisplay? rd = ReservationsDisplay.GetInstance();
            if (rd != null)
            {
                rd.ShowDialog();
            }
            else
            {
                MessageBox.Show("Error occured please repeat the action");
            }
        }

        private void AdminControls_Click(object sender, EventArgs e)
        {
            AdminControls.AdminControlPanel adminControlPanel = new();
            Hide();
            adminControlPanel.ShowDialog();
            Show();
        }
    }
}
