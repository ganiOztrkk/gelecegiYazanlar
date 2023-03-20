// abstract, kendisinden nesne türetilemeyen, sadece baska sınıflara kalıtım verebilen sanal bir sınıftır. bu sınıf barındırdığı özellikleri kalıtım verir fakat kendi sınıf adıyla nesne oluşturulamaz.

// Interface, iplemente edildikleri sınıflara özellik kazandıran yapılardır.

// bu kavramları açıklamak için basit bir restoran örneklemi oluşturalım.

// bir restorana girdik ve burada sipariş verdikten sonra bize yemek servis edilecek. yemeği yiyeceğiz ve ödeme yapacağız.

// restorandaki insanlar 2ye ayrılıcak - müşteriler ve çalışanlar. peki bunları nasıl ayırt edicez ? kime sipariş vericez kime ödeme yapacağız ? 

// nesne oluşturulmasını istemediğimiz ve her iki insan tipini de kapsayan insan classımız elbetteki abstract class olacak. cunku sadece miras versin istiyoruz.

// siparis verecegimiz garsonları ilkkkk olarak nasıl ayırt ederiz ? kıyafetlerinden! oyleyse calisanin ozellikleri icerisinde kıyafeti bir nesne olarak tutucam ve bunu interface olarak olusturucam

using Abstract_Interface_Exercise;

Garson garson = new Garson()
{
    Ad = "Mehmet",
    Soyad = "Cengiz",
    Cinsiyet = "Erkek"
};
Kasiyer kasiyer = new Kasiyer()
{
    Ad = "Hilal",
    Soyad = "Yıldız",
    Cinsiyet = "Kadın"
};
Musteri musteri = new Musteri()
{
    Ad = "Mecnun",
    Soyad = "Gönül",
    Cinsiyet = "Erkek",
    Kiyafet = "Tisort - Kot"
};

musteri.MenuIste();
garson.SiparisAl();
musteri.SiparisVer();
garson.ServisYap();
musteri.YemekYe();
garson.MasayiTemizle();
musteri.HesapOde();
kasiyer.OdemeAl();
kasiyer.MusteriyiUgurla();
