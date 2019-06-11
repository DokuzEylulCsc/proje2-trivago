using proje2Form.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje2Form.Controllers
{
    static class HotelController
    {
        static Hotel hotel;
        public static void CreateHotel(string type, string name, int star)
        {
            hotel = new Hotel();
            hotel.HotelType = type;
            hotel.Name = name;
            hotel.Star = star;
            Database.CreateHotel(hotel);
            hotel.ID = Database.GetHotelID(hotel);
        }

        public static void CreateHotelType(string type)
        {

        }
    }
}
