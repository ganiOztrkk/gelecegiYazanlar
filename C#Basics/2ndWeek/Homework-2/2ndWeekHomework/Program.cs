/*
 * 1-EN AZ 6 karakter olacak
 * 2-Sadece harf ya da sadece sayı ise ZAYIF
 * 3-Hem harf hem sayı ise ORTA
 * 4-Hem sayı hem harf hem de işaret varsa GÜÇLÜ DESİN.
 *
 * !!! EN ÖNEMLİSİ HAYVAN GİBİ EGLENİLSİN !!!
 */


//şifre min 6 karakterden oluşana kadar input almaya devam ediyoruz
var password = string.Empty;
while (password.Length < 6)
{
    Console.WriteLine("Enter a password - Minimum 6 Digit");
    password = Console.ReadLine();
    if (password.Length >= 6)
        break;
    else
        continue;
}

// char metotlarından faydalanabilmek icin char list olusturdum
List<char> characters = new List<char>();
foreach (var item in password)
    characters.Add(item);

// gercekten asagıdaki algoritmayı yazabildigim an zevkten delirdim. son maddenin hakkını verdigimi dusunuyorum.
int isNumber = 0;
int isChar = 0;
foreach (var item in characters)
{
    if (char.IsNumber(item))
        isNumber++;
    if (char.IsLetter(item))
        isChar++;
}

Console.WriteLine(isNumber == characters.Count ? "Weak Password": isChar == characters.Count ? "Weak Password" : (isChar+isNumber) == characters.Count ? "Avarage Password" : "Strong Password, Don't Forget It.");