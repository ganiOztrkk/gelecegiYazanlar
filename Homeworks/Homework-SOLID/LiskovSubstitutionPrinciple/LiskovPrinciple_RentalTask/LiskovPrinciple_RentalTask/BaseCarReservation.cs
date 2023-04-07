using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LiskovPrinciple_RentalTask.IMeetingRoomValidation;

namespace LiskovPrinciple_RentalTask
{
    public abstract class BaseCarReservation : Reservation, ICarValidation
    {
        protected BaseCarReservation(CarCustomer customer) : base(customer)
        {
        }
        public override void ApplyReservation()
        {
            if (CheckInDate != default && CheckOutDate != default && IsCleared == true && IsAvailable == true)
            {
                base.ApplyReservation();
            }
            else
            {
                Console.WriteLine("Reservation Invalid");
            }
        }

        public bool IsCleared { get; set; }
        public bool IsAvailable { get; set; }
    }
}
