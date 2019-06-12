using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje2Form.Models
{
    class Reservation
    {
        public int Id { get; set; }
        public int customer_id { get; set; }
        public int room_id { get; set; }
        public int inDate { get; set; }
        public int outDate { get; set; }
    }
}
