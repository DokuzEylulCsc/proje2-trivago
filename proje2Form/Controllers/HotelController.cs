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
        private static Hotel Hotel { get; set; }
        public static Hotel CreateHotel(string type, string name, int star)
        {
            Hotel.HotelType = type;
            Hotel.Name = name;
            Hotel.Star = star;
            return Hotel;
        }

        public static void AddHotelType(string name)
        {

        }
    }
}
