namespace SOLID_SRP_Homework
{
    public class Sepet // sadece sepet işlemleri yapılıyor
    {
        private readonly List<Urun> _urunler;

        public Sepet()
        {
            _urunler = new List<Urun>();
        }

        public void UrunEkle(Urun urun)
        {
            _urunler.Add(urun);
        }

        public void UrunCikar(Urun urun)
        {
            _urunler.Remove(urun);
        }

        public List<Urun> UrunListele()
        {
            return _urunler;
        }
    }
}
