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

        private void save(object sender, EventArgs e)
        {
            var brand = brandTextbox.Text;
            var model = modelTextbox.Text;
            var type = typeCombobox.SelectedItem;
            var odometer = odometerTextbox.Value;
            var registrationNumber = registrationNumberTextbox.Text;
            var efficiency = efficiencyCheckbox.Checked;
            var isDisabled = isDisabledCheckbox.Checked;
            var imageUrl = imageUrlTextBox.Text;

            if(brand.Length > 1 && model.Length >= 1 && registrationNumber.Length > 3 && imageUrl.Length > 2)
            {
                MessageBox.Show(type.ToString());
            }
            else
            {
                //TODO: error że mają być wszystkie wypelnione
            }
        }
    }
}
