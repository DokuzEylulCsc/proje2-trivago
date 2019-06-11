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
        public static SQLiteCommand sqlCommand = new SQLiteCommand(sqlConnection);
        
        public static bool CreateHotel(Models.Hotel hotel)
        {
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = "insert into hotel(name,star,hotel_type) values ('" + hotel.Name + "','" + hotel.Star + "' , '" + hotel.HotelType + "')";
            sqlCommand.ExecuteNonQuery();
            return true;
        }

        public static int GetHotelID(Models.Hotel hotel)
        {
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = $"SELECT hotel_id FROM hotel WHERE name = '{hotel.Name}' AND star = '{hotel.Star.ToString()}' AND hotel_type = '{hotel.HotelType}'";
            sqlDataReader = sqlCommand.ExecuteReader();
            int temp;
            sqlDataReader.Read();
            temp = Convert.ToInt32(sqlDataReader["hotel_id"]);
            sqlDataReader.Close();
            return temp;
        }

        public static bool CreateRoom(Models.Room room,Models.Hotel hotel)
        {
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = "insert into room(price,hotel_id) values ('" + room.Price + "','" + hotel.ID + "')";
            sqlCommand.ExecuteNonQuery();
            return true;
        }

        public static List<Models.Hotel> ListHotels()
        {
            sqlCommand.Connection = sqlConnection;
            Models.Hotel tempHotel;
            List<Models.Hotel> hotels = new List<Models.Hotel>();
            sqlCommand.CommandText = "SELECT * FROM hotel";
            sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                tempHotel = new Models.Hotel();
                tempHotel.HotelType = sqlDataReader["hotel_type"].ToString();
                tempHotel.ID = Convert.ToInt32(sqlDataReader["hotel_id"]);
                tempHotel.Name = sqlDataReader["name"].ToString();
                tempHotel.Star = Convert.ToInt32(sqlDataReader["star"]);
                hotels.Add(tempHotel);
            }
            return hotels;
        }

        public static List<string> GetHotelTypes()
        {
            sqlCommand.Connection = sqlConnection;
            List<string> temp = new List<string>();
            sqlCommand.CommandText = "Select * from hotel_types";
            sqlDataReader = sqlCommand.ExecuteReader();
            while (Database.sqlDataReader.Read())
            {
                temp.Add(Database.sqlDataReader["hotel_type_name"].ToString());
            }
            sqlDataReader.Close();
            return temp;
        }

        public static void CreateHotelType(string s)
        {
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = "INSERT into hotel_types(hotel_type_name) values ('" + s + "')";
            sqlCommand.ExecuteNonQuery();
        }

        public static List<string> GetRoomTypes()
        {
            sqlCommand.Connection = sqlConnection;
            List<string> temp = new List<string>();
            sqlCommand.CommandText = "Select * from room_props";
            sqlDataReader = sqlCommand.ExecuteReader();
            while (Database.sqlDataReader.Read())
            {
                temp.Add(Database.sqlDataReader["property_name"].ToString());
            }
            sqlDataReader.Close();
            return temp;
        }
    }
}
