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
    public partial class CarRentalPanel : UserControl
    {
        Account account;
        ReservationData reservation;
        List<Car> cars;
        public CarRentalPanel()
        {
            InitializeComponent();
            foreach (var item in Enum.GetValues(typeof(CarType)))
            {
                typeCombobox.Items.Add(item);
            }
            carTable.Hide();
            dateFromPicker.MinDate = DateTime.Today;
            dateToPicker.MinDate = DateTime.Today.AddDays(1);

        }
        public void show(Account acc)
        {
            account = acc;
            reservation = new ReservationData();
            Show();
        }

        private void setDateBegin(object sender, EventArgs e)
        {
            reservation.dateBegin = changeDateFormat(dateFromPicker.Value.Date.ToString());
            dateToPicker.MinDate = dateFromPicker.Value.AddDays(1);
        }

        private void setDateEnd(object sender, EventArgs e)
        {
            reservation.dateEnd = changeDateFormat(dateToPicker.Value.Date.ToString());
            dateFromPicker.MaxDate = dateToPicker.Value.AddDays(-1);
        }

        public string changeDateFormat(string date)
        {
            return String.Join("-", date.Split(' ')[0].Split('.').Reverse());
        }

        private void setCarType(object sender, EventArgs e)
        {
            reservation.carType = (CarType)Enum.Parse(typeof(CarType), typeCombobox.SelectedItem.ToString());
        }

        private async void getAvaliableCars(object sender, EventArgs e)
        {
            if(reservation.carType != 0 && reservation.dateBegin!=null && reservation.dateEnd != null)
            {
                await DatabaseService.getAvaliableCars(reservation).ContinueWith((task) =>
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
        private void addCarTableRow(Car car)
        {
            var index = carTable.Rows.Add();
            carTable.Rows[index].Cells["brand"].Value = car.brand;
            carTable.Rows[index].Cells["model"].Value = car.model;
            
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
            await DatabaseService.insertReservation(reservation, car, account.id).ContinueWith(task =>
            {
                bool result = task.Result;
                if (result)
                {
                    //TODO: powrot
                    MessageBox.Show("Zapisano");
                    if (InvokeRequired)
                        Invoke(new Action(() =>Hide()));
                    else
                       Hide();
                }
                else
                {
                    MessageBox.Show("Nie zapisano");
                    //TODO: error
                }
            });
        }

        private void goBack(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
