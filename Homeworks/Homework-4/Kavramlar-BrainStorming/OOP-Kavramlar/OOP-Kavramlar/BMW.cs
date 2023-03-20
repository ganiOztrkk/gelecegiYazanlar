using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Kavramlar
{
    public class BMW : Otomobil // bmw sınıfından üretilen bir nesne icerisinde otomobile ait her metodu ve prop. bulunduracaktır. buna ek olarak kendi benliginde bulunanlara da erisebilecektir.
    {
        public void DriftModu()
        {
            Console.WriteLine("Drift Modu Aktif.");
        }

        public override void Vergilendir()
        {
            Console.WriteLine("Acayip Vergilendirildi.");
        }
    }
}
