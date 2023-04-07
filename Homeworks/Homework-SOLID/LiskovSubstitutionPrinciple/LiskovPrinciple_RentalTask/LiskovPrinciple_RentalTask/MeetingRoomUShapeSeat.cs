using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovPrinciple_RentalTask
{
    public class MeetingRoomUShapeSeat : BaseMeetingRoomValidation
    {
        public MeetingRoomUShapeSeat(Customer customer) : base(customer)
        {
        }
        public override void ApplyReservation()
        {
            if (HowManyPeople <= 500 && CheckInDate != default && CheckOutDate != default && IsCleared == true && IsAvailable == true && RoomSeatType == IMeetingRoomValidation.RoomSeatTypes.UShape)
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
