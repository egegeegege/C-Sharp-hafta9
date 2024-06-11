using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_2
{
    public class Isci : IKisi
    {
        public void Bilgi()
        {
            Console.WriteLine("Ben bir işçiyim");
        }

        public void BordroCikar()
        {
            throw new NotImplementedException();
        }

        public void InsaaEt()
        {
            Console.WriteLine("İnsaa ettim");
        }

        public void MaasGoster()
        {
            throw new NotImplementedException();
        }
    }
}
