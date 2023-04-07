using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovPrinciple_RentalTask
{
    public interface IRoomValidation
    {
        public bool IsCleared { get; set; }
        public bool IsAvailable { get; set; }
        public int HowManyPeople { get; set; }

    }
}
