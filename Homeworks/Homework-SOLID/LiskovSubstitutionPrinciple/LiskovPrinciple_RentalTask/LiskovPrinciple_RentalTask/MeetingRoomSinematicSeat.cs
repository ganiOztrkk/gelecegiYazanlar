using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovPrinciple_RentalTask
{
    public class MeetingRoomSinematicSeat : BaseMeetingRoomValidation
    {
        public MeetingRoomSinematicSeat(Customer customer) : base(customer)
        {
        }

        public override void ApplyReservation()
        {
            if (HowManyPeople <= 100 && CheckInDate != default && CheckOutDate != default && IsCleared== true && IsAvailable == true && RoomSeatType == IMeetingRoomValidation.RoomSeatTypes.Sinematic)
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
