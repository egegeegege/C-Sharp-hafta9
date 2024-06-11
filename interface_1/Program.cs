using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Interface nedir ?
            /* 
             Bir sınıftan kalıtım yoluyla özellik almak güçlü bir mekanizmadır, asıl kalıtım gücü bir arayüzden kalıtımla miras alınmasında yatar.
            Bir sınıf kalıtımla sadece bir sınıftan türetilebilir ancak bu kısıtlama kalıtımla arayüzden türetme söz konusu olduğunda ortadan kalkar. Yani bir sınıf birden çok arayüzden türeyebilir.
            Arayüzler sınıflar gibi kod ve veri içermez. Sadece tanım içerir (C# 8 ve sonrası bu durum değişti)
            Aslında soyut (abstract) sınıflar arayüzlere benzerler ancak soyut sınıflar kod ve veri içerdiğinden arayüzlerden ayrılırlar.
            Fakat soyut sınıflar arayüzlerle beraber kullanıldığında çok güçlü mekanizmalar geliştirilebilir.

            Interface neden kullanılır ve faydaları nelerdir ?

            Arayüz uygulamasının kullanım amacı büyük çaplı ve çok sayıda geliştiricinin olduğu projelerde çalışılan projenin belirli kurallar çevresinde tanımlanıp ve bu kurallar yardımıyla sınıfların hangi özellikleri barındırması gerektiğini belirterek geliştiriclere yol göstermektir.
            Küçük çaplı ve bireysel olarak geliştirilen projelerde geliştirici hangi sınıfın hangi methodları ve işleri kullanması gerektiğini bildiğinden arayüz kullanımı gerekmeyebilir fakat yazılım ilkeleri ve kuralları doğrultusunda arayüz kullanımı büyük önem arz etmektedir.
            Arayüz tanımalamak için class gibi ifadeler yerine "interface" anahtar kelimesi kullanılır.
            Arayüzün içinde method bildirimleri yapılır. 
            Arayüzler public olarak işartlenmez zaten public olmak zorundadır. Aynı zamanda içinde bulunan methodlarada bir erişim belirleyici eklenmez. Implemente olduğu somut sınıfta arayüz implementasyonu sonucu implemente edilen methodlar mutlaka public olmalıdır.
            Arayüz isminin başında "I" harfi olmasına önem verilmelidir. Bu durum yapının interface olduğunu belirtir.

            * Bir arayüzün içinde property veya gövdeli method olduğunu unutmamalıyız. Bu durumun doğal sonucu olarak karşımıza bazı kısıtlamalar çıkar:
            - Bir arayüz içinde field (property) tanımalanamaz. (static olsa bile) Çünkü o fielad sınıfın ya da yapının uygulama detayıdır.
            - Bir arayüzde constructor kesinlikle kullanılamaz. Bu da uygulama detayı olarak kabul edilir.
            - Arayüz içinde tüm methodlar publictir. Implemente edilirkende public olarak kesinlikle belirtilmelidir.
            - Bir arayüzü kesinlikle bir yapıdan yada sınıftan türetemezsiniz. Fakat bir interface başka bir interfaceten türeyebilir. Hatta bir çoğundan türeyebilir. Fakat interfaceler birbirinden türediğinde mantık olarak bir miras alma işlemi gerçekleşir fakat implementasyon süreci gerçekleşmez. Implementasyon süreci sadece interfacelerin somut bir sınıfa miras vermesi durumunda gerçekleşir.

            Interface kullanımında implementasyon kuralları
            - bir interfaceten impelemente alan bir somut sınıf interfacete tanımlı methodu alırken mutlaka dönüş türleri ve parametleri bire bir garanti altına alınmalıdır.
            - Parametreler (ref out anahtar sözcükleri dahil) tam olarak eşleşmelidir.
            - Arayüz tanımı ile arayüzün uygulanması arasında bir fark var ise uygulama derlenmez ve hata verir.
            - Arayüzden türetilen sınıf içerisinde tanımlanan method mutlaka public olmalıdır.


            Bir sınıf hem bir sınıftan (abstract yada normal sınıf olabilir) hemde bir veya daha fazla interfaceten miras alabilir.
                    
             
             
             */

        }
    }

    interface IA
    {
        void AMethod();
    }
    interface IB
    {

    }


    interface IArayuz : IA, IB
    {
        // İş yapan yapılar olmaz sadece tanımlamar olur.
        void Method();
        void Method(int i);

        //void Method2()  // c# 8 sonrası gövdeli method tanımlanabilir.
        //{

        //}
    }

    interface IInsan  // erişim belirleyici olmaz varsayılan olarak public olur.
    {
        void Buyu();
        double Yas(int a);
    }

    public abstract class Insan
    {
        // implemente edilen methodlar public olmak zorundadır !
        public void Buyu()  // Interfaceteki Buyu adlı gövdesiz methodu implemente ettik.
        {
            Console.WriteLine("Büyüdüm.");
        }

    }

    public class Ogrenci : Insan, IInsan, IArayuz  // Interfaceler birden çok olacak şekilde bir sınıfa implemente edilebilir.
    {
        public void AMethod()
        {
            throw new NotImplementedException();
        }

        public void Method()
        {
            throw new NotImplementedException();
        }

        public void Method(int number)
        {
            throw new NotImplementedException();
        }

        public double Yas(int a)
        {
            throw new NotImplementedException();
        }
    }



}
