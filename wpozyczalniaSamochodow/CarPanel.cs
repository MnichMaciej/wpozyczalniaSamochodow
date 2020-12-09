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

        public void showPanel()
        {
            this.Show();
            this.getCars();

        }

        private void getCars()
        {
            //cars = DatabaseService.getCars();
        }
    }
}
