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
    public partial class CarEditingPanel : UserControl
    {
        private Car car;
        public CarEditingPanel()
        {
            InitializeComponent();
            Hide();
            foreach (var item in Enum.GetValues(typeof(CarType)))
            {
                typeCombobox.Items.Add(item);
            }
        }

        public void Show(Car car)
        {
            this.car = car;
            idNumberLabel.Text = car.carId.ToString();
            brandTextbox.Text = car.brand;
            modelTextbox.Text = car.model;
            typeCombobox.SelectedIndex = (int)Enum.Parse(typeof(CarType), car.type.ToString())-1;
            odometerTextbox.Value = car.vehicleOdometer;
            registrationNumberTextbox.Text = car.registrationNumber;
            efficiencyCheckbox.Checked = car.carEfficiency;
            isDisabledCheckbox.Checked = car.isDisabled;
            imageUrlTextBox.Text = car.imageUrl;
            Show();
        }

        private async void save(object sender, EventArgs e)
        {
            bool change = false;
            string parameters = "";
            if (brandTextbox.Text != car.brand)
            {
                change = true;
                car.brand = brandTextbox.Text;
                parameters += "brand='" + car.brand + "'";
            }
            if (modelTextbox.Text != car.model)
            {
                if (change) parameters += " , ";
                car.model = modelTextbox.Text;
                parameters += "model='" + car.model + "'";
                change = true;
            }
            if ((CarType)typeCombobox.SelectedItem != car.type)
            {
                if (change) parameters += " , ";
                car.type = (CarType)typeCombobox.SelectedItem;
                parameters += "type='" + (int)car.type + "'";
                change = true;
            }
            if (odometerTextbox.Value != car.vehicleOdometer)
            {
                if (change) parameters += " , ";
                car.vehicleOdometer = (int)odometerTextbox.Value;
                parameters += "odometer='" + car.vehicleOdometer + "'";
                change = true;
            }
            if (registrationNumberTextbox.Text != car.registrationNumber)
            {
                if (change) parameters += " , ";
                car.registrationNumber = registrationNumberTextbox.Text;
                parameters += "registrationNumber='" + car.registrationNumber + "'";
                change = true;
            }
            if (efficiencyCheckbox.Checked != car.carEfficiency)
            {
                if (change) parameters += " , ";
                car.carEfficiency = efficiencyCheckbox.Checked;
                parameters += "efficiency=" + car.carEfficiency;
                change = true;
            }
            if (isDisabledCheckbox.Checked != car.isDisabled)
            {
                if (change) parameters += " , ";
                car.isDisabled = isDisabledCheckbox.Checked;
                parameters += "isDisabled=" + car.isDisabled ;
                change = true;
            }
            if (imageUrlTextBox.Text != car.imageUrl)
            {
                if (change) parameters += " , ";
                car.imageUrl = imageUrlTextBox.Text;
                parameters += "imageUrl='" + car.imageUrl + "'";
                change = true;
            }

            if (change)
            {
                string query = "UPDATE wypozyczalniaSamochody SET " + parameters + " WHERE id =" + car.carId;
                await DatabaseService.makeQuery(query).ContinueWith(task=> {
                    bool result = task.Result;
                    if(result){
                        //TODO: powrot
                    }
                    else
                    {
                        //TODO: error
                    }


                });
            }

        }
    }
}
