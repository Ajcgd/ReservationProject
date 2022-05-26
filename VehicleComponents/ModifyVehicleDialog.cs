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
    public partial class ModifyVehicleDialog : Form
    {
        private readonly bool createNew = false;
        private VehicleDTO original;
        public ModifyVehicleDialog(VehicleDTO data, bool createNew)
        {
            InitializeComponent();

            original = data;
            this.createNew = createNew;
            DeleteBttn.Visible = !createNew;
            Brand.Text = data.Brand ?? "";
            Model.Text = data.Model ?? "";
            PricePerDay.Text = data.PricePerDay.ToString() ?? "";
            SeatsNum.Text = data.Seats.ToString() ?? "";
            switch (data.Type)
            {
                case FuelType.Benzin:
                    FuelComboBox.SelectedIndex = 0;
                    break;
                case FuelType.Diesel:
                    FuelComboBox.SelectedIndex = 1;
                    break;
                case FuelType.Electric:
                    FuelComboBox.SelectedIndex = 2;
                    break;
                case FuelType.Gas:
                    FuelComboBox.SelectedIndex = 3;
                    break;
                default:
                    break;
            }
            switch (data.VClass)
            {
                case VehicleClass.Economy:
                    ClassComboBox.SelectedIndex = 0;
                    break;
                case VehicleClass.Business:
                    ClassComboBox.SelectedIndex = 1;
                    break;
                case VehicleClass.Premium:
                    ClassComboBox.SelectedIndex = 2;
                    break;
                default:
                    break;
            }
        }

        private void ConfirmBttnC_Click(object sender, EventArgs e)
        {
            if (Brand.Text.Length == 0 || Model.Text.Length == 0 || SeatsNum.Text.Length == 0 || PricePerDay.Text.Length == 0 || FuelComboBox.SelectedItem == null || ClassComboBox.SelectedItem == null)
            {
                MessageBox.Show("All fields must fe filled");
            } else if (!int.TryParse(SeatsNum.Text, out _) || !int.TryParse(PricePerDay.Text, out _)) {
                MessageBox.Show("Number of seats and price must be integers");
            } else
            {
                VehicleDTO newVehicle = new();
                newVehicle.Id = original.Id;
                newVehicle.Brand = Brand.Text;
                newVehicle.Model = Model.Text;
                newVehicle.Seats = int.Parse(SeatsNum.Text);
                newVehicle.PricePerDay = int.Parse(PricePerDay.Text);
                newVehicle.Type = (string)(FuelComboBox.SelectedItem) switch
                {
                    "Diesel" => FuelType.Diesel,
                    "Benzin" => FuelType.Benzin,
                    "Gas" => FuelType.Gas,
                    "Electric" => FuelType.Electric,
                    _ => FuelType.Electric // NEVER HAPPENS
                };
                newVehicle.VClass = (string)(ClassComboBox.SelectedItem) switch
                {
                    "Economy" => VehicleClass.Economy,
                    "Busuness" => VehicleClass.Business,
                    "Premium" => VehicleClass.Premium,
                    _ => VehicleClass.Premium // NEVER HAPPENS
                };
                if (createNew)
                {
                    if(!Controller.Conn.AddVehicle(newVehicle).Result)
                    {
                        MessageBox.Show("DB error, repeat action please");
                    } else
                    {
                        DialogResult = DialogResult.OK;
                    }
                } else
                {
                    if (!Controller.Conn.UpdateVehicle(newVehicle).Result)
                    {
                        MessageBox.Show("DB error, repeat action please");
                    }
                    else
                    {
                        DialogResult = DialogResult.OK;
                    }
                }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            ConfirmDialog cd = new();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                if(!Controller.Conn.DeleteVehicle(original.Id).Result)
                {
                    MessageBox.Show("Error occured");
                } else
                {
                    DialogResult = DialogResult.OK;
                }
            }
        }
    }
}
