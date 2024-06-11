using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ipek ipek = new Ipek();
            ipek.Kalinlik = 10;
            ipek.KumasEkle(ipek);

            Keten keten = new Keten();
            keten.Kalinlik = 20;
            keten.KumasEkle(keten);

            keten.KumasGoster();
            ipek.KumasGoster();
            Console.ReadLine();
        }
    }
}
