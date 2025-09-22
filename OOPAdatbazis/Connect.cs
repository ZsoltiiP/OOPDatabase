using MySql.Data.MySqlClient;
using System;

namespace OOPDatabase
{
    public class Connect
    {
        public MySqlConnection Connection;

        private string _host;
        private string _database;
        private string _user;
        private string _password;

        private string ConnectionString;

        public Connect()
        {
            _host = "localhost";
            _database = "library";
            _user = "root";
            _password = "";

            ConnectionString = $"SERVER={_host};DATABASE={_database};UID={_user};PASSWORD={_password};SslMode=None";

            Connection = new MySqlConnection(ConnectionString);

            try
            {
                Connection.Open();
                System.Console.WriteLine("Sikeres csatlakozás.");
                Connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}