using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev
{
    public class Urun
    {
        public string UrunAdi { get; set; }
        public int Fiyat { get; set; }

        public virtual double KdvHesapla()
        {
            return Fiyat * 1.12;
        }
    }
}
