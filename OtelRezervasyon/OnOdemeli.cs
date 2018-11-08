using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyon
{
    public class OnOdemeli:RezervasyonTuru
    {
        public override double Fiyat()
        {
            Random rnd = new Random();
            this.fiyat = rnd.Next(101,150);
            return fiyat;
        }
    }
}
