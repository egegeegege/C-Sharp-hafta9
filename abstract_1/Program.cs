using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
             Abstract Nedir ?
             Abstract classlar oluşturulması istenen classların sadece base(parent) sınıf olarak çalışmasını sağlayan yapılardır.
             Abstract classların instance ı alınamaz.
             Abstract classı oluşturman için "abstract" keywordünü kullanmalıyız.  
             Abstract classlarda gövdesiz method oluşturulabilir.
             */

            // TemelSinif temelSinif = new TemelSinif(); instance oluşturulamaz !!

            // Abstract Sınıflarla Normal sınıflar arasındaki fark?
            /* 
             Normal sınıflarda method bildirimi (gövdesiz method) yazılamazken abstract classlarda method bildirimi "abstract" keywordü ile yapılabilir. Abstract classın içinde bildirimi yapılan gövdesiz method mutlaka miras alan türeyen sınıflarda implemente edilmelidir.
             Normal sınıflarda "new()" anahtar kelimesi ile nesneler oluşturulabilir ancak abstract sınıflar tamamen kalıtım amacıyla kullanıldığından abstract sınıfların bir instance ı oluşturulamaz!
             
             
             
             
             */
            TuremisSinif turemisSinif = new TuremisSinif();
            turemisSinif.Method_1();
            turemisSinif.Method_2();
            

            Console.ReadLine();

        }
    }

    public abstract class TemelSinif
    {
        private int A { get; set; }
        public void Method_1()
        {
            Console.WriteLine("Abstract sınıfın içinde tanımlanmış method");
        }

        public abstract void Method_2(); // Gövdesiz method. Yani içi boş, yapacağı iş tanımlanmamış.
        // abstract ile işaretlediğimiz method turemisSinif ta override edilmelidir.
        // Dinamik polymorphism ile karıştırmıyoruz !! virtual ile işaretlenmiş method gövdesiz yazılamaz!     


    }

    public class TuremisSinif : TemelSinif
    {

        // implementetion (implemente etmek)
        public override void Method_2()  // Temel sınıfta tanımlı abstract ile işaratlenmiş gövdesiz methodu override edip gövdeli hale getirdim.
        {
            Console.WriteLine("Abstract sınıftan implemente edilip override edilen method");
        }

       
    }

    public class TurSinif : TemelSinif
    {
        public override void Method_2()
        {
            throw new NotImplementedException();
        }

    }


}
