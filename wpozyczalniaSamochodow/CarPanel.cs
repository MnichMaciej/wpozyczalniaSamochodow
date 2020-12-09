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
            //DatabaseService.getCars.Start();
            await DatabaseService.getCarsAsync().ContinueWith((task) =>
            {
                cars = task.Result;
                Console.WriteLine("\n\n" + cars.ToString() + "\n\n");
            });

        }
    }
}
