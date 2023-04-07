/*
 * Kişilerin rezervasyon gerçekleştirdiği varlıklar var. Otel odası / Araç kiralama / Toplantı salonu 
 * Bu varlıkların kiralanmaları ya da rezerve edilmeleri tamamen farklı eylemler ve farklı validasyonlara sahipler.
 * Rezervasyon yapılabilir 2 ayrı toplantı salonumuz var.
 * Biri 100 diğeri 500 kişilik iki ayrı toplantı salonumuz var. 100 kişilik slaon U yerleşim tip 500 kişilik salon sinema konsept. 
 * Otel odası veya seminer salonu varlıklarından bir tanesi oluşturulmuş ve ona göre bir validasyon sistemi inşa edilmiş.
 * Varlıklarımız arasında miraslık bir durum yok fakat validasyon durumu var.
 */

using System.Threading.Channels;
using LiskovPrinciple_RentalTask;

RoomCustomer roomCustomer = new RoomCustomer(18,"gani","oz","4343");
RoomCustomer roomCustomer2 = new RoomCustomer(21,"ahmet","oz","4343");

MeetingRoomSinematicSeat meetingRoom = new MeetingRoomSinematicSeat(roomCustomer)
{
    CheckInDate = DateTime.Now,
    CheckOutDate = new DateTime(2023,05,15),
    HowManyPeople = 95,
    IsAvailable = true,
    IsCleared = true,
    RoomSeatType = IMeetingRoomValidation.RoomSeatTypes.Sinematic
};

meetingRoom.ApplyReservation();

MeetingRoomUShapeSeat meetingRoom2 = new MeetingRoomUShapeSeat(roomCustomer2)
{
    CheckInDate = DateTime.Now,
    CheckOutDate = new DateTime(2023, 05, 15),
    HowManyPeople = 95,
    IsAvailable = true,
    IsCleared = true,
    RoomSeatType = IMeetingRoomValidation.RoomSeatTypes.UShape
};

meetingRoom2.ApplyReservation();

CarCustomer aytenCarCustomer = new CarCustomer(22,true,"ayten","akbai","23423");

SedanCarReservation sedanCar = new SedanCarReservation(aytenCarCustomer)
{
    CheckInDate = DateTime.Now,
    CheckOutDate = new DateTime(2023, 05, 15),
    IsAvailable = true,
    IsCleared = true,
};

sedanCar.ApplyReservation();