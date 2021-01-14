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
    public partial class CarPanel : UserControl
    {
        private List<Car> cars = new List<Car>();
        public Action showParent;
        public CarPanel()
        {
            InitializeComponent();
        }

        private void goBack(object sender, EventArgs e)
        {
            if (carEditingPanel1.Visible)
            {
                carEditingPanel1.Hide();
                addingCarButton.Enabled = true;
                BringToFront();

            }
            else if (carAddingPanel1.Visible)
            {
                carAddingPanel1.Hide();
                BringToFront();
                addingCarButton.Enabled = true;
                cars.Clear();
                carsTable.Rows.Clear();
                this.getCarsAsync();
            }
            else
            {
                this.Hide();
                this.showParent();
            }
        }

        public async void showPanel()
        {
            cars.Clear();
            carsTable.Rows.Clear();
            this.Show();
            await this.getCarsAsync();

        }

        private async Task getCarsAsync()
        {
            await DatabaseService.getCarsAsync().ContinueWith((task) =>
            {
                cars = task.Result;
                foreach(Car car in cars)
                {
                    if(carsTable.InvokeRequired)
                        carsTable.Invoke(new Action(() =>  addCarTableRow(car) ));
                    else
                        addCarTableRow(car);

                }

            });
 
        }

        private void addCarTableRow(Car car)
        {
            var index = carsTable.Rows.Add();
            carsTable.Rows[index].Cells["id"].Value = car.carId;
            carsTable.Rows[index].Cells["brand"].Value = car.brand;
            carsTable.Rows[index].Cells["model"].Value = car.model;
            carsTable.Rows[index].Cells["type"].Value = car.type;
            carsTable.Rows[index].Cells["odometer"].Value = car.vehicleOdometer;
            carsTable.Rows[index].Cells["registrationNumber"].Value = car.registrationNumber;
            carsTable.Rows[index].Cells["efficiency"].Value = car.carEfficiency;
            carsTable.Rows[index].Cells["isDisabled"].Value = car.isDisabled;
        }

        private void carsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                editCar(cars[e.RowIndex]);    
            }
        }

        private void editCar(Car car)
        {
            carEditingPanel1.BringToFront();
            carEditingPanel1.Show(car);
            addingCarButton.Enabled = false;
        }

        private void addCar(object sender, EventArgs e)
        {
            carAddingPanel1.BringToFront();
            carAddingPanel1.Show();
            addingCarButton.Enabled = false;

        }
    }
}
