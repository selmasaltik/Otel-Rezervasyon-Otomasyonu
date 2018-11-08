using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyon
{
    public class Rezervasyon
    {
        public RezervasyonTuru rezervasyon { get; set; }
        public DateTime Tarih{ get; set; }
        public int KisiSayisi { get; set; }
        public Musteri musteri;
        public double toplam { get; set; }
       public virtual int RezervasyonNo()
        {
            Random rnd = new Random();
            int no = rnd.Next(1, 100);
            return no;
        }
       public Rezervasyon(RezervasyonTuru r)
       {
           this.rezervasyon = r;
       }
        public double ToplamFiyat()
       {
           toplam = KisiSayisi * rezervasyon.fiyat;
           return toplam;
       }

       
    }
}
