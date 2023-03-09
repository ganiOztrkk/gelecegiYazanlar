int[] numbers = {5,6,54,65,88,946,213,554,76,488};

for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
}

//odev
// bir array icinden en buyuk en kucuk toplam ve ortalama islemlerini her donguyle ayrı ayrı yap

string[] countries = {"Türkiye","Almanya","Kıbrıs","Hollanda","Amerika","Rusya","Çin","Sırbistan","Azerbaycan"};
Console.WriteLine("Bir Ülke Giriniz");

string country = Console.ReadLine();

bool isFind = false; // flag yontemi

for (int i = 0; i < countries.Length; i++)
{
    if (countries[i] == country)
    {
        isFind = true;
        break;
    }
}

Console.WriteLine(isFind ? "Listede Mevcut" : "Listede Yok");
