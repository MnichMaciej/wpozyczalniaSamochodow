using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wpozyczalniaSamochodow
{
    public partial class AdminClient : Form
    {
        public AdminClient( App app)
        {
            this.MdiParent = app;
            this.Dock = DockStyle.Fill;

            InitializeComponent(); 
        }
    }
}
