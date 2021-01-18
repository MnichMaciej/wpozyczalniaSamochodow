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
        //pole 'showParent' zostało dodane ze względu na wymagania frameworka Windows.Forms
        //pole przechowuje metodę panelu nadrzędnego
        public Action showParent;
        public CarAddingPanel()
        {
            InitializeComponent();
            Hide();
            foreach (var item in Enum.GetValues(typeof(CarType)))
            {
                typeComboBox.Items.Add(item);
            }
        }

        public bool checkCorectness(string brand, string model, int type, decimal odometer, string registrationNumber, bool efficiency, bool isDisabled)
        {
            if (brand == "")
            {
                brandTextBox.BackColor = Color.Red;
                MessageBox.Show("Brak nazwy marki!");
                return false;
            }

            if (brand.Any(char.IsDigit))
            {
                brandTextBox.BackColor = Color.Red;
                MessageBox.Show("Nazwa marki nie moze zawierac cyfr!");
                return false;
            }

            if (model == "")
            {
                modelTextBox.BackColor = Color.Red;
                MessageBox.Show("Brak nazwy modelu!");
                return false;
            }

            if (type == 0)
            {
                typeComboBox.BackColor = Color.Red;
                MessageBox.Show("Typ nie moze byc pusty!");
                return false;
            }

            if (odometer == 0)
            {
                odometerTextBox.BackColor = Color.Red;
                MessageBox.Show("Przebieg nie moze byc pusty!");
                return false;
            }

            if (registrationNumber == "") 
            {
                registrationNumberTextBox.BackColor = Color.Red;
                MessageBox.Show("Brak numerow tablicy rejestracyjnej!");
                return false;
            }

            if (registrationNumber.Length < 6)
            {
                registrationNumberTextBox.BackColor = Color.Red;
                MessageBox.Show("Zbyt krotki numer rejestracyjny!");
                return false;
            }

            if (registrationNumber.Length > 9)
            {
                registrationNumberTextBox.BackColor = Color.Red;
                MessageBox.Show("Zbyt dlugi numer rejestracyjny!");
                return false;
            }

            if (efficiency == true && isDisabled == true)
            {
                efficiencyCheckBox.BackColor = Color.Red;
                isDisabledCheckBox.BackColor = Color.Red;
                MessageBox.Show("Auto nie moze byc jednoczesnie dostepne i niesprawne!");
                return false;
            }

            if (efficiency == false && isDisabled == false)
            {
                efficiencyCheckBox.BackColor = Color.Red;
                isDisabledCheckBox.BackColor = Color.Red;
                MessageBox.Show("Brak zaznaczenia stanu samochodu!");
                return false;
            }

            return true;
        }

        private async void save(object sender, EventArgs e)
        {
            var brand = brandTextBox.Text;
            var model = modelTextBox.Text;
            var type = 0;
            if(typeComboBox.Text != "")
            {
                type = (int)((CarType)Enum.Parse(typeof(CarType), typeComboBox.SelectedItem.ToString()));
            }
            var odometer = odometerTextBox.Value;
            var registrationNumber = registrationNumberTextBox.Text;
            var efficiency = efficiencyCheckBox.Checked;
            var isDisabled = isDisabledCheckBox.Checked;
            var imageUrl = imageUrlTextBox.Text;

            if(checkCorectness(brand, model, type, odometer, registrationNumber, efficiency, isDisabled))
            {
                await DatabaseService.insertCar(brand, model, type, odometer, registrationNumber, efficiency ? 1 : 0, isDisabled ? 1 : 0, imageUrl).ContinueWith(task =>
                {
                    bool result = task.Result;
                    if (result)
                    {
                        MessageBox.Show("Samochod zostal zapisany w bazie danych");
                        if (InvokeRequired)
                            Invoke(new Action(() => showParent()));
                        else
                            showParent();
                    }
                    else
                    {
                        MessageBox.Show("Samochod o tej rejestracji juz istnieje w bazie danych!");
                    }
                });
            }
        }

        //metody dodane ze względu na wymagania frameworka Windows.Forms
        //dokonują graficznych zmian w okienku
        private void brandTextBox_Click(object sender, EventArgs e)
        {
            brandTextBox.BackColor = Color.White;
        }

        private void modelTextBox_Click(object sender, EventArgs e)
        {
            modelTextBox.BackColor = Color.White;
        }

        private void typeComboBox_Click(object sender, EventArgs e)
        {
            typeComboBox.BackColor = Color.White;
        }

        private void odometerTextBox_Click(object sender, EventArgs e)
        {
            odometerTextBox.BackColor = Color.White;
        }

        private void registrationNumberTextBox_Click(object sender, EventArgs e)
        {
            registrationNumberTextBox.BackColor = Color.White;
        }

        private void efficiencyCheckBox_Click(object sender, EventArgs e)
        {
            efficiencyCheckBox.BackColor = Color.White;
        }

        private void isDisabledCheckBox_Click(object sender, EventArgs e)
        {
            isDisabledCheckBox.BackColor = Color.White;
        }
    }
}
