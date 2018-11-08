using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyon
{
    public abstract class RezervasyonTuru
    {
        public double fiyat { get; set; }
        public abstract double Fiyat();

    }
}
