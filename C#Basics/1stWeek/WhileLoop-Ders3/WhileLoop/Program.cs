//çorba kaynayıncaya kadar karıştırmak...

//sayı bulmaca oyunu: Bilgisayar hafızada bir sayı tutacak. kullanıcı bu sayıyı tahmin etmeye çalışacak. Kullanıcı doğru tahminde bulunana kadar tahminde bulunmaya devam edecek.

//while loop = mantıksal bir koşul, eğer bu mantıksal koşul devam ediyorsa devam et, sonu belli değildir talep edilene ne zaman erişicez belli degildir. erişene kadar devam et deriz. bazen belli de olabilir bu kesin bir ozellik degildir. genelde sonu belli degilse tercih edilir.

Random random = new Random();

int puzzle = random.Next(0,100);
bool isWin = false;
int sayac = 1;

while (!isWin) // iswin false oldugu surece yani true degilse dedik basına unlem koyarak
{
    Console.WriteLine($"{sayac} - lutfen tahminde bulunun:");
    int guess = Convert.ToInt16(Console.ReadLine());
    if (guess < puzzle)
    {
        Console.WriteLine("yukarı!");
        sayac++;
    }
    else if (guess > puzzle)
    {
        Console.WriteLine("asagı");
        sayac++;
    }
    else
    {
        isWin = true;
    }
}

Console.WriteLine("bildin !");