//array olusturmanın 2 yolu var
//1. yol: kaç elemanlık array olacağını biliyorum ama değerlerini bilmiyorum.
//string[] books = new string[8];

////2. yol: hem kaç elemandan oluşacağını biliyorum hem de değerleri biliyorum
//string[] seasons = new string[] {"ilkbahar","yaz","sonbahar","kış"};
//string[] seasons2 = {"ilkbahar","yaz","sonbahar","kış"};
//string[] seasonss3 = new[]{"ilkbahar","yaz","sonbahar","kış"};
//Console.WriteLine(seasons2[0]);

//Console.ReadLine();


//array icerigimizdeki total eleman sayımızı Array.Length seklinde buluruz.

//Console.WriteLine(seasons2.Length);


//iki basamaklı bir sayı girdisini yazılı hale çeviren bir program oluşturalım.
string[] onlarBasamagi = new[] { "on", "yirmi", "otuz", "kırk", "elli", "altmış", "yetmiş", "seksen", "doksan" };
string[] birlerBasamagi = new[] { "bir", "iki", "üç", "dört", "beş", "altı", "yedi", "sekiz", "dokuz" };

Console.WriteLine("iki basamaklı sayı giriniz");
int input = Convert.ToInt16(Console.ReadLine());

int birler = input % 10;
int onlar = input / 10;

if (birler == 0)
{
    Console.WriteLine(onlarBasamagi[onlar]);
}
else
{
    Console.WriteLine(onlarBasamagi[onlar-1] + birlerBasamagi[birler-1]);
}