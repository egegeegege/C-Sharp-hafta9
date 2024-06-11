using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_2
{
    public abstract class Urun
    {
        public int ID { get; set; }
        public string UrunAdi { get; set; }
        public double Fiyat { get; set; }
        public string Kategori { get; set; }

        public abstract double KdvUygula();
    }
}
