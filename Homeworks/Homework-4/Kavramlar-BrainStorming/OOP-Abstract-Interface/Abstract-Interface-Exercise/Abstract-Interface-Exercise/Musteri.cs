namespace Abstract_Interface_Exercise;

public class Musteri : Insan, IMusteri
{
    public string? Kiyafet { get; set; } = "Sivil Kiyafet";

    public void MenuIste()
    {
        Console.WriteLine("Menu Alabilir Miyim Lutfen?");
    }
    public void SiparisVer()
    {
        Console.WriteLine("Musteri Siparis Verdi.");
    }

    public virtual void YemekYe()
    {
        Console.WriteLine("Musteri Yemek Yer.");
    }

    public void HesapOde()
    {
        Console.WriteLine("Musteri Hesap Oder.");
    }
    
}