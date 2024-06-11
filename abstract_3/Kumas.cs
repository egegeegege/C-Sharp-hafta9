using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_3
{
    public abstract class Kumas
    {
        protected List<Kumas> kumaslar = new List<Kumas>();
        public int Kalinlik { get; set; }
        public void KumasEkle(Kumas kumas)
        {
            kumaslar.Add(kumas);
        }
        public void KumasGoster()
        {
            foreach (var kumas in kumaslar)
            {
                Console.WriteLine(kumas.Kalinlik);
            }
        }
    }
}
