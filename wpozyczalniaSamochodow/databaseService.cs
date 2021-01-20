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
using wypozyczalniaSamochodow;
using System.Security.Cryptography;

namespace wypozyczalniaSamochodow
{
    // Klasa 'DatabaseService' służy do obsługi połączenia z bazą danych
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
            if(string.IsNullOrEmpty(password)) ShowDialog("Podaj hasło do bazy danych","Połączenie");
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                password = null;
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
                connection.Close();
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
                     connection.Close();

                 }
                 return cars;
             });
        }

        public static async Task<bool> insertCar(string brand,string model,int type,decimal odometer,string registrationNumber,int efficiency,int isDisabled,string imageUrl)
        {
            return await Task.Run(() =>
            {
                bool resultFlag = false;
                if (connection.State != ConnectionState.Open)
                    openConnection();
                if (connection.State == ConnectionState.Open)
                {

                    var insertQuery = "INSERT INTO wypozyczalniaSamochody(brand, model, type, odometer, registrationNumber, efficiency, isDisabled, imageUrl) VALUES ('"+brand+"','"+model+"','"+type+"','"+odometer+"','"+registrationNumber+"','"+efficiency+"','"+isDisabled+"','"+imageUrl+"');";
                    var result = new MySqlCommand(insertQuery, connection);
                    try
                    {
                        MySqlDataReader resultReader = result.ExecuteReader();
                        resultFlag = true;
                        resultReader.Close();
                    }
                    catch
                    {
                        resultFlag = false;
                    }
                    result.Cancel();
                    connection.Close();

                }

                return resultFlag;
            });
        }

        public static async Task<bool> insertUser(Account user)
        {
            return await Task.Run(() =>
            {
                bool resultFlag = false;
                if (connection.State != ConnectionState.Open)
                    openConnection();
                if (connection.State == ConnectionState.Open)
                {


                    var insertQuery = "INSERT INTO wypozyczalniaUzytkownicy(firstName,lastName,city,address,houseNumber,apartmentNumber,email,password) VALUES ('" + user.firstName + "','" + user.lastName + "','" + user.city + "','" + user.address + "','" + user.houseNumber + "','" + user.apartmentNumber + "','" + user.email + "','" + user.password + "');";
                    var result = new MySqlCommand(insertQuery, connection);
                    try
                    {
                        MySqlDataReader resultReader = result.ExecuteReader();
                        resultFlag = true;
                        resultReader.Close();
                    }
                    catch
                    {
                        resultFlag = false;
                    }
                    result.Cancel();
                    connection.Close();

                }

                return resultFlag;
            });
        }

        public static async Task<List<Reservation>> getReservationsAsync(Account acc)
        {
            return await Task.Run(() =>
            {
                List<Reservation> reservations = new List<Reservation>();
                if (connection.State != ConnectionState.Open)
                    openConnection();
                if (connection.State == ConnectionState.Open)
                {
                    var selectQuery = "SELECT r.reservationId, s.brand,s.model,s.type,r.dateBegin,r.dateEnd,s.registrationNumber,r.ended, r.fineId, r.checked FROM `wypozyczalniaRezerwacje` r INNER JOIN `wypozyczalniaSamochody` s ON r.carId = s.id";
                    if(!(acc is null))
                    {
                        selectQuery += $" WHERE r.accountId = {acc.id} AND r.ended = 0";
                    }
                    selectQuery += ";";
                    var result = new MySqlCommand(selectQuery, connection);
                    MySqlDataReader resultReader = result.ExecuteReader();
                    while (resultReader.Read())
                    {
                        Reservation tempReservation = new Reservation();
                        List<string> results = new List<string>();
                        for (int i = 0; i < resultReader.FieldCount; i++)
                        {
                            results.Add(resultReader[i].ToString());
                        }

                        tempReservation.reservationId = Int32.Parse(results[0]);
                        tempReservation.brand = results[1];
                        tempReservation.model = results[2];
                        tempReservation.carType = (CarType)Int32.Parse(results[3]);
                        tempReservation.dateBegin = results[4];
                        tempReservation.dateEnd = results[5];
                        tempReservation.registrationNumber = results[6];
                        tempReservation.ended = Convert.ToBoolean(results[7]);
                        tempReservation.fineId = results[8] == "" ? -1 : Int32.Parse(results[8]);
                        tempReservation._checked = Convert.ToBoolean(results[9]);
                        reservations.Add(tempReservation);

                    }
                    resultReader.Close();
                    result.Cancel();
                    connection.Close();

                }
                return reservations;
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
                    //if (resultReader.Read()) resultFlag = true;
                    resultReader.Close();
                    result.Cancel();
                    connection.Close();
                    resultFlag = true;

                }
                return resultFlag;
            });
        }

        public static async Task<long> insertFine(Fine fine, Reservation reservation = null)
        {
            return await Task.Run(() =>
            {
                if (!(reservation is null) && reservation.fineId > 0)
                {
                    return getFine(reservation.fineId).ContinueWith(task =>
                    {
                        Fine fine2 = task.Result;
                        fine.fineCost += fine2.fineCost;
                        fine.fineDescription += '\n' + fine2.fineDescription;
                        if (connection.State != ConnectionState.Open)
                            openConnection();
                        if (connection.State == ConnectionState.Open)
                        {
                            string query = "UPDATE wypozyczalniaOplaty SET cost = '" + fine.fineCost + "', description = '" + fine.fineDescription + "' WHERE id = " + reservation.fineId + ";";
                            var insertCommand = new MySqlCommand(query, connection);
                            insertCommand.ExecuteNonQuery();
                            insertCommand.Dispose();
                            connection.Close();

                            return reservation.fineId;
                        }
                        return -1;
                    }).Result;

                }
                else
                {
                    if (connection.State != ConnectionState.Open)
                        openConnection();
                    if (connection.State == ConnectionState.Open)
                    {
                        string query = "INSERT INTO wypozyczalniaOplaty(cost, description) VALUES('" + fine.fineCost + "','" + fine.fineDescription + "');";
                        var insertCommand = new MySqlCommand(query, connection);
                        insertCommand.ExecuteNonQuery();
                        insertCommand.Dispose();
                        connection.Close();

                        return insertCommand.LastInsertedId;
                    }
                    return -1;
                }
            });
        }

        public static async Task<bool> updateReservation(Reservation reservation)
        {
            return await Task.Run(() =>
            {
                if (connection.State != ConnectionState.Open)
                    openConnection();
                if (connection.State == ConnectionState.Open)
                {
                    string query = $"UPDATE wypozyczalniaRezerwacje SET ended='{(reservation.ended ? 1 : 0 )}',fineId='{(reservation.fineId == -1 ? "null" : reservation.fineId.ToString())}', checked='{(reservation._checked ? 1 : 0)}' WHERE reservationId='{reservation.reservationId}'";
                    var insertCommand = new MySqlCommand(query, connection);
                    insertCommand.ExecuteNonQuery();
                    insertCommand.Dispose();
                    connection.Close();

                    return true;

                }
                return false;
            });
        }

        public static async Task<bool> updateReservationOnEdit(Reservation reservation,Car car)
        {
            double reservationCost = 0;
            return await Task.Run(() =>
            {
                if (connection.State != ConnectionState.Open)
                    openConnection();
                if (connection.State == ConnectionState.Open)
                {
                    var selectQuery = $"SELECT cena FROM wypozyczalniaTypy WHERE id = { (int)reservation.carType}";
                    var result = new MySqlCommand(selectQuery, connection);
                    MySqlDataReader resultReader = result.ExecuteReader();
                    while (resultReader.Read())
                    {
                        Fine tempFine = new Fine();
                        List<string> results = new List<string>();
                        for (int i = 0; i < resultReader.FieldCount; i++)
                        {
                            results.Add(resultReader[i].ToString());
                        }
                        reservationCost = Int32.Parse(results[0]);
                    }
                    resultReader.Close();
                    result.Cancel();
                    connection.Close();
                    if (showCostDialog(reservationCost))
                    {

                        return Task.Run(() =>
                        {
                            if (connection.State != ConnectionState.Open)
                                openConnection();
                            if (connection.State == ConnectionState.Open)
                            {
                                int dateDiff = getDateDiff(reservation);
                                string query = $"UPDATE wypozyczalniaOplaty SET cost = ({dateDiff}*(SELECT cena FROM wypozyczalniaTypy WHERE id = {(int)reservation.carType})), description ='Opłata za rezerwacje' WHERE id = {reservation.fineId};";
                                var insertCommand = new MySqlCommand(query, connection);
                                insertCommand.ExecuteNonQuery();
                                insertCommand.Dispose();
                                connection.Close();

                                if (connection.State != ConnectionState.Open)
                                    openConnection();
                                if (connection.State == ConnectionState.Open)
                                {
                                    int carId = -1;
                                    query = $"(SELECT id FROM wypozyczalniaSamochody c WHERE type = {(int)reservation.carType} AND brand = '{car.brand}' AND model = '{car.model}' AND efficiency = 1 AND isDisabled = 0 AND NOT EXISTS (SELECT r.* FROM `wypozyczalniaRezerwacje` r WHERE r.carId = c.id AND r.ended = 0 AND r.reservationId != {reservation.reservationId} AND((r.dateBegin BETWEEN '{reservation.dateBegin}' AND '{reservation.dateEnd}') OR(r.dateEnd BETWEEN '{reservation.dateBegin}' AND '{reservation.dateEnd}')) LIMIT 1));";
                                    result = new MySqlCommand(query, connection);
                                    resultReader = result.ExecuteReader();
                                    while (resultReader.Read())
                                    {
                                        
                                        List<string> results = new List<string>();
                                        for (int i = 0; i < resultReader.FieldCount; i++)
                                        {
                                            results.Add(resultReader[i].ToString());
                                        }
                                        carId = Int32.Parse(results[0]);
                                    }
                                    resultReader.Close();
                                    result.Cancel();
                                    connection.Close();

                                    if (connection.State != ConnectionState.Open)
                                        openConnection();
                                    if (connection.State == ConnectionState.Open)
                                    {
                                        query = $"UPDATE wypozyczalniaRezerwacje SET carId ={carId},dateBegin = '{reservation.dateBegin}', dateEnd = '{reservation.dateEnd}' WHERE reservationId = {reservation.reservationId};";
                                        insertCommand = new MySqlCommand(query, connection);
                                        insertCommand.ExecuteNonQuery();
                                        insertCommand.Dispose();
                                        connection.Close();
                                        if (insertCommand.LastInsertedId >= 0)
                                        {
                                            return true;
                                        }
                                    }
                                }
                            }
                            return false;
                        }).Result;
                    }
                }
                return false;
            });
        }

        public static async Task<bool> updateCar(Car car)
        {
            return await Task.Run(() =>
            {
                if (connection.State != ConnectionState.Open)
                    openConnection();
                if (connection.State == ConnectionState.Open)
                {
                    string query = $"UPDATE wypozyczalniaSamochody SET efficiency='{car.carEfficiency}' WHERE id='{car.registrationNumber}'";
                    var insertCommand = new MySqlCommand(query, connection);
                    insertCommand.ExecuteNonQuery();
                    insertCommand.Dispose();
                    connection.Close();


                    return true;

                }
                return false;
            });
        }

        public static async Task<List<Car>> getAvaliableCars(ReservationData reservation)
        {
            return await Task.Run(() =>
            {
                List<Car> cars = new List<Car>();
                if (connection.State != ConnectionState.Open)
                    openConnection();
                if (connection.State == ConnectionState.Open)
                {
                    var selectQuery = $"SELECT c.brand, c.model FROM wypozyczalniaSamochody c WHERE c.type = {(int)reservation.carType} AND c.isDisabled = 0 AND c.efficiency = 1 AND NOT EXISTS (SELECT r.* FROM `wypozyczalniaRezerwacje` r WHERE r.carId = c.id AND r.ended = 0 AND((r.dateBegin BETWEEN '{reservation.dateBegin}' AND '{reservation.dateEnd}') OR(r.dateEnd BETWEEN '{reservation.dateBegin}' AND '{reservation.dateEnd}'))) GROUP BY c.model;";
                    var result = new MySqlCommand(selectQuery, connection);
                    MySqlDataReader resultReader = result.ExecuteReader();
                    while (resultReader.Read())
                    {
                        Car tempCar = new Car();
                        List<string> results = new List<string>();
                        for (int i = 0; i < resultReader.FieldCount; i++)
                        {
                            results.Add(resultReader[i].ToString());
                        }
                        tempCar.brand = results[0];
                        tempCar.model = results[1];
                        cars.Add(tempCar);

                    }
                    resultReader.Close();
                    result.Cancel();
                    connection.Close();

                }
                return cars;
            });
        }

        public static async Task<List<Car>> getAvaliableCarsForEditReservation(Reservation reservation)
        {
            return await Task.Run(() =>
            {
                List<Car> cars = new List<Car>();
                if (connection.State != ConnectionState.Open)
                    openConnection();
                if (connection.State == ConnectionState.Open)
                {
                    var selectQuery = $"SELECT c.brand, c.model FROM wypozyczalniaSamochody c WHERE c.type = {(int)reservation.carType} AND c.isDisabled = 0 AND c.efficiency = 1 AND NOT EXISTS (SELECT r.* FROM `wypozyczalniaRezerwacje` r WHERE r.carId = c.id AND r.ended = 0 AND r.reservationId != {reservation.reservationId} AND((r.dateBegin BETWEEN '{reservation.dateBegin}' AND '{reservation.dateEnd}') OR(r.dateEnd BETWEEN '{reservation.dateBegin}' AND '{reservation.dateEnd}'))) GROUP BY c.model;";
                    var result = new MySqlCommand(selectQuery, connection);
                    MySqlDataReader resultReader = result.ExecuteReader();
                    while (resultReader.Read())
                    {
                        Car tempCar = new Car();
                        List<string> results = new List<string>();
                        for (int i = 0; i < resultReader.FieldCount; i++)
                        {
                            results.Add(resultReader[i].ToString());
                        }
                        tempCar.brand = results[0];
                        tempCar.model = results[1];
                        cars.Add(tempCar);

                    }
                    resultReader.Close();
                    result.Cancel();
                    connection.Close();

                }
                return cars;
            });
        }

        public static async Task<bool> insertReservation(ReservationData reservation, Car car, int accountId)
        {
            double reservationCost = 0;
            return await Task.Run(()=>
            {
                if (connection.State != ConnectionState.Open)
                    openConnection();
                if (connection.State == ConnectionState.Open)
                {
                    var selectQuery = $"SELECT cena FROM wypozyczalniaTypy WHERE id = { (int)reservation.carType}";
                    var result = new MySqlCommand(selectQuery, connection);
                    MySqlDataReader resultReader = result.ExecuteReader();
                    while (resultReader.Read())
                    {
                        Fine tempFine = new Fine();
                        List<string> results = new List<string>();
                        for (int i = 0; i < resultReader.FieldCount; i++)
                        {
                            results.Add(resultReader[i].ToString());
                        }
                        reservationCost = Int32.Parse(results[0]);
                    }
                    resultReader.Close();
                    result.Cancel();
                    connection.Close();
                    if (showCostDialog(reservationCost))
                    {

                        return Task.Run(() =>
                        {
                            if (connection.State != ConnectionState.Open)
                                openConnection();
                            if (connection.State == ConnectionState.Open)
                            {
                                int dateDiff = getDateDiff(reservation);
                                string query = $"INSERT INTO wypozyczalniaOplaty(cost, description) VALUES({dateDiff}*(SELECT cena FROM wypozyczalniaTypy WHERE id = {(int)reservation.carType}),\"Opłata za rezerwacje\");";
                                var insertCommand = new MySqlCommand(query, connection);
                                insertCommand.ExecuteNonQuery();
                                insertCommand.Dispose();
                                connection.Close();
                                if (insertCommand.LastInsertedId >= 0)
                                {
                                    if (connection.State != ConnectionState.Open)
                                        openConnection();
                                    if (connection.State == ConnectionState.Open)
                                    {
                                        query = $"INSERT INTO wypozyczalniaRezerwacje(carId, accountId,dateBegin,dateEnd,ended,fineId) VALUES((SELECT id FROM wypozyczalniaSamochody c WHERE type = {(int)reservation.carType} AND brand = '{car.brand}' AND model = '{car.model}' AND efficiency = 1 AND isDisabled = 0 AND NOT EXISTS (SELECT r.* FROM `wypozyczalniaRezerwacje` r WHERE r.carId = c.id AND r.ended = 0 AND((r.dateBegin BETWEEN '{reservation.dateBegin}' AND '{reservation.dateEnd}') OR(r.dateEnd BETWEEN '{reservation.dateBegin}' AND '{reservation.dateEnd}'))) LIMIT 1),{accountId},'{reservation.dateBegin}','{reservation.dateEnd}',0,{insertCommand.LastInsertedId});";
                                        insertCommand = new MySqlCommand(query, connection);
                                        insertCommand.ExecuteNonQuery();
                                        insertCommand.Dispose();
                                        connection.Close();
                                        if (insertCommand.LastInsertedId >= 0)
                                        {
                                            return true;
                                        }
                                    }
                                }
                            }
                            return false;
                        }).Result;
                    }
                }
                return false;
            });
        }

        public static async Task<Fine> getFine(int fineId)
        {

            return await Task.Run(() =>
            {
                Fine fine = new Fine();
                if (connection.State != ConnectionState.Open)
                    openConnection();
                if (connection.State == ConnectionState.Open)
                {
                    var selectQuery = $"SELECT id, cost, description FROM wypozyczalniaOplaty WHERE id = {fineId};";
                    var result = new MySqlCommand(selectQuery, connection);
                    MySqlDataReader resultReader = result.ExecuteReader();
                    while (resultReader.Read())
                    {
                        Fine tempFine = new Fine();
                        List<string> results = new List<string>();
                        for (int i = 0; i < resultReader.FieldCount; i++)
                        {
                            results.Add(resultReader[i].ToString());
                        }
                        tempFine.fineId = Int32.Parse(results[0]);
                        tempFine.fineCost = Convert.ToDouble(results[1]);
                        tempFine.fineDescription = results[2];
                        fine = tempFine;

                    }
                    resultReader.Close();
                    result.Cancel();
                    connection.Close();
                }
                return fine;
            });
        }

        public static bool showCostDialog(double cost)
        {
            Form prompt = new Form()
            {
                Width = 500,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = "Potwierdź rezerwacje",
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 50, Top = 20, AutoSize = true, Text = $"Czy chcesz wypożyczyć samochód za {cost}zł/dzień?" };
            Button confirmation = new Button() { Text = "Tak", Left = 100, Width = 100, Top = 70, DialogResult = DialogResult.Yes };
            Button rejection = new Button() { Text = "Nie", Left = 250, Width = 100, Top = 70, DialogResult = DialogResult.No };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(rejection);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;


            return prompt.ShowDialog() == DialogResult.Yes ? true : false ;
        }

        public static async Task<List<Fine>> getFines(Account acc)
        {

            return await Task.Run(() =>
            {
                List<Fine> fines = new List<Fine>();
                if (connection.State != ConnectionState.Open)
                    openConnection();
                if (connection.State == ConnectionState.Open)
                {
                    var selectQuery = $"SELECT id, cost, description FROM wypozyczalniaOplaty WHERE id IN (SELECT fineId FROM wypozyczalniaRezerwacje WHERE accountId = {acc.id});";
                    var result = new MySqlCommand(selectQuery, connection);
                    MySqlDataReader resultReader = result.ExecuteReader();
                    while (resultReader.Read())
                    {
                        Fine tempFine = new Fine();
                        List<string> results = new List<string>();
                        for (int i = 0; i < resultReader.FieldCount; i++)
                        {
                            results.Add(resultReader[i].ToString());
                        }
                        tempFine.fineId = Int32.Parse(results[0]);
                        tempFine.fineCost = Convert.ToDouble(results[1]);
                        tempFine.fineDescription = results[2];
                        fines.Add(tempFine);

                    }
                    resultReader.Close();
                    result.Cancel();
                    connection.Close();
                }
                return fines;
            });
        }

        public static async Task<Boolean> returnCar(Reservation res)
        {

            return await Task.Run(() =>
            {
                if (connection.State != ConnectionState.Open)
                    openConnection();
                if (connection.State == ConnectionState.Open)
                {
                    string query = $"UPDATE wypozyczalniaRezerwacje SET ended='{(res.ended ? 1 : 0)}' WHERE reservationId='{res.reservationId}'";
                    var insertCommand = new MySqlCommand(query, connection);
                    insertCommand.ExecuteNonQuery();
                    insertCommand.Dispose();
                    connection.Close();


                    return true;

                }
                return false;
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
            Label textLabel = new Label() { Left = 50, Top = 20, Text = text, AutoSize = true };
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

        private static int getDateDiff(ReservationData reservation)
        {
            DateTime from = DateTime.Parse(reservation.dateBegin);
            DateTime to = DateTime.Parse(reservation.dateEnd);
            return (to - from).Days;
        }


    }
}
