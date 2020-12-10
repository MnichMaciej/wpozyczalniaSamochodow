using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace wpozyczalniaSamochodow
{
    public partial class CarPanel : UserControl
    {
        private List<Car> cars;
        public Action showParent;
        public CarPanel()
        {
            InitializeComponent();
        }

        private void goBack(object sender, EventArgs e)
        {
            this.Hide();
            this.showParent();
        }

        public async void showPanel()
        {
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
            carEditingPanel1.Show(car);
        }
    }
}
