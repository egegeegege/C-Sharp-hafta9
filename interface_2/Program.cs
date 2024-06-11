using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Yonetici yonetici = new Yonetici();
            yonetici.Bilgi();
            yonetici.ProjeYap();

            Isci isci = new Isci();
            isci.Bilgi();
            isci.InsaaEt();

            Console.ReadLine();
        }
    }
}
