using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wypozyczalniaSamochodow
{
    public partial class CarReturnPanel : UserControl
    {
        public Account account;
        private List<Reservation> reservations = new List<Reservation>();
        public CarReturnPanel()
        {
            InitializeComponent();
        }
        public void show(Account acc)
        {
            reservations.Clear();
            reservationTable.Rows.Clear();
            account = acc;
            Show();
            getReservations();
        }

        private void goBack(object sender, EventArgs e)
        {
            Hide();
        }

        private async void getReservations()
        {
            await DatabaseService.getReservationsAsync(account).ContinueWith((task) =>
            {
                reservations = task.Result;
                foreach (Reservation reservation in reservations)
                {
                    if (!reservation.ended)
                    {

                        if (reservationTable.InvokeRequired)
                            reservationTable.Invoke(new Action(() => addReservationTableRow(reservation)));
                        else
                            addReservationTableRow(reservation);
                    }

                }

            });

        }

        private void addReservationTableRow(Reservation reservation)
        {
            var index = reservationTable.Rows.Add();
            reservationTable.Rows[index].Cells["reservationId"].Value = reservation.reservationId;
            reservationTable.Rows[index].Cells["brand"].Value = reservation.brand;
            reservationTable.Rows[index].Cells["model"].Value = reservation.model;
            reservationTable.Rows[index].Cells["carNumber"].Value = reservation.registrationNumber;
            reservationTable.Rows[index].Cells["dateBegin"].Value = reservation.dateBegin;
            reservationTable.Rows[index].Cells["dateEnd"].Value = reservation.dateEnd;
        }

        private void reservationTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 6)
                {
                    returnCar(reservations[e.RowIndex]);
                }

            }
        }

        private async void returnCar(Reservation reservation)
        {
            reservation.ended = true;
            await DatabaseService.returnCar(reservation).ContinueWith((Task<Boolean> task) =>
            {
                var result = task.Result;
                MessageBox.Show((result ? "Zwrócono pojazd." : "Nie udało się zwrócić pojazdu"));
            });
        }

    }
}
