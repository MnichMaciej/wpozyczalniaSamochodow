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
    public partial class ReservationEditingPanel : UserControl
    {
        Reservation reservation;
        List<Car> cars = new List<Car>();
        public Action refreshDatabase;
        public ReservationEditingPanel()
        {
            InitializeComponent();
        }

        public void show(Reservation res)
        {
            reservation = res;
            Show();
            typeLabel.Text = Enum.GetName(typeof(CarType),reservation.carType);
            dateFromPicker.MinDate = DateTime.Today;
            dateToPicker.MinDate = DateTime.Today;
            dateToPicker.Value = dateFromPicker.Value.AddDays(1);
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            refreshDatabase();
            Hide();
        }

        private void dateFromPicker_ValueChanged(object sender, EventArgs e)
        {
            cars.Clear();
            carTable.Rows.Clear();
            reservation.dateBegin = changeDateFormat(dateFromPicker.Value.Date.ToString());
            dateToPicker.MinDate = dateFromPicker.Value.AddDays(1);
        }

        private void dateToPicker_ValueChanged(object sender, EventArgs e)
        {
            cars.Clear();
            carTable.Rows.Clear();
            reservation.dateEnd = changeDateFormat(dateToPicker.Value.Date.ToString());
            dateFromPicker.MaxDate = dateToPicker.Value.AddDays(-1);
        }

        public string changeDateFormat(string date)
        {
            return String.Join("-", date.Split(' ')[0].Split('.').Reverse());
        }

        private void addCarTableRow(Car car)
        {
            var index = carTable.Rows.Add();
            carTable.Rows[index].Cells["brand"].Value = car.brand;
            carTable.Rows[index].Cells["model"].Value = car.model;

        }

        private async void getAvailableCars(object sender, EventArgs e)
        {
            cars.Clear();
            carTable.Rows.Clear();
            if (reservation.carType != 0 && reservation.dateBegin != null && reservation.dateEnd != null)
            {
                await DatabaseService.getAvaliableCarsForEditReservation(reservation).ContinueWith((task) =>
                {
                    cars = task.Result;
                    foreach (Car car in cars)
                    {
                        if (carTable.InvokeRequired)
                            carTable.Invoke(new Action(() => addCarTableRow(car)));
                        else
                            addCarTableRow(car);
                    }
                    if (carTable.InvokeRequired)
                        carTable.Invoke(new Action(() => carTable.Show()));
                    else
                        carTable.Show();
                });
            }
            else
            {
                MessageBox.Show("Uzupełnij wszystkie pola.");
            }

        }

        private void carTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                saveReservation(cars[e.RowIndex]);
            }
        }

        private async void saveReservation(Car car)
        {
            await DatabaseService.updateReservationOnEdit(reservation, car).ContinueWith(task =>
            {
                bool result = task.Result;
                if (result)
                {
                    MessageBox.Show("Zapisano");
                    if (InvokeRequired)
                        Invoke(new Action(() => { refreshDatabase(); Hide(); }));
                    else
                        Hide();
                }
                else
                {
                    MessageBox.Show("Nie zapisano");
                }
            });
        }


    }

    
}
