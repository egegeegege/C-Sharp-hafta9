using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Telefon telefon = new Telefon(20000,10);
            Console.WriteLine(telefon.FiyatHesapla());

            Bilgisayar bilgisayar = new Bilgisayar(30000,20,3000);
            Console.WriteLine(bilgisayar.FiyatHesapla());
            Console.ReadLine();
        }
    }
}
