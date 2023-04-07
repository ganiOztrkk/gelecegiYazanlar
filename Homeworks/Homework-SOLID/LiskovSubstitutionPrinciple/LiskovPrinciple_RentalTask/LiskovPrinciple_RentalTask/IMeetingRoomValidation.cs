using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovPrinciple_RentalTask
{
    public interface IMeetingRoomValidation
    {
        public bool IsCleared { get; set; }
        public bool IsAvailable { get; set; }
        public int HowManyPeople { get; set; }

        public RoomSeatTypes RoomSeatType { get; set; }
        public enum RoomSeatTypes
        {
            None,
            Sinematic,
            UShape
        }
    }
}
