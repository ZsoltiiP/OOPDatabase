using MySql.Data.MySqlClient;
using OOPDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAdatbazis.Services
{
    
    class TableCars : ISqlStatements
    {
        public object AddNewRecord(object newRecord)
        {
            Connect conn = new Connect();
            conn.Connection.Open();

            string sql = "INSERT INTO `cars`(`brand`, `type`, `mDate`) VALUES" +
                " (@brand, @type, @date)";

            MySqlCommand cmd = new MySqlCommand(sql, conn.Connection);

            var car = newBook.GetType().GetProperties();

            cmd.Parameters.AddWithValue("@brand", car[0].GetValue(newBook));
            cmd.Parameters.AddWithValue("@type", car[1].GetValue(newBook));
            cmd.Parameters.AddWithValue("@date", car[2].GetValue(newBook));

            cmd.ExecuteNonQuery();

            conn.Connection.Close();

            return car;           
        }

        public object DeleteRecord(int id)
        {
            Connect conn = new Connect();

            conn.Connection.Open();
            string sql = "DELETE FROM `cars` WHERE id = @id";

            MySqlCommand cmd = new MySqlCommand(sql, conn.Connection);

            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();




            conn.Connection.Close();

            return new { Message = "Sikeres törlés" };
        }

        public List<object> GetAllRecords()
        {
            Connect conn = new Connect();
            List<object> result = new List<object>();


            conn.Connection.Open();

            string sql = "SELECT * FROM cars";

            MySqlCommand cmd = new MySqlCommand(sql, conn.Connection);

            MySqlDataReader dr = cmd.ExecuteReader();

            //dr.Read();

            while (dr.Read())
            {
                var car = new
                {
                    Id = dr.GetInt32("id"),
                    Title = dr.GetString("brand"),
                    Author = dr.GetString("type"),
                    Release = dr.GetDateTime("mDate")
                };

                result.Add(car);
            }

            conn.Connection.Close();

            return result;
        }

        public object GetById(int id)
        {
            Connect conn = new Connect();
            conn.Connection.Open();

            string sql = "SELECT * FROM cars WHERE id = @id ";

            MySqlCommand cmd = new MySqlCommand(sql, conn.Connection);
            cmd.Parameters.AddWithValue("@id", id);

            MySqlDataReader dr = cmd.ExecuteReader();

            dr.Read();

            var car = new
            {
                Id = dr.GetInt32("id"),
                Title = dr.GetString("brand"),
                Author = dr.GetString("type"),
                Release = dr.GetDateTime("mDate")

            };

            conn.Connection.Close();

            return car;
        }

        public object UpdateRecord(int id, object updateRecord)
        {
            Connect conn = new Connect();
            conn.Connection.Open();

            string sql = "UPDATE `cars` SET " +
                "`brand`=@brand,`type`=@type,`mDate`=@date WHERE id = @id";

            MySqlCommand cmd = new MySqlCommand(sql, conn.Connection);

            var book = updateRecord.GetType().GetProperties();
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@brand", book[0].GetValue(updateRecord));
            cmd.Parameters.AddWithValue("@type", book[1].GetValue(updateRecord));
            cmd.Parameters.AddWithValue("@date", book[2].GetValue(updateRecord));

            cmd.ExecuteNonQuery();

            conn.Connection.Close();

            return new { Message = "Sikeres frissítés." };
        }
    }
}
