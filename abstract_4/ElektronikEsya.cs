using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_4
{
    public abstract class ElektronikEsya
    {
        public decimal AlisFiyat { get; set; }
        public decimal KarYuzdesi { get; set; }

        public abstract decimal FiyatHesapla();
    }
}
