using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace LiskovPrinciple_RentalTask
{
    public abstract class Reservation
    {
        protected Reservation(Customer customer)
        {
            Customer = customer;
        }

        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set;}
        public Customer Customer{ get;}

        public virtual void ApplyReservation()
        {
            Console.WriteLine("Reservation Successful.");
        }

    }
}
