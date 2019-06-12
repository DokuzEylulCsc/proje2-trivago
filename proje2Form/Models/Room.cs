using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje2Form.Models
{
    public class Room
    {
        public int RoomNumber { get; set; }
        public double Price { get; set; }
        public string Type { get; set; }
        public Hotel Hotel { get; set; }

        public List<string> Properties = new List<string>();
    }
}
