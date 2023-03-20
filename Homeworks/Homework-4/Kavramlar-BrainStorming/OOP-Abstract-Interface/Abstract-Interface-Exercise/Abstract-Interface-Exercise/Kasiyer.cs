namespace Abstract_Interface_Exercise;

public class Kasiyer : Calisan, ICalisanKiyafet
{
    public string KiyafetRengi { get; set; } = "Siyah-Beyaz";
    public string KiyafetTürü { get; set; } = "Kasiyer Kıyafeti";

    public void OdemeAl()
    {
        Console.WriteLine("Kasiyer Odeme Alir.");
    }

    public void MusteriyiUgurla()
    {
        Console.WriteLine("Kasiyer: Yine Bekleriz.");
    }
}