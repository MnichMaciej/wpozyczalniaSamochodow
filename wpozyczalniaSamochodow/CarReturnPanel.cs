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
    public partial class CarReturnPanel : UserControl
    {
        public Account account;
        public CarReturnPanel()
        {
            InitializeComponent();
        }
        public void show(Account acc)
        {
            account = acc;
            Show();
        }
    }
}
