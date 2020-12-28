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
    public partial class CarAddingPanel : UserControl
    {
        public CarAddingPanel()
        {
            InitializeComponent();
            Hide();
            foreach (var item in Enum.GetValues(typeof(CarType)))
            {
                typeCombobox.Items.Add(item);
            }
        }

        private async void save(object sender, EventArgs e)
        {
            var brand = brandTextbox.Text;
            var model = modelTextbox.Text;
            var type =  (int)((CarType)Enum.Parse(typeof(CarType), typeCombobox.SelectedItem.ToString()));
            var odometer = odometerTextbox.Value;
            var registrationNumber = registrationNumberTextbox.Text;
            var efficiency = efficiencyCheckbox.Checked;
            var isDisabled = isDisabledCheckbox.Checked;
            var imageUrl = imageUrlTextBox.Text;

            if(brand.Length > 1 && model.Length >= 1 && registrationNumber.Length > 3 && imageUrl.Length > 2)
            {
                await DatabaseService.insertCar(brand, model, type, odometer, registrationNumber, efficiency ? 1 : 0, isDisabled ? 1 : 0, imageUrl).ContinueWith(task =>
                {
                    bool result = task.Result;
                    if (result)
                    {
                        //TODO: powrot
                        MessageBox.Show("Zapisano");
                    }
                    else
                    {
                        MessageBox.Show("Nie zapisano");
                        //TODO: error
                    }
                });
            }
            else
            {
                MessageBox.Show("Blad");
                //TODO: error że mają być wszystkie wypelnione
            }
        }
    }
}
