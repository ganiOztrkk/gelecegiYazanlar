using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovPrinciple_RentalTask
{
    public class SingleRoom : BaseRoomReservation
    {
        /// <summary>
        /// Suppose to fill all the prop. to apply reservation
        /// </summary>
        /// <param name="customer"></param>
        public SingleRoom(Customer customer) : base(customer)
        {
        }

        public override void ApplyReservation()
        {
            if (this is { IsAvailable: true, IsCleared: true } && CheckInDate != default && CheckOutDate != default && HowManyPeople == 1)
            {
                base.ApplyReservation();
            }
            else
            {
                Console.WriteLine("Reservation Invalid");
            }
        }
    }
}
