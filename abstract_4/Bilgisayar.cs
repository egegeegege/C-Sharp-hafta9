using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_4
{
    public class Bilgisayar : ElektronikEsya
    {
        public decimal EkMasraf { get; set; }

        public Bilgisayar(decimal alisFiyat, decimal karYuzdesi, decimal ekMasraf)
        {
            AlisFiyat = alisFiyat;
            KarYuzdesi = karYuzdesi;
            EkMasraf = ekMasraf;
        }
        public override decimal FiyatHesapla()
        {
            return AlisFiyat + ((KarYuzdesi / 100) * AlisFiyat) + EkMasraf; 
        }
    }
}
