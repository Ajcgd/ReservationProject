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
    public partial class UserDetails : Form
    {
        public string? nameValue;
        public string? surnameValue;
        public int? licenceValue;
        public DateTime DoBvalue;
        public Sex? sexValue;
        public UserDetails(UserDataDto data)
        {
            InitializeComponent();
            RealName.Text = data.name ?? "";
            Surname.Text = data.surname ?? "";
            License.Text = data.licence.ToString() ?? "";
            DoB.Value = data.dob.GetValueOrDefault(DateTime.Now);
            switch (data.sex)
            {
                case Sex.Male:
                    SexComboBox.SelectedItem = SexComboBox.Items[0];
                    break;
                case Sex.Female:
                    SexComboBox.SelectedItem = SexComboBox.Items[1];
                    break;
                case Sex.Other:
                    SexComboBox.SelectedItem = SexComboBox.Items[2];
                    break;
                default:
                    break;
            }
        }

        private void ConfirmBttn_Click(object sender, EventArgs e)
        {
            if (DoB.Value > DateTime.Now)
            {
                MessageBox.Show("Date of birth must not be in future");
            } else if (License.Text.Length != 0 && (!int.TryParse(License.Text, out _) || License.Text.Length > 6))
            {
                MessageBox.Show("License number must be numeric and at most 6 numbers");
            }
            else
            {
                nameValue = RealName.Text.Length == 0 ? null : RealName.Text;
                surnameValue = Surname.Text.Length == 0 ? null : Surname.Text;
                if (License.Text.Length == 0)
                {
                    licenceValue = null;
                } else
                {
                    int.TryParse(License.Text, out int tmp);
                    licenceValue = tmp;

                }
                DoBvalue = DoB.Value;
                sexValue = SexComboBox.SelectedIndex == 3 || SexComboBox.SelectedItem == null? null : Enum.Parse<Sex>(SexComboBox.SelectedItem.ToString()!);

                DialogResult = DialogResult.OK;
            }
        }

        private void ChangePasswordBttn_Click(object sender, EventArgs e)
        {
            UserControls.ChangePassword changePassword = new();
            changePassword.ShowDialog();
        }
    }
}
