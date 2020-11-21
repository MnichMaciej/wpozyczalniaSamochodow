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
    public partial class App : Form
    {
        
        private Account account;

        public App()
        {
            InitializeComponent();
           
        }

       

        private void App_Load(object sender, EventArgs e)
        {
            LoginPanel loginPanel = new LoginPanel(this);
            loginPanel.Show();


        }
        public void openClient(ref Account acc)
        {
            account = acc;
            if (account.isAdmin)
            {
                AdminClient adminClient = new AdminClient(this);
                adminClient.Show();

            }
        }


    }
}
