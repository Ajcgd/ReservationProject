using System.Data;

namespace Rezervace
{
    public partial class VehicleDisplay : Form
    {
        private int _previousIndex;
        private bool _sortDirection = true;
        private readonly  bool _creatingReservation = false;

        List<VehicleDTO> VehicleDTOs;
        FilterDTO? fdto;
        public VehicleDisplay(FilterDTO? fdto, bool createReservation)
        {
            this.fdto = fdto;
            _creatingReservation = createReservation;
            VehicleDTOs = Controller.Conn.GetVehicles(fdto).Result;
            InitializeComponent();
            AddVehicleBttn.Visible = MainForm.IsAdmin && !createReservation;
        }

        private void DisplayVehicles(object sender, EventArgs e)
        {
            DataGridView1.DataSource = VehicleDTOs;
            DataGridView1.Columns["Brand"].HeaderText = "Brand";
            DataGridView1.Columns["Model"].HeaderText = "Model";
            DataGridView1.Columns["type"].HeaderText = "Fuel Type";
            DataGridView1.Columns["seats"].HeaderText = "Number of Seats";
            DataGridView1.Columns["PricePerDay"].HeaderText = "Price/day";
            DataGridView1.Columns["VClass"].HeaderText = "Vehicle Class";
        }

        private void GridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == _previousIndex)
            {
                _sortDirection ^= true;
            }

            DataGridView1.DataSource = SortData(
                (List<VehicleDTO>)DataGridView1.DataSource, DataGridView1.Columns[e.ColumnIndex].Name, _sortDirection);

            _previousIndex = e.ColumnIndex;
        }

        public static List<VehicleDTO> SortData(List<VehicleDTO> list, string column, bool ascending)
        {
            return ascending ?
                list.OrderBy(_ => _.GetType().GetProperty(column)!.GetValue(_)).ToList() :
                list.OrderByDescending(_ => _.GetType().GetProperty(column)!.GetValue(_)).ToList();
        }

        private void DataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (!_creatingReservation)
            {
                if (MainForm.IsAdmin)
                {
                    ModifyVehicleDialog mvd = new(VehicleDTOs[e.RowIndex], false);
                    if (mvd.ShowDialog() == DialogResult.OK)
                    {
                        VehicleDTOs = Controller.Conn.GetVehicles(null).Result;
                        DataGridView1.DataSource = VehicleDTOs;
                        DataGridView1.Update();
                        DataGridView1.Refresh();
                    }
                }

                return;
            }

            ConfirmReservationDialog crd = new(VehicleDTOs[e.RowIndex], fdto!.Value.From, fdto.Value.To);
            if (crd.ShowDialog() == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
            } else
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private void AddVehicleBttn_Click(object sender, EventArgs e)
        {
            ModifyVehicleDialog mvd = new(new VehicleDTO(), true);
            if (mvd.ShowDialog() == DialogResult.OK)
            {
                DataGridView1.DataSource = Controller.Conn.GetVehicles(null).Result;
                DataGridView1.Update();
                DataGridView1.Refresh();
            }
        }
    }
}
