using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Otomobil
    {
        int hiz = 0;
        bool arabaCalisiyorMu = false;

        public void Calistir()
        {
            arabaCalisiyorMu = true;
        }

        public void GazaBas()
        {
            hiz++;
        }

        public void Durdur()
        {
            hiz = 0;
        }
    }
}
