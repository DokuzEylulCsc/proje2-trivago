using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje2Console
{
    class Rezervasyon
    {
        private Musteri musteri;
        private DateTime giris;
        private DateTime cikis;
        private Oda oda;

        public Rezervasyon(Musteri musteri, DateTime giris, DateTime cikis, Oda oda)
        {
            this.musteri = musteri;
            this.giris = giris;
            this.cikis = cikis;
        }

    }
}
