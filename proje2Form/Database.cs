using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace proje2Form
{
    static class Database
    {
        public static SQLiteConnection sqlConnection;
        public static SQLiteDataReader sqlDataReader;
        public static SQLiteCommand sqlCommand = new SQLiteCommand();

        public static bool CreateHotel(Models.Hotel hotel)
        {
            sqlCommand.CommandText = "insert into hotel(name,star,hotel_type) values ('" + hotel.Name + "','" + hotel.Star + "' , '" + hotel.HotelType + "')";
            sqlCommand.ExecuteNonQuery();
            return true;
        }

        public static List<string> GetHotelTypes()
        {
            List<string> temp = new List<string>();
            Database.sqlCommand.CommandText = "Select * from hotel_types";
            Database.sqlCommand.Connection = Database.sqlConnection;
            Database.sqlDataReader = Database.sqlCommand.ExecuteReader();
            while (Database.sqlDataReader.Read())
            {
                temp.Add(Database.sqlDataReader["hotel_type_name"].ToString());
            }
            return temp;
        }
    }
}
