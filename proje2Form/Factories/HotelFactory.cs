using proje2Form.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje2Form.Factories
{
    static class HotelFactory
    {
        public static AbstractHotel CreateHotel(string type, string name, int star)
        {
            switch (type)
            {
                case "Botel":
                    Botel botel = new Botel();
                    botel.Name = name;
                    botel.Star = star;
                    return botel;
                case "Boutique":
                    Boutique boutique = new Boutique();
                    boutique.Name = name;
                    boutique.Star = star;
                    return boutique;
                case "Motel":
                    Motel motel = new Motel();
                    motel.Name = name;
                    motel.Star = star;
                    return motel;
                case "Pension":
                    Pension pension = new Pension();
                    pension.Name = name;
                    pension.Star = star;
                    return pension;
                case "Resort":
                    Resort resort = new Resort();
                    resort.Name = name;
                    resort.Star = star;
                    return resort;
                default:
                    throw new Exceptions.HotelTypeNotFoundException(type);
            }
        }
    }
}
