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
    public partial class ConfirmReservationDialog : Form
    {
        ReservationDTO reservationDTO = new();
        public ConfirmReservationDialog(VehicleDTO vehicle, DateTime from, DateTime to)
        {
            InitializeComponent();
            CarName.Text = vehicle.Brand + " " + vehicle.Model;
            StartDate.Text = DateOnly.FromDateTime(from).ToString();
            EndDate.Text = DateOnly.FromDateTime(to).ToString();
            Price.Text = (vehicle.PricePerDay * ((to - from).Days + 1)).ToString();
            reservationDTO.VehicleId = vehicle.Id;
            reservationDTO.ToDate = to;
            reservationDTO.FromDate = from;
        }

        private void OkBttn_Click(object sender, EventArgs e)
        {
            if (Controller.Conn.CreateReservation(reservationDTO).Result)
            {
                DialogResult = DialogResult.OK;
            }
        }
    }
}
