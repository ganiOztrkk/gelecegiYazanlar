// kod yazarken her turlu name alanını ingilizce olarak isimlendirin. açıklama satırları turkce olabilir. 

using System.Threading.Tasks.Sources;

Console.WriteLine("kullanıcı adı giriniz");
string name = Console.ReadLine();
Console.WriteLine("kullanıcı şifre giriniz");
string password = Console.ReadLine();


if (name == "gani" & password =="g1a2") // tek & işareti ile && işareti arasındaki fark, eger ifade tekse bu durumda birinci koşulu kontrol eder ve false donerse ikinciye ilerlemez direk false doner. eger ciftse iki ifadeyi de check eder. en az biri false ise false doner.
{
    Console.WriteLine("gani bey hosgeldiniz");
}
else if (name == "ayten" && password == "1122")
{
    Console.WriteLine("ayten hn hosgeldiniz");
}
else
{
    Console.WriteLine("tanımlanmamıs kisi");
}

//else if ile if arasındaki fark şudur. eger else if kullanılırsa bu durumda bu scope kendinden onceki if blogunun durumuna baglıdır. sadece if kullanılırsa bu durum sadece kendini baglar bir onceki if blogu bunu etkilemez.

Console.WriteLine("hangi aydasın ? ");
string month = Console.ReadLine();

if (month == "mart" || month == "nisan" || month == "mayıs") // yada operatorudur. herhangi biri true donerse durum truedir. 
{
    Console.WriteLine("ilkbahar mevsimindesiniz");
}

Console.WriteLine("bir sayı giriniz");
int number = Convert.ToInt16(Console.ReadLine());
string message = string.Empty; // bu "" denktir. ama daha temiz gozukur.

if (number % 2 == 0)
{
    message = "sayı çifttir";
}
else
{
    message = "tektir";
}

string message2 = number % 2 == 0 ? "sayı cifttir" : "sayı tektir.";
string greetings = DateTime.Now.Hour > 18 ? "iyi gunler" : "iyi aksamlar";

Console.WriteLine(message);
Console.WriteLine(message2);
Console.WriteLine(greetings);