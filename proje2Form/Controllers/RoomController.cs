using proje2Form.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje2Form.Controllers
{
    class RoomController
    {
        static Room room;
        public static void CreateRoom(string type, double price, Hotel hotel)
        {
            room = new Room();
            room.Type = type;
            room.Price = price;
            room.Hotel = hotel;
            Database.CreateRoom(room, hotel);
        }

        public static List<string> GetRoomTypes()
        {
            return Database.GetRoomTypes();
        }

        public static void CreateRoomType(string type)
        {
            Database.CreateRoomType(type);
        }

        public static List<string> GetRoomProps()
        {
            return Database.GetRoomProps();
        }
    }
}
