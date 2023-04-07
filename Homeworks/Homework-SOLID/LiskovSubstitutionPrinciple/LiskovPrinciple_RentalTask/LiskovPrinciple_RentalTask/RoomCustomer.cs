using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovPrinciple_RentalTask
{
    public class RoomCustomer : Customer
    {
        public RoomCustomer(int customerAge, string customerName, string customerSurname, string customerPhone) : base(customerAge, customerName, customerSurname, customerPhone)
        {

        }
    }
    
}
