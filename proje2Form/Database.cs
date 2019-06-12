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
        
        public static bool CreateHotel(Models.Hotel hotel)
        {
            SQLiteCommand sqlCommand = new SQLiteCommand("insert into hotel(name,star,hotel_type) values ('" + hotel.Name + "','" + hotel.Star + "' , '" + hotel.HotelType + "')", sqlConnection);
            sqlCommand.ExecuteNonQuery();
            return true;
        }

        public static int GetHotelID(Models.Hotel hotel)
        {
            SQLiteCommand sqlCommand = new SQLiteCommand($"SELECT hotel_id FROM hotel WHERE name = '{hotel.Name}' AND star = '{hotel.Star.ToString()}' AND hotel_type = '{hotel.HotelType}'", sqlConnection);
            sqlDataReader = sqlCommand.ExecuteReader();
            int temp;
            sqlDataReader.Read();
            temp = Convert.ToInt32(sqlDataReader["hotel_id"]);
            sqlDataReader.Close();
            return temp;
        }

        public static Models.Hotel GetHotelByID(int id)
        {
            Models.Hotel temp = new Models.Hotel();
            SQLiteCommand sqlCommand = new SQLiteCommand($"SELECT * FROM hotel WHERE hotel_id = '{id}'", sqlConnection);
            sqlDataReader = sqlCommand.ExecuteReader();
            sqlDataReader.Read();
            temp.ID = Convert.ToInt32(sqlDataReader["hotel_id"]);
            temp.HotelType = sqlDataReader["hotel_type"].ToString();
            temp.Name = sqlDataReader["name"].ToString();
            temp.Star = Convert.ToInt32(sqlDataReader["star"]);
            sqlDataReader.Close();
            return temp;
        }

        public static bool CreateRoom(Models.Room room,Models.Hotel hotel)
        {
            SQLiteCommand sqlCommand = new SQLiteCommand("insert into room(room_price,hotel_id) values ('" + room.Price + "','" + hotel.ID + "')", sqlConnection);
            sqlCommand.ExecuteNonQuery();
            return true;
        }

        public static bool CreateRoomType(string s)
        {
            SQLiteCommand sqlCommand = new SQLiteCommand("insert into room_props(property_name) values ('" + s + "')", sqlConnection);
            sqlCommand.ExecuteNonQuery();
            return true;
        }

        public static List<Models.Hotel> ListHotels()
        {
            SQLiteCommand sqlCommand = new SQLiteCommand("SELECT * FROM hotel", sqlConnection);
            Models.Hotel tempHotel;
            List<Models.Hotel> hotels = new List<Models.Hotel>();
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
            SQLiteCommand sqlCommand = new SQLiteCommand("Select * from hotel_types", sqlConnection);
            List<string> temp = new List<string>();
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
            SQLiteCommand sqlCommand = new SQLiteCommand($"INSERT into \"hotel_types\"(\"hotel_type_name\") values ('" + s + "')", sqlConnection);
            sqlCommand.ExecuteNonQuery();
        }

        public static List<string> GetRoomTypes()
        {
            SQLiteCommand sqlCommandLocal = new SQLiteCommand("Select * from room_props",sqlConnection);
            List<string> temp = new List<string>();
            sqlDataReader = sqlCommandLocal.ExecuteReader();
            while (sqlDataReader.Read())
            {
                temp.Add(sqlDataReader["property_name"].ToString());
            }
            sqlDataReader.Close();
            return temp;
        }

        public static Models.User GetUserByID(int id)
        {
            Models.User temp = new Models.User();
            SQLiteCommand sqlCommand = new SQLiteCommand($"SELECT * FROM user WHERE user_id = '{id}'", sqlConnection);
            sqlDataReader = sqlCommand.ExecuteReader();
            sqlDataReader.Read();
            temp.Id = Convert.ToInt32(sqlDataReader["user_id"]);
            temp.Name = sqlDataReader["hotel_type"].ToString();
            temp.Surname = sqlDataReader["name"].ToString();
            temp.IsAdmin = Convert.ToInt32(sqlDataReader["isAdmin"]) == 1 ? true : false ;
            sqlDataReader.Close();
            return temp;
        }
    }
}
