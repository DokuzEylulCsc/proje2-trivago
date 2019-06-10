using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje2Console
{
    abstract class Otel
    {
        string adi;
        int yildizSayisi;
        readonly string sehir;
        private List<Oda> odalar = new List<Oda>();
        private List<Rezervasyon> rezervasyonlar = new List<Rezervasyon>();

        public void RezervasyonYap(Oda oda, Musteri musteri, DateTime giris, DateTime cikis)
        {
            rezervasyonlar.Add(new Rezervasyon(musteri, giris, cikis, oda));
        }

        public List<Rezervasyon> Rezervasyonlar(Kullanici kullanici)
        {
            return null;
        }
    }
}
