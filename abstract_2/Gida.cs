using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_2
{
    public class Gida : Urun
    {
        public Gida(string ad, double fiyat)
        {
             UrunAdi = ad;
             Fiyat = fiyat;
        }
        public override double KdvUygula()
        {
            return Fiyat * 1.18;
        }
    }
}
