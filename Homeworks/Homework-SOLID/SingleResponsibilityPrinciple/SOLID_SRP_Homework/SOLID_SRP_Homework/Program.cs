// SOLID Prensiplerinden Single Responsibility Principle için örnek proje

// Urun ekle çıkar işlemleri çalışan arayüzü diye ayrı bir class oluşturulup orada tanımlanabilir.
// kullanıcı arayüzü sadece sepet işlemlerine erişebilir.
// prensibe uygun kod yazıldığı için müdahaleler ve değişiklikler çok kolaydır.

using SOLID_SRP_Homework;

KullaniciArayuzu kullanici = new KullaniciArayuzu();

kullanici.UrunEkle(new Urun(){Adi = "Domates"});
kullanici.UrunEkle(new Urun(){Adi = "Patates"});
kullanici.UrunEkle(new Urun(){Adi = "Soğan"});

foreach (var item in kullanici.UrunListele())
{
    kullanici.SepeteEkle(item);
}

kullanici.SiparisVer();

foreach (var urunler in kullanici.SepetListele())
{
    Console.WriteLine($"Sepetinizdeki ürünler {urunler.Adi}");
}