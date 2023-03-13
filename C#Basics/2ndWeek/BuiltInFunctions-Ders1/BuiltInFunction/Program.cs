//hazır fonksiyonlar - tanımlı fonksiyonlar - builtinfunctions

string word = "Bilgisayar";

Console.WriteLine(word.ToUpper());
Console.WriteLine(word.ToLower());
Console.WriteLine(word.Substring(5));

//word yazıp . ekledikten sonra acılan pencerede tur icin tanımlanmıs hazır fonksiyonları, bu fonksiyonların üzerine gelindiginde ne ise yaradıgını, parametre olarak ne alması gerektigini ve geriye ne dondurdugunu goruruz.

Console.WriteLine(word.IndexOf('i'));

Console.WriteLine(word.IndexOf('k'));


Console.WriteLine("************");

int startIndex = 0;
while (word.IndexOf('i' , startIndex) != -1)
{
    int findingIndex = word.IndexOf('i', startIndex);
    startIndex = findingIndex + 1;
    Console.WriteLine($"i harfinin indexi: {findingIndex}");
}