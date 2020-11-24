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

namespace wpozyczalniaSamochodow
{
    public partial class LoginPanel : UserControl
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        private string connectionString;
        private bool isLogged = false;
        private Account account;
        public App parent;

        public LoginPanel()
        {
            InitializeComponent();

            server = "mn16.webd.pl";
            database = "tomnich_maciek";
            uid = "tomnich_maciek";
            password = "Hesoyam";

            connectionString = "Server=" + server + ";" + "Uid=" + uid + ";" + "Pwd=" + password + ";" + "Database=" +
            database + ";";
            connection = new MySqlConnection(connectionString);
        }
       
        public void setParent(App parent)
        {
            this.parent = parent;
        }

        private bool OpenConnection()
        {
            try
            {

                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {

                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                    default:
                        MessageBox.Show("Jakiś error:", ex.Message);
                        break;
                }
                return false;
            }
        }
        private void logInButtonClick(object sender, EventArgs e)
        {
            if (connection.State != ConnectionState.Open)
                OpenConnection();
            if (connection.State == ConnectionState.Open)
            {


                var selectQuery = "SELECT id, firstName,lastName,email,isAdmin FROM wypozyczalniaUzytkownicy WHERE email='" + loginInput.Text + "' AND password = '" + passwordInput.Text + "';";
                var result = new MySqlCommand(selectQuery, connection);
                MySqlDataReader resultReader = result.ExecuteReader();

                if (!resultReader.Read())
                    MessageBox.Show("Złe haslo lub login");
                else
                {
                    isLogged = true;
                    var accountData = new string[5];
                    for (int i = 0; i < resultReader.FieldCount; i++)
                    {
                        accountData[i] = (resultReader[i].ToString());
                    }
                    int id = Int32.Parse(accountData[0]);
                    string fName = accountData[1];
                    string lName = accountData[2];
                    string email = accountData[3];
                    bool isAdmin = Convert.ToBoolean(accountData[4]);
                    account = new Account(id, fName, lName, email, isAdmin);
                }
                resultReader.Close();
                result.Cancel();
            }

            if (isLogged)
            {
                parent.openClient(ref account);
                this.Hide();
            }
        }
    }
}
