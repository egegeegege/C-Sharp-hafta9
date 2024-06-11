using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_4
{
    public class Telefon : ElektronikEsya
    {

        public Telefon(decimal alisFiyat, decimal karYuzdesi)
        {
            AlisFiyat = alisFiyat;
            KarYuzdesi = karYuzdesi;
        }

        public override decimal FiyatHesapla()
        {
            return AlisFiyat + ((KarYuzdesi/100) * AlisFiyat);
        }
    }
}
