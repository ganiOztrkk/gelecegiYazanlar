using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovPrinciple_RentalTask
{
    public class SedanCarReservation : BaseCarReservation
    {
        public SedanCarReservation(CarCustomer customer) : base(customer)
        {
        }
    }
}
