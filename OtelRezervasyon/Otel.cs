using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyon
{
    public class Otel
    {
        public List<Rezervasyon> Rezervasyonlar = new List<Rezervasyon>();
        
        public void RezervasyonEkle(Rezervasyon r)
        {
            Rezervasyonlar.Add(r);
        }
        public void RezervasyonSil(Rezervasyon r)
        {
            Rezervasyonlar.Remove(r);
        }
        public string RezervasyonListele()
        {
            string mesaj = "";
            foreach (Rezervasyon r in Rezervasyonlar)
            {
                mesaj = r.RezervasyonNo().ToString();
            }
            return mesaj;
        }
    }
}
