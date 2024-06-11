using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_2
{
    public class Yonetici : IKisi
    {
        public void Bilgi()
        {
            Console.WriteLine("Ben bir yöneticiyim");
        }

        public void BordroCikar()
        {
            throw new NotImplementedException();
        }

        public void MaasGoster()
        {
            throw new NotImplementedException();
        }

        public void ProjeYap()
        {
            Console.WriteLine("Proje yaptım");
        }
    }
}
