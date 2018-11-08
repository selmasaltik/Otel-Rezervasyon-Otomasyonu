using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyon
{
    public class ErkenRezervasyon:RezervasyonTuru
    {
        public override double Fiyat()
        {
            Random rnd = new Random();
            this.fiyat = rnd.Next(1,49);
            return fiyat;
        }
    }
}
