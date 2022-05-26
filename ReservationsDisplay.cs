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
    public partial class ReservationsDisplay : Form
    {
        readonly List<ReservationDetailsDTO> ReservationDTOs;
        private ReservationsDisplay(List<ReservationDetailsDTO> ReservationDTOs)
        {
            this.ReservationDTOs = ReservationDTOs;
            InitializeComponent();
            DataGridView1.DataSource = ReservationDTOs;
        }

        public static ReservationsDisplay? GetInstance()
        {
            List<ReservationDetailsDTO>? ReservationDTOs;
            if ((ReservationDTOs = Controller.Conn.ListReservations(MainForm.Username, false).Result) != null)
            {
                return new ReservationsDisplay(ReservationDTOs);
            } else
            {
                return null;

            }
        }

        private void DisplayReservations(object sender, EventArgs e)
        {
            DataGridView1.DataSource = ReservationDTOs;
            DataGridView1.Columns["Brand"].HeaderText = "Brand";
            DataGridView1.Columns["Model"].HeaderText = "Model";
            DataGridView1.Columns["type"].HeaderText = "Fuel Type";
            DataGridView1.Columns["fromDate"].HeaderText = "From";
            DataGridView1.Columns["toDate"].HeaderText = "To";
        }

        private void DataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ReservationDetailDialog rdd = new(ReservationDTOs[e.RowIndex]);
            if (rdd.ShowDialog() == DialogResult.OK)
            {
                if (Controller.Conn.DeleteReservation(ReservationDTOs[e.RowIndex].Id).Result)
                {
                    List<ReservationDetailsDTO>? newReservationDTOs = Controller.Conn.ListReservations(MainForm.Username, false).Result;
                    if (newReservationDTOs != null)
                    {
                        DataGridView1.DataSource=newReservationDTOs;
                        DataGridView1.Update();
                        DataGridView1.Refresh();
                    } else
                    {
                        MessageBox.Show("DB error");
                    }

                } else
                {
                    MessageBox.Show("Error occured, please, repeat action");
                }
                
            }
        }
    }
}
