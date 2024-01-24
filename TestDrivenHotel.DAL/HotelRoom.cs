using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDrivenHotel.DAL
{
    public class HotelRoom
    {
        // Properties för HotelRoom
        [Key]
        public int RoomNumber { get; set; }
        public int NumberOfBeds { get; set; }
        public int PricePerNight { get; set; }
        public bool IsBooked { get; set; }
                
    }
}
