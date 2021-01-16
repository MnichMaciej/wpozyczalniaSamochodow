using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace wypozyczalniaSamochodow
{
    public partial class LoginPanel : UserControl
    {
        
        private Account account;
        public App parent;

        public LoginPanel()
        {
            InitializeComponent();

        
        }
       
        public void setParent(App parent)
        {
            this.parent = parent;
        }

        private void logInButtonClick(object sender, EventArgs e)
        {
            Account acc = DatabaseService.logIn(loginInput.Text, passwordInput.Text);
            if(acc != null)
            {
                account = acc;
                parent.openClient(ref account);
                this.Hide();
            }
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            parent.openRegistrationPanel();
        }
    }
}
