// var keywordunun amacı anonim veri tiplerini tutmaktır. bir veriyi karşılarken hangi veri gelecek bilmiyorsak buna keywordun karar vermesini saglarız. 

//Console.WriteLine("bir sayı giriniz");
//var sayi1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("bir sayı giriniz");
//var sayi2 = Convert.ToInt32(Console.ReadLine());
//int bolum = sayi2 / sayi2;
//Console.WriteLine($"islem sonucu {bolum}"); // basa koydugumuz isaret interpolition - cw scope icerisine degiskeni direkt olarak konumlamamızı saglar.

//peki ergenin biri çıkagelip sayı girecegi yere metin girerse ne olur ? 
//program patlar. bize bir exception fırlatır. kullanıcıya bu durumu yansıtmamak icin try catch kullanırız.
// aynı islemi patlamayacak sekilde tekrar yapalım

try
{
    Console.WriteLine("bir sayı giriniz");
    var sayi1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("bir sayı giriniz");
    var sayi2 = Convert.ToInt32(Console.ReadLine());
    int bolum = sayi2 / sayi2;
    Console.WriteLine($"islem sonucu {bolum}");
}
catch (FormatException)
{
    Console.WriteLine("ergen kardesim çıkıklık yapma.");
}
//bir işlem yapısında birden cok hata durumu olabilir. mesela işlemi 0 ile yapmak gibi. bu yuzden alt alta farklı catch blokları oluşturabiliriz.
catch (DivideByZeroException)
{
    Console.WriteLine("sıfıra sayı mı bölünür ergen kardesim");
}
//peki tahmin bile edemeyecegimiz bir hata olursa ne olacak ? cok genel ve hepsini kapsayan bir exception ile bunları yakalayabiliriz.
catch (Exception exception)
{
    Console.WriteLine($"kim bilir ne sacmalık yaptın ergen kardesim {exception.Message}");
}
//hatayı yakalık. peki hata alındı ama hata alınsa dahi her halukarda bir kod satırının calısmasını istiyorsak ? bu kez en son finally kullanıyoruz
finally
{
    Console.WriteLine("burası her halukarda calısacak.");
}

// goto fonksiyonunu gorsen de bilsen de kullanma. var ama bilmezden geliyoruz. goto bir kakadır! goto kullanma döngü kullan.