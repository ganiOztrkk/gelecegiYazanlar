using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_SRP_Homework
{
    public class Siparis // sipariş verme işlemi gerçekleştirilir.
    {
        private readonly UrunYonetimi _urunYonetimi;
        private readonly Sepet _sepet;
        public Siparis(UrunYonetimi urunYonetimi, Sepet sepet)
        {
            _urunYonetimi = urunYonetimi;
            _sepet = sepet;
        }

        public void SiparisVer()
        {
            List<Urun> urunListesi = _sepet.UrunListele();

            foreach (Urun item in urunListesi)
            {
                if (!_urunYonetimi.UrunListele().Contains(item))
                    Console.WriteLine("Sepetinizde bulunan bir ürün artık mevcut değil.");
            }

            Console.WriteLine("Sipariş tamamlandı.");
            // İlgili metotla ödeme işlemi gerçekleştirilir.

            // Sipariş tamamlanır.
        }
    }
}
