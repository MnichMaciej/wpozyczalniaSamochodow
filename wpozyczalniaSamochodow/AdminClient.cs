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
    public partial class AdminClient : UserControl
    {
        public AdminClient()
        {
            InitializeComponent();
            this.carPanel1.Hide();
            this.carPanel1.showParent = this.panel1.Show;
        }

        private void openCarPanel(object sender, EventArgs e)
        {
            this.carPanel1.showPanel();
            this.panel1.Hide();
        }
    }
}
