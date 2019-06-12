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
        
        
        public static bool CreateHotel(Models.Hotel hotel)
        {
            SQLiteCommand sqlCommand = new SQLiteCommand("insert into hotel(name,star,hotel_type) values ('" + hotel.Name + "','" + hotel.Star + "' , '" + hotel.HotelType + "')", sqlConnection);
            sqlCommand.ExecuteNonQuery();
            return true;
        }

        public static int GetHotelID(Models.Hotel hotel)
        {
            SQLiteDataReader sqlDataReader;
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
            SQLiteDataReader sqlDataReader;
            Models.Hotel temp = new Models.Hotel();
            SQLiteCommand sqlCommand = new SQLiteCommand($"SELECT * FROM hotel WHERE hotel_id = '{id}'", sqlConnection);
            sqlDataReader = sqlCommand.ExecuteReader();
            sqlDataReader.Read();
            temp.ID = Convert.ToInt32(sqlDataReader["hotel_id"]);
            temp.HotelType = sqlDataReader["hotel_type"].ToString();
            temp.Name = sqlDataReader["name"].ToString();
            temp.Star = Convert.ToInt32(sqlDataReader["star"]);
            return temp;
        }

        public static bool CreateRoom(Models.Room room,Models.Hotel hotel)
        {
            SQLiteDataReader sqlDataReader;
            SQLiteCommand sqlCommand = new SQLiteCommand("insert into room(room_price,room_type,hotel_id) values ('" + room.Price + "','" + room.Type + "','" + hotel.ID + "')", sqlConnection);
            sqlCommand.ExecuteNonQuery();
            SQLiteCommand sqlCommand3 = new SQLiteCommand($"SELECT room_id FROM room WHERE room_price = '{room.Price}' AND hotel_id = '{hotel.ID}'", sqlConnection);
            sqlDataReader = sqlCommand3.ExecuteReader();
            sqlDataReader.Read();
            int room_id = Convert.ToInt32(sqlDataReader["room_id"]);
            sqlDataReader.Close();
            foreach (string prop in room.Properties)
            {
                SQLiteCommand sqlCommand2 = new SQLiteCommand("insert into room_and_props(room_id,room_props) values ('" + room_id + "','" + prop + "')", sqlConnection);
                sqlCommand2.ExecuteNonQuery();
            }
            return true;
        }

        public static bool CreateRoomType(string s)
        {
            SQLiteCommand sqlCommand = new SQLiteCommand("insert into room_type(type_name) values ('" + s + "')", sqlConnection);
            sqlCommand.ExecuteNonQuery();
            return true;
        }

        public static bool CreateRoomProps(string s)
        {
            SQLiteCommand sqlCommand = new SQLiteCommand("insert into room_props(property_name) values ('" + s + "')", sqlConnection);
            sqlCommand.ExecuteNonQuery();
            return true;
        }

        public static List<Models.Hotel> ListHotels()
        {
            SQLiteDataReader sqlDataReader;
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

        public static List<Models.Reservation> ListReservations()
        {
            SQLiteDataReader sqlDataReader;
            SQLiteCommand sqlCommand = new SQLiteCommand("SELECT * FROM reservation", sqlConnection);
            Models.Reservation tempReservation;
            List<Models.Reservation> reservations = new List<Models.Reservation>();
            sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                tempReservation = new Models.Reservation();
                tempReservation.customer_id = Convert.ToInt32(sqlDataReader["customer_id"]);
                tempReservation.room_id = Convert.ToInt32(sqlDataReader["room_id"]);
                tempReservation.Id = Convert.ToInt32(sqlDataReader["reservation_id"]);
                tempReservation.inDate = Convert.ToInt32(sqlDataReader["inDate"]);
                tempReservation.outDate = Convert.ToInt32(sqlDataReader["outDate"]);
                reservations.Add(tempReservation);
            }
            return reservations;
        }

        public static List<string> GetHotelTypes()
        {
            SQLiteDataReader sqlDataReader;
            SQLiteCommand sqlCommand = new SQLiteCommand("Select * from hotel_types", sqlConnection);
            List<string> temp = new List<string>();
            sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                temp.Add(sqlDataReader["hotel_type_name"].ToString());
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
            SQLiteDataReader sqlDataReader;
            SQLiteCommand sqlCommand = new SQLiteCommand("Select * from room_type",sqlConnection);
            List<string> temp = new List<string>();
            sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                temp.Add(sqlDataReader["type_name"].ToString());
            }
            sqlDataReader.Close();
            return temp;
        }

        public static List<string> GetRoomProps()
        {
            SQLiteDataReader sqlDataReader;
            SQLiteCommand sqlCommand = new SQLiteCommand("Select * from room_props", sqlConnection);
            List<string> temp = new List<string>();
            sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                temp.Add(sqlDataReader["property_name"].ToString());
            }
            sqlDataReader.Close();
            return temp;
        }

        public static List<string> GetRoomPropsById(int room_id)
        {
            SQLiteDataReader sqlDataReader;
            SQLiteCommand sqlCommand = new SQLiteCommand($"Select * from room_and_props WHERE room_id = '{room_id}'", sqlConnection);
            List<string> temp = new List<string>();
            sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                temp.Add(sqlDataReader["room_props"].ToString());
            }
            return temp;
        }

        public static Models.User GetUserByID(int id)
        {
            SQLiteDataReader sqlDataReader;
            Models.User temp = new Models.User();
            SQLiteCommand sqlCommand = new SQLiteCommand($"SELECT * FROM user WHERE user_id = '{id}'", sqlConnection);
            sqlDataReader = sqlCommand.ExecuteReader();
            sqlDataReader.Read();
            temp.Id = Convert.ToInt32(sqlDataReader["user_id"]);
            temp.Name = sqlDataReader["user_name"].ToString();
            temp.Surname = sqlDataReader["user_surname"].ToString();
            temp.IsAdmin = Convert.ToInt32(sqlDataReader["user_isAdmin"]) == 1 ? true : false ;
            sqlDataReader.Close();
            return temp;
        }

        public static int RegisterUser(string name, string surname)
        {
            SQLiteCommand sqlCommand = new SQLiteCommand($"INSERT into user(user_name,user_surname,user_isAdmin) values ('" + name + "','" + surname + "','0')", sqlConnection);
            sqlCommand.ExecuteNonQuery();
            Models.User temp = new Models.User();
            temp.Name = name;
            temp.Surname = surname;
            return GetUserId(temp);
        }

        public static int GetUserId(Models.User user)
        {
            SQLiteDataReader sqlDataReader;
            SQLiteCommand sqlCommand = new SQLiteCommand($"SELECT user_id FROM user WHERE user_name = '{user.Name}' AND user_surname = '{user.Surname}'", sqlConnection);
            sqlDataReader = sqlCommand.ExecuteReader();
            int temp;
            sqlDataReader.Read();
            temp = Convert.ToInt32(sqlDataReader["user_id"]);
            sqlDataReader.Close();
            return temp;
        }

        public static void UserUpdate(int id,string name,string surname)
        {
            SQLiteCommand sqlCommand = new SQLiteCommand($"UPDATE user SET user_name = {name}, user_surname = {surname} WHERE user_id='{id.ToString()}';", sqlConnection);
            sqlCommand.ExecuteNonQuery();
        }

        public static void MakeReservation(Models.Reservation reservation)
        {
            SQLiteCommand sqlCommand = new SQLiteCommand($"INSERT into reservation(customer_id,room_id,inDate,outDate) values ('" + reservation.customer_id + "','" + reservation.room_id + "','" + reservation.inDate + "', '" + reservation.outDate + "')", sqlConnection);
            sqlCommand.ExecuteNonQuery();
        }

        public static List<Models.Reservation> GetReservationById(int customer_id)
        {
            SQLiteDataReader sqlDataReader;
            List<Models.Reservation> reservations = new List<Models.Reservation>();
            Models.Reservation tempReservation;
            SQLiteCommand sqlCommand = new SQLiteCommand($"SELECT * FROM reservation WHERE customer_id = '{customer_id}'", sqlConnection);
            sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                tempReservation = new Models.Reservation();
                tempReservation.Id = Convert.ToInt32(sqlDataReader["reservation_id"]);
                tempReservation.customer_id = Convert.ToInt32(sqlDataReader["customer_id"]);
                tempReservation.room_id = Convert.ToInt32(sqlDataReader["room_id"]);
                tempReservation.inDate = Convert.ToInt32(sqlDataReader["inDate"]);
                tempReservation.outDate = Convert.ToInt32(sqlDataReader["outDate"]);
                reservations.Add(tempReservation);
            }
            return reservations;
        }

        public static List<Models.Room> ListAllRooms()
        {
            SQLiteDataReader sqlDataReader;
            SQLiteCommand sqlCommand = new SQLiteCommand("Select * from room", sqlConnection);
            List<Models.Room> rooms = new List<Models.Room>();
            Models.Room tempRoom;
            sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                tempRoom = new Models.Room();
                tempRoom.Price = Convert.ToInt32(sqlDataReader["room_price"]);
                tempRoom.RoomNumber = Convert.ToInt32(sqlDataReader["room_id"]);
                tempRoom.Type = sqlDataReader["room_type"].ToString();
                tempRoom.Properties = GetRoomPropsById(tempRoom.RoomNumber);
                tempRoom.Hotel = GetHotelByID(Convert.ToInt32(sqlDataReader["hotel_id"]));
                rooms.Add(tempRoom);
            }
            sqlDataReader.Close();
            return rooms;
        }

        public static List<Models.Room> FilterRoomByType(string type)
        {
            List<Models.Room> allRooms = ListAllRooms();
            List<Models.Room> temp = ListAllRooms();
            foreach (Models.Room room in temp)
            {
                if (!room.Type.Equals(type))
                    allRooms.Remove(room);
            }
            return allRooms;
        }
        public static List<Models.Room> FilterRoomsByPrice(List<Models.Room> rooms,int upPrice, int lowerPrice)
        {
            List<Models.Room> temp = new List<Models.Room>();
            foreach (var item in rooms)
            {
                temp.Add(item);
            }
            foreach (Models.Room room in temp)
            {
                if (room.Price > upPrice || room.Price < lowerPrice)
                    rooms.Remove(room);
            }
            return rooms;

        }
        public static List<Models.Room> FilterRoomByProps(List<string> props,List<Models.Room> rooms)
        {
            List<Models.Room> temp = new List<Models.Room>();
            foreach (var item in rooms)
            {
                temp.Add(item);
            }
            foreach (Models.Room room in temp)
            {
                foreach (string prop in props)
                {
                    if (!room.Properties.Contains(prop))
                        rooms.Remove(room);
                }
            }
            return rooms;
        }

        public static int DateTimeToInt(DateTime date)
        {
            return Convert.ToInt32(date.Year.ToString() + date.Month.ToString("00") + date.Day.ToString("00"));
        }

        public static List<Models.Room> FilterRoomsByDate(List<Models.Room> rooms, int inDate, int outDate)
        {

            List<Models.Room> temp = rooms;
            List<Models.Reservation> reservations = ListReservations();
            bool flag = false;
            foreach (Models.Reservation reservation in reservations)
            {
                foreach (Models.Room room in temp)
                {
                    if (reservation.room_id == room.RoomNumber)
                    {
                        if (reservation.inDate >= outDate || reservation.outDate <= inDate)
                        {
                            flag = true;
                        }
                        if (flag == false) rooms.Remove(room);
                        flag = false;
                    }
                }
            }
            return rooms;
        }

        public static List<Models.Room> SearchReservation(List<string> props,DateTime inDate,DateTime outDate,string type, int upPrice, int lowPrice)
        {
            List<Models.Room> olasıOdalar = FilterRoomsByDate(FilterRoomByProps(props,FilterRoomsByPrice(FilterRoomByType(type),upPrice,lowPrice)), DateTimeToInt(inDate), DateTimeToInt(outDate));
            return olasıOdalar;
        }
    }
}
