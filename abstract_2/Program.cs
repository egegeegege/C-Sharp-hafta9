using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Elektronik elektronik = new Elektronik("Kumanda",100);
            double EFiyat = elektronik.KdvUygula();
            Gida gida = new Gida("Ekmek",10);
            double GFiyat = gida.KdvUygula();

            Console.WriteLine("Elektronik: {0}", EFiyat);
            Console.WriteLine("Gıda: {0}", GFiyat);
            Console.ReadLine();

        }
    }
}
