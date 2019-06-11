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
        public void CreateMotel(int star, string name)
        {
            Motel motel = new Motel();
            motel.Star = star;
            motel.Name = name;
            //TODO Hoteller bir yerde tutulmalı
        }
    }
}
