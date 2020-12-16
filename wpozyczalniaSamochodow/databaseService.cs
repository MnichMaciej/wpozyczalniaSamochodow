using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
using System.Runtime.CompilerServices;
using MySqlX.XDevAPI.Common;

namespace wypozyczalniaSamochodow
{
    static class DatabaseService
    {
        private static string server = "mn16.webd.pl";
        private static string database = "tomnich_maciek";
        private static string uid= "tomnich_maciek";
        private static string password;
        private static string connectionString;
        private static MySqlConnection connection = new MySqlConnection(connectionString) ;
        public static Account account = null;


        public static bool openConnection()
        {
            ShowDialog("Podaj haslo do bazy danych","123");
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
                        MessageBox.Show("Jakiś error:"+ ex.Message.ToString());
                        break;
                }
                return false;
            }
        }

        public static Account logIn(string emailValue, string passwordValue)
        {
            if (connection.State != ConnectionState.Open)
                openConnection();
            if (connection.State == ConnectionState.Open)
            {


                var selectQuery = "SELECT id, firstName,lastName,email,isAdmin FROM wypozyczalniaUzytkownicy WHERE email='" + emailValue + "' AND password = '" + passwordValue + "';";
                var result = new MySqlCommand(selectQuery, connection);
                MySqlDataReader resultReader = result.ExecuteReader();

                if (!resultReader.Read())
                    MessageBox.Show("Złe haslo lub login");
                else
                {
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


            return account;
        }


        public static async Task<List<Car>> getCarsAsync()
        {
            return await Task.Run(() =>
             {
                 List<Car> cars = new List<Car>();
                 if (connection.State != ConnectionState.Open)
                     openConnection();
                 if (connection.State == ConnectionState.Open)
                 {
                     var selectQuery = "SELECT * FROM wypozyczalniaSamochody;";
                     var result = new MySqlCommand(selectQuery, connection);
                     MySqlDataReader resultReader = result.ExecuteReader();
                     while (resultReader.Read())
                     {
                         Car tempCar = new Car();
                         List<string> results = new List<string>();
                         for(int i=0;i<resultReader.FieldCount;i++)
                         {
                             results.Add(resultReader[i].ToString());
                         }

                         tempCar.carId = Int32.Parse(results[0]);
                         tempCar.brand = results[1];
                         tempCar.model = results[2];
                         tempCar.type = (CarType)Int32.Parse(results[3]);
                         tempCar.vehicleOdometer = Int32.Parse(results[4]);
                         tempCar.registrationNumber = results[5];
                         tempCar.carEfficiency = Convert.ToBoolean(results[6]);
                         tempCar.isDisabled = Convert.ToBoolean(results[7]);
                         tempCar.imageUrl = results[8];
                         cars.Add(tempCar);
                     }
                     resultReader.Close();
                     result.Cancel();
                 }
                 return cars;
             });
        }

        public static async Task<bool> makeQuery(string query)
        {
            return await Task.Run(() =>
            {
                bool resultFlag = false;
                if (connection.State != ConnectionState.Open)
                    openConnection();
                if (connection.State == ConnectionState.Open)
                {
                    var result = new MySqlCommand(query, connection);
                    MySqlDataReader resultReader = result.ExecuteReader();
                    if (resultReader.Read()) resultFlag = true;
                    resultReader.Close();
                    result.Cancel();

                }
                return resultFlag;
            });
        }

        private static void ShowDialog(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 500,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            password = prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
            connectionString  = "Server=" + server + ";" + " Uid=" + uid + ";" + " Pwd=" + password + ";" + " Database=" +
            database + ";";
            connection.ConnectionString = connectionString;
        }





    }
}
