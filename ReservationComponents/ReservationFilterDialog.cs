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
    public partial class ReservationFilterDialog : Form
    {
        public FilterDTO result;
        public ReservationFilterDialog()
        {
            InitializeComponent();
        }

        private void SeatsNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void ConfirmBttn_Click(object sender, EventArgs e)
        {
            if ((MaxPrice.Text.Length != 0 && !int.TryParse(MaxPrice.Text, out _))
                || (MinPrice.Text.Length != 0 && !int.TryParse(MinPrice.Text, out _)) 
                || (MinSeats.Text.Length != 0 && !int.TryParse(MinSeats.Text, out _)) 
                || (MaxSeats.Text.Length != 0 && !!int.TryParse(MaxSeats.Text, out _)))
            {
                MessageBox.Show("Price and seats must be numbers or empty for any value");
            } else
            {
                result.Brand = Brand.Text.Length == 0 ? null : Brand.Text;
                result.Model = Model.Text.Length == 0 ? null : Model.Text;
                result.From = FromDatePicker.Value;
                result.To = ToDatePicker.Value;
                result.MaxPricePerDay = MaxPrice.Text.Length == 0 ? null : int.Parse(MaxPrice.Text);
                result.MinPricePerDay = MinPrice.Text.Length == 0 ? null : int.Parse(MinPrice.Text);
                result.MaxSeats = MaxSeats.Text.Length == 0 ? null : int.Parse(MaxSeats.Text);
                result.MinSeats = MinSeats.Text.Length == 0 ? null : int.Parse(MinSeats.Text);
                result.VClass = ClassComboBox.SelectedItem == null ? null : Enum.Parse<VehicleClass>(ClassComboBox.SelectedItem.ToString()!);
                result.Type = FuelComboBox.SelectedItem == null ?  null : Enum.Parse<FuelType>(FuelComboBox.SelectedItem.ToString()!);
                DialogResult = DialogResult.OK;
            }
            
        }
    }
}
