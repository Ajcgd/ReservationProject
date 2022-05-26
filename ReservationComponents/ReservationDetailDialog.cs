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
    public partial class ReservationDetailDialog : Form
    {
        public ReservationDetailDialog(ReservationDetailsDTO rd)
        {
            InitializeComponent();
            CarName.Text = rd.Brand + " " + rd.Model;
            StartDate.Text = DateOnly.FromDateTime(rd.FromDate).ToString();
            EndDate.Text = DateOnly.FromDateTime(rd.ToDate).ToString();
            Price.Text = (rd.PricePerDay * ((rd.ToDate - rd.FromDate).Days + 1)).ToString();
        }

        private void DeleteBttn_Click(object sender, EventArgs e)
        {
            ConfirmDialog cd = new();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                DialogResult = DialogResult.OK;
            }
        }
    }
}
