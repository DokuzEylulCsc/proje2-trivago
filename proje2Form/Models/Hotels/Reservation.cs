using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje2Form.Models
{
    class Reservation
    {
        public int ReservationNumber { get; set; }
        public Room room { get; set; }
        public User Customer { get; set; }
        public DateTime inDate { get; set; }
        public DateTime outDate { get; set; }
    }
}
