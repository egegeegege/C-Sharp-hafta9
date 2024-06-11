using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev
{
    public class Sepet
    {
        public List<Urun> urunler = new List<Urun>();

        public void SepeteEkle(Urun urun)
        {
            urunler.Add(urun);
        }


        public void ToplamTutar()
        {
            double toplamfiyat = 0;
            foreach (var urun in urunler)
            {
                toplamfiyat += urun.KdvHesapla();
            }

            foreach (var urun in urunler)
            {
                Console.WriteLine("Ürün adı: {0}", urun.UrunAdi);
            }

            Console.WriteLine("Sepetin toplam fiyatı: {0}",toplamfiyat);
        }
    }
}
