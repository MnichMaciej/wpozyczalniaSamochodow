using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wypozyczalniaSamochodow;

namespace wypozyczalniaSamochodow
{
    public partial class AdminReservationPanel : UserControl
    {
        private List<Reservation> reservations;
        public Action showParent;
        public AdminReservationPanel()
        {
            InitializeComponent();

        }

        public async void showPanel()
        {
            this.Show();
            await this.getReservationsAsync();

        }

        private void goBack(object sender, EventArgs e)
        {
            if (carConditionPanel1.Visible)
            {
                carConditionPanel1.Hide();
                carConditionPanel1.SendToBack();
            }
            else
            {
                this.Hide();
                this.showParent();
            }
        }

        private async Task getReservationsAsync()
        {
            await DatabaseService.getReservationsAsync(null).ContinueWith((task) =>
            {
                reservations = task.Result;
                foreach (Reservation reservation in reservations)
                {
                    if (reservationTable.InvokeRequired)
                        reservationTable.Invoke(new Action(() => addReservationTableRow(reservation)));
                    else
                        addReservationTableRow(reservation);

                }

            });

        }

        private void addReservationTableRow(Reservation reservation)
        {
            var index = reservationTable.Rows.Add();
            reservationTable.Rows[index].Cells["reservationId"].Value = reservation.reservationId;
            reservationTable.Rows[index].Cells["brand"].Value = reservation.brand;
            reservationTable.Rows[index].Cells["model"].Value = reservation.model;
            reservationTable.Rows[index].Cells["type"].Value = reservation.carType;
            reservationTable.Rows[index].Cells["carNumber"].Value = reservation.registrationNumber;
            reservationTable.Rows[index].Cells["dateBegin"].Value = reservation.dateBegin;
            reservationTable.Rows[index].Cells["dateEnd"].Value = reservation.dateEnd;
            reservationTable.Rows[index].Cells["ended"].Value = reservation.ended;
            reservationTable.Rows[index].Cells["fine"].Value = reservation.fineId;
        }

        private void reservationTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                checkCarConditon(reservations[e.RowIndex]);
            }
        }

        private void checkCarConditon(Reservation reservation)
        {
            carConditionPanel1.Show(reservation);
        }
    }
}
