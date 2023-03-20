namespace Abstract_Interface_Exercise;

public class Garson : Calisan , ICalisanKiyafet
{
    public string KiyafetRengi { get; set; } = "Siyah";
    public string KiyafetTürü { get; set; } = "Garson Kıyafeti";

    public void SiparisAl()
    {
        Console.WriteLine("Garson: Karar verdik mi?");
    }

    public virtual void ServisYap() // verilen siparise gore metodu degistirmek istiyorum. 
    {
        Console.WriteLine("Garson: Siparisiniz Hazır. Afiyet Olsun");
    }

    public void MasayiTemizle()
    {
        Console.WriteLine("Garson: Devam Ediyor muydunuz?");
        Console.WriteLine("Garson: Çay ister misiniz?");
        Console.WriteLine("Garson Masayı Temizler.");
    }
}