using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje2Form.Models
{
    abstract class AbstractHotel
    {
        public int Star { get; set; }
        public string Name { get; set; }

        public List<Room> Rooms = new List<Room>();

    }
}
