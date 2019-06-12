using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje2Form.Controllers
{
    static class ReservationController
    {
        public static List<Models.Room> SearchReservation(List<string> props, DateTime inDate, DateTime outDate, string type, double upPrice, double lowPrice)
        {
            Database.SearchReservation(props, inDate, outDate, type, upPrice, lowPrice);
        }
    }
}
