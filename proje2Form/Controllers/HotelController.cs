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
        static List<AbstractHotel> hotels = new List<AbstractHotel>();

        public static void CreateHotel(string type, string name, int star)
        {
            try
            {
                hotels.Add(Factories.HotelFactory.CreateHotel(type, name, star));
            }
            catch(Exceptions.HotelTypeNotFoundException e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
        }
    }
}
