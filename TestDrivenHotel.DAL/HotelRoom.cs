using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDrivenHotel.DAL
{
    public class HotelRoom
    {
        // Properties för HotelRoom
        public int RoomId { get; set; }
        public int RoomNumber { get; set; }
        public int NumberOfBeds { get; set; }
        public int PricePerNight { get; set; }
        public bool IsBooked { get; set; }
                
    }
}
