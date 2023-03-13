//temiz kod yazmak için, kod tekrarından kurtulmak icin, performanslı bir kod yazmak icin basvurdugumuz yontemdir.

/*
 * istenen formatı tanımlıyoruz
 * 1 - bir kelime koleksiyonu içinden rastgele bir kelime SEÇ.
 * 2 - seçilen keliyemi , "* * * *" şeklinde bir bulmacaya ÇEVİR.
 * 3 - kullanıcıdan bir harf İSTE.
 * 4 - girilen harfi kelimede ARA.
 * 5 - eğer girilen harf kelimede varsa "*" şeklini harfe ÇEVİR.
 * 6 - tüm yıldızlar açılana kadar bu işlem devam etsin...
 */

//fonksiyonları her zaman tekrarı onlemek icin degil bazen sadece duzen olusturdugu ve daha temiz durdugu icin dahi kullanabiliriz.
//fonksiyonlar ile bilgisayara bir emir verir ve bunu uygulatırız.

List<string> words = new List<string>{"Ayna"};
var choosingWord = GetRandomWord(words);
var puzzledWord = ConvertToPuzzle(choosingWord);
ShowOnScreen(puzzledWord);
string suggestedLetter = GetLetterFromUser();
if (IsLetterFoundInWord(choosingWord,suggestedLetter))
{
    puzzledWord = ReplaceStarWithLetter(choosingWord, puzzledWord, suggestedLetter);
    ShowOnScreen(puzzledWord);
}
else
{
    ShowOnScreen("Bir Hakkınız Yandı...");
}

string GetRandomWord(List<string> words)
{
    var index = new Random().Next(words.Count);
    return words[index];
}

string ConvertToPuzzle(string word)
{
    var puzzle = string.Empty;
    for (int i = 0; i < word.Length; i++)
    {
        puzzle += "* ";
    }
    return puzzle;
}

void ShowOnScreen(string word)
{
    Console.WriteLine(word);
}

string GetLetterFromUser()
{
    Console.WriteLine("Harf Giriniz");
    return Console.ReadLine();
}

bool IsLetterFoundInWord(string word, string letter)
{
    return word.ToLower().Contains(letter.ToLower());
}

string ReplaceStarWithLetter(string word, string puzzle, string letter)
{
    return "a**a";
}