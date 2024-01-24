using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDrivenHotel.Tests
{
    public class HotelRoomsDBTests
    {
        // Test för att se att Listan public List<HotelRoom> HotelRooms { get; set; } INTE är tom.
        [Fact]
        public void Test1()
        {
            
        }
        // Test för att se att Listan public List<Guests> Guests { get; set; } INTE är tom.
        [Fact] public void Test2()
        {

        }
        // Test för att kolla så att public Dictionary<Guests, HotelRoom> BookedRooms { get; set; } INTE är tom. (Denna skall köras varje gång en person lägger trycker på knappen "boka" på UI lagret och bokar ett rum.)
        [Fact]
        public void Test3()
        {
            
        }
        
    }
}
