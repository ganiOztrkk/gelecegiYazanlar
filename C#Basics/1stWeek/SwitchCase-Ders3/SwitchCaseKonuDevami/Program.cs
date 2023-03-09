Console.WriteLine("bir sembol seciniz, sinek-maca-karo-kupa");

string symbol = Console.ReadLine();
switch (symbol)
{
    case "sinek":
    case "maca":
        Console.WriteLine("siyah");
        break;
    case "karo":
    case "kupa":
        Console.WriteLine("kirmizi");
        break;
    default:
        break;
}