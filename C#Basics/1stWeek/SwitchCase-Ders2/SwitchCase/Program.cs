//switch case de bir kosul kontrol yontemidir. peki ne zaman switch case ne zaman if else

Console.WriteLine("bir şekil seçiniz (kare, daire, üçgen)!");
string geometry = Console.ReadLine();

if (geometry == "kare")
{
    Console.WriteLine("birim kenarın karesi");
}
else if (geometry == "daire")
{
    Console.WriteLine("yarı çapın karesi x pi");
}
else if (geometry == "üçgen")
{
    Console.WriteLine("taban * yükseklik / 2 ");
}

// iki durum tamamen aynı çıktıyı verir. fakat neden switch case durumunu tercih edelim. bunu en iyi break point gosterir. if blokları eger ücgen girdisi verirsek en ustten kosulları kontrol etmeye baslar. üçgen kosulunu bulana kadar kosulları kontrol ederek asagı iner

//switch case ise üçgene gider isini yapar cıkar. gerisine bakmaz bile.  
switch (geometry)
{
    case "kare":
        Console.WriteLine("birim kenarın karesi");
        break;
    case "daire":
        Console.WriteLine("yarı çapın karesi x pi");
        break;
    case "üçgen":
        Console.WriteLine("taban * yükseklik / 2 ");
        break;
    default:
        break;
}
