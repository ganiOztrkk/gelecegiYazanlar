namespace SOLID_SRP_Homework;

public class UrunYonetimi // urunlerin yönetildiği sınıf sadece ekle sil listele işlemi yapıyor
{
    private readonly List<Urun> _urunler;

    public UrunYonetimi()
    {
        _urunler = new List<Urun>();
    }

    public void UrunEkle(Urun urun)
    {
        _urunler.Add(urun);
    }

    public void UrunSil(Urun urun)
    {
        _urunler.Remove(urun);
    }
    
    public List<Urun> UrunListele()
    {
        return _urunler;
    }
}