using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterStrike
{
    public class Silah
    {
        public int Menzil { get; set; }
        public int Hasar { get; set; }
        public int Agirlik { get; set; }
        public string Ad { get; set; }

        public void Saldir()
        {
            Console.WriteLine($"Dusmana Saldiriliyor,{Ad}, {Hasar} kadar hasar verildi.");
        }
    }

    public class AtesliSilah : Silah
    {
        public int MermiSayisi { get; set; }
        public int MaksimumSarjor { get; set; }
        public double SekmeOrani { get; set; }

        public virtual void SarjorDegistir()
        {
            Console.WriteLine("Tabanca Reload Görseli Oynatıldı.");
        }
    }

    public class Tabanca : AtesliSilah
    {
        public bool SusturucuVarMi { get; set; }
    }

    public class DesertEagle : Tabanca
    {
        public DesertEagle()
        {
            Ad = "DesertEagle";
            Hasar = 20;
        }
        public int Sayisi { get; set; }
    }

    public class Tufek : AtesliSilah
    {
        public bool DurbunVarMi { get; set; }
    }

    public class Ak47 : Tufek
    {
        public Ak47()
        {
            Ad = "AK47";
            Hasar = 40;
        }
        public string SarjorTipi { get; set; }
        public override void SarjorDegistir()
        {
            Console.WriteLine("AK-47 Reload Gorseli Oynatıldı.");
        }
    }

}
