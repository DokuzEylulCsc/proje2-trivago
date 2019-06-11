using proje2Form.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje2Form.Controllers
{
    class HotelController
    {
        List<AbstractHotel> hotels = new List<AbstractHotel>();

        void CreateHotel(string type, string name, int star)
        {
            try
            {
                Factories.HotelFactory.CreateHotel(type, name, star);
            }
            catch(Exceptions.HotelTypeNotFoundException e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
        }
    }
}
