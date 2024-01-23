using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDrivenHotel.DAL
{
    public class HotelRoomsDB
    {
        // RUM - HotelRoomsDB
        // Lista med alla tillgängliga rum
        public List<HotelRoom> AvailableRooms { get; set; }
        // Lista med alla bokade rum
        public List<HotelRoom> BookedRooms { get; set; }
       
        // GÄSTER - HotelRoomsDB
        // Lista med alla gäster
        public List<Guests> Guests { get; set; }
        // Lista med alla bokade gäster
        public List<Guests> BookedGuests { get; set; }

        public HotelRoomsDB()
        {
            AvailableRooms = new List<HotelRoom>(); 
            BookedRooms = new List<HotelRoom>();
            Guests = new List<Guests>();
            BookedGuests = new List<Guests>();
        }






    }
}
