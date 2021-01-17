using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wypozyczalniaSamochodow
{
    public partial class ReservationPanel : UserControl
    {
        private Account account; 
        private List<Reservation> reservations = new List<Reservation>();
        public ReservationPanel()
        {
            InitializeComponent();
            reservationEditingPanel1.Hide();
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
                if(e.ColumnIndex == 5)
                {
                    editReservation(reservations[e.RowIndex]);
                }
                else if (e.ColumnIndex == 6)
                {
                    cancelReservation(reservations[e.RowIndex]);
                }
            }
        }

        private void editReservation(Reservation reservation)
        {
            reservationEditingPanel1.show(reservation);
        }

        private async void cancelReservation(Reservation reservation)
        {

            if(DateTime.Compare(DateTime.ParseExact(reservation.dateBegin, "dd.MM.yyyy HH:mm:ss", null).AddDays(3) ,DateTime.Now) > 0)
            {
                if (MessageBox.Show("Kosz anulowania rezerwacji wynosi: 30zł. Chcesz anulować rezerwacje?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Fine fine = new Fine();
                    fine.fineCost = 30;
                    fine.fineDescription = "Anulowanie rezerwacji, krócej niż 3 dni przed jej terminem.";
                    await DatabaseService.insertFine(fine).ContinueWith(async (Task<long> task) =>
                    {
                        var id = task.Result;
                        reservation.ended = true;
                        reservation.fineId = (int)id;
                        return await DatabaseService.updateReservation(reservation);
                    });
                }
 
            }
            else
            {
                if (MessageBox.Show("Na pewno chcesz anulować rezerwacje?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    reservation.ended = true;
                    await DatabaseService.updateReservation(reservation);
                }

            }
        }
    }
}
