using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_SRP_Homework
{
    public class KullaniciArayuzu
    {
        private readonly UrunYonetimi _urunYonetimi;
        private readonly Sepet _sepet;
        private readonly Siparis _siparis;
        public KullaniciArayuzu()
        {
            _urunYonetimi = new UrunYonetimi();
            _sepet = new Sepet();
            _siparis = new Siparis(_urunYonetimi, _sepet);
        }

        public void UrunEkle(Urun urun)
        {
            _urunYonetimi.UrunEkle(urun);
        }

        public void UrunSil(Urun urun)
        {
            _urunYonetimi.UrunSil(urun);
        }


        public List<Urun> UrunListele()
        {
            return _urunYonetimi.UrunListele();
        }

        public void SepeteEkle(Urun urun)
        {
            _sepet.UrunEkle(urun);
        }

        public void SepettenCikar(Urun urun)
        {
            _sepet.UrunCikar(urun);
        }

        public List<Urun> SepetListele()
        {
            return _sepet.UrunListele();
        }

        public void SiparisVer()
        {
            _siparis.SiparisVer();
        }
    }
}
