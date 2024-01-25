using TestDrivenHotel.DAL;

namespace TestDrivenHotel.BLL
{
    public class BookingManager
    {
        // This class is responsible for handling the booking logic to the db.
        private readonly HotelRoomsDB _db;

        public BookingManager(HotelRoomsDB db)
        {
            _db = db;
        }

        // Function to book a room and add the room and guest to a dictionary
        // (Use RoomNumber + GuestId, this should also remove the room from the list of available rooms and set IsBooked to true).

        // Function for booking a room
        public bool BookRoom(int roomNumber, int? guestId)
        {
            // If guestId is null, assign it a default value of 1 and auto-increment for the next time
            guestId ??= _db.GetNextGuestId();

            // Check if the room is available
            var room = _db.HotelRooms.FirstOrDefault(r => r.RoomNumber == roomNumber && !r.IsBooked);

            if (room != null)
            {
                // Add the room and guest to the dictionary
                _db.BookedRooms.Add((roomNumber, guestId.Value), room);

                // Update the room status
                room.IsBooked = true;

                // Remove the room from the list of available rooms
                _db.HotelRooms.Remove(room);

                // Save changes to the database
                _db.SaveChanges();

                return true; // Booking successful
            }

            return false; // Booking failed
        }
        // Funktion för att boka rum och lägga till rum och gäst i en dictionary (Använd RoomNumber + GuestId, denna skall även ta bort rummet från listan med tillgängliga rum och ändra IsBooked till true.
        // Funktion för att avboka rum och ta bort rum och gäst från dictionary, denna skall även ta bort rummet från listan med bokade rum och lägga till det i listan med tillgängliga rum.
        // Funktion för att visa alla bokade rum och gäster via att loopa igenom dictionary som innehåller alla bokade rum och gäster.
    }
}
