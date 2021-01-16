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
    //Klasa przedstawiająca widok programu klienckiego administratora
    public partial class AdminClient : UserControl
    {
        public AdminClient()
        {
            InitializeComponent();
            carPanel1.Hide();
            carPanel1.showParent = panel1.Show;
            adminReservationPanel1.Hide();
            adminReservationPanel1.showParent = panel1.Show;

        }

        private void openCarPanel(object sender, EventArgs e)
        {
            carPanel1.showPanel();
            panel1.Hide();
        }

        private void openAdminReservationPanel(object sender, EventArgs e)
        {
            adminReservationPanel1.showPanel();

        }

        private void logOut(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
