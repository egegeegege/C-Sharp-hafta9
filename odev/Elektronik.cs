using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev
{
    public class Elektronik : Urun
    {
        public override double KdvHesapla()
        {
            return Fiyat * 1.20;
        }
    }
}
