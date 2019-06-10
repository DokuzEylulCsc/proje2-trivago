﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje2Form.Models
{
    abstract class Room
    {
        public int RoomNumber { get; set; }
        public double Price { get; set; }
        public AbstractHotel Hotel { get; set; }

        public List<string> Properties = new List<string>();
    }
}
