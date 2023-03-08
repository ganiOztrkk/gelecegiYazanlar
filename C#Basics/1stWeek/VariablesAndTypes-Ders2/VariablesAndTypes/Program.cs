/*
 *sayısal veri tipleri
 *-tam sayı
 *-ondalıklı sayı
 *
 *
 *metinsel veri tipler
 *
 *mantıksal veri tipler
 *
 */

byte enKucuk = 255;
sbyte eksiOlabilenByte = - 128;
short onaltiBit= 32767;
ushort sadecePozitif = 65535;
ulong bayagiBuyukTamSayi = ulong.MaxValue;

// 8 - 16 - 32 - 64  bitlik alanlar kaplarlar
//s - u - u - u

//c# daki evrensel ondalıklı deger double'dır. bu dilde ondalıklı bir deger gordugumuzde cok yuksek ihtimal bu sayı doubledır.

double pi = 3.14;
float piFloat = 3.14f;
decimal  piDecimal = 3.14000000000000000000000000000000000000000000000000000000000000000000m;


//sözel

char symbol = '!';
string name = "Türkay"; // string aslında char koleksiyonudur. Turkay

String a = "kelime";
string b = "kelime";
//ikisi arasındaki String .net e ait bir classtır. string ise c# diline ait bir keyworddur. buyuk harfli degiskenler .net e aittir. performanstan metoda her seyi aynıdır. tek fark biri .net e ait. System.Decimal gibi digeriyse dile ait keyworddur. decimal gibi.

//mantıksal - true false
bool olurMu = false;

byte x = 255;
byte y = 2;
checked // bu metot ile işlemin hata fırlatmasını sağlarız
{
	byte result = (byte)(x + y);
	Console.WriteLine(result); 
}
//bu islem casting islemidir. yani bir donusturme islemidir. elde ettigimiz result verisini tekrar byte turune cast etmis bulunuyoruz. bu durum hata fırlatmaz fakat tehlikelidir.
//cunku veri hafıza sınırı aşıldığı için result tekrar 0a donecek ve buradan eklemeye devam edecektir. yukarıdaki islemin sonucu 1 cıktısını verir.

//-------------------------------------------------------------

// kullanıcıdan veri girdisi yapılan herrrrrr sey stringtir. bu hangi arayuzde olursa olsun, kullanıcı veri giriyorsa bu veri stringtir bu bir standarttır.


