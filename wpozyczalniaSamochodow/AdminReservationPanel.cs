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
    // Klasa przedstawiająca panel rezerwacji administratora
    public partial class AdminReservationPanel : UserControl
    {
        private List<Reservation> reservations = new List<Reservation>();
        // Pole 'showParent' zostało dodane ze względu na wymagania frameworka Windows.Forms
        // Pole przechowuje metodę panelu nadrzędnego
        public Action showParent;
        public AdminReservationPanel()
        {
            InitializeComponent();
            carConditionPanel1.showParent = ()=>goBack(null, null);
        }

        public async void showPanel()
        {
            reservations.Clear();
            reservationTable.Rows.Clear();
            this.Show();
            await this.getReservations();

        }

        private async void goBack(object sender, EventArgs e)
        {
            if (carConditionPanel1.Visible)
            {
                reservations.Clear();
                reservationTable.Rows.Clear();
                await getReservations();
                carConditionPanel1.Hide();
                carConditionPanel1.SendToBack();
            }
            else
            {
                this.Hide();
                this.showParent();
            }
        }

        private async Task getReservations()
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
        // Metoda 'addReservationTableRow' została dodana ze względu na wymagania frameworka Windows.Forms
        // Wypełnienia tabeli danymi
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
            reservationTable.Rows[index].Cells["_checked"].Value = reservation._checked;



        }

        // Metoda 'reservationTable_CellContentClick' została dodana ze względu na wymagania frameworka Windows.Forms
        // Jest uruchamiana gdy użytkownik wciśnie przycisk znajdujący się w danym wierszu w tabeli
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
            if (reservation.ended && !reservation._checked)
                carConditionPanel1.Show(reservation);
            else MessageBox.Show("Rezerwacja nie jest zakończona lub została już oceniona.");
        }
    }
}
