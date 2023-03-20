namespace OOP_Kavramlar;

public class Otomobil  // bu class otomobil nesnemizi üretirken belirleyeceğimiz özellikleri kendi içerisinde barındırıyor.
{
    private int _OtomobilGercekHiz;

    public int OtomobilHizi // otomobilimizin gerçek hızı private fieldda tutulacak. fakat eger 250den suratliyse bize 250donecek. degilse eger gercek deger neyse onu donecek.
    {
        get
        {
            if (_OtomobilGercekHiz >= 250)
            {
                return 250;
            }
            else
            {
                return _OtomobilGercekHiz;
            }
        }
        set
        {
            _OtomobilGercekHiz = value;
        }
    }


    public string? Ad { get; set; }
    public string? AracSinif { get; set; }
    public int Fiyat { get; set; }
    public double MotorGuc { get; set; }
    public string? YakitTip { get; set; }
    public string? CekisTip { get; set; }

    public void OtomobilCalistir()
    {
        Console.WriteLine("Otomobil Çalıştı.");
    }
    public void GazaBas()
    {
        Console.WriteLine("Otomobil İlerliyor.");
    }
    public void FreneBas()
    {
        Console.WriteLine("Otomobil Yavaşlıyor.");
    }

    public virtual void Vergilendir()
    {
        Console.WriteLine("Araca %18 Vergilendirildi.");
    }
}