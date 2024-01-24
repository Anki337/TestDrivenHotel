using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDrivenHotel.DAL
{
    public class HotelRoomsDB
    {


        // Lista med alla tillgängliga rum
        public List<HotelRoom> HotelRooms { get; set; }
        // Lista med alla gäster
        public List<Guests> Guests { get; set; }
        // Lista med alla bokade rum
        public Dictionary<Guests, HotelRoom> BookedRooms { get; set; }

        public HotelRoomsDB()
        {
            HotelRooms = new List<HotelRoom>();
            Guests = new List<Guests>();
            BookedRooms = new Dictionary<Guests, HotelRoom>();

            AddInitialRooms();
        }
       
        private void AddInitialRooms()
        {
            HotelRooms.Add(new HotelRoom
            {
                RoomNumber = 1,
                NumberOfBeds = 1,
                PricePerNight = 1000,
                IsBooked = false
            });
            HotelRooms.Add(new HotelRoom
            {
                RoomNumber = 2,
                NumberOfBeds = 2,
                PricePerNight = 2000,
                IsBooked = false
            });
            HotelRooms.Add(new HotelRoom
            {
                RoomNumber = 3,
                NumberOfBeds = 3,
                PricePerNight = 3000,
                IsBooked = false
            });
            HotelRooms.Add(new HotelRoom
            {
                RoomNumber = 4,
                NumberOfBeds = 4,
                PricePerNight = 4000,
                IsBooked = false
            });
            HotelRooms.Add(new HotelRoom
            {
                RoomNumber = 5,
                NumberOfBeds = 5,
                PricePerNight = 5000,
                IsBooked = false
            });
            HotelRooms.Add(new HotelRoom
            {
                RoomNumber = 6,
                NumberOfBeds = 6,
                PricePerNight = 6000,
                IsBooked = false
            });
            HotelRooms.Add(new HotelRoom
            {
                RoomNumber = 7,
                NumberOfBeds = 7,
                PricePerNight = 7000,
                IsBooked = false
            });
            HotelRooms.Add(new HotelRoom
            {
                RoomNumber = 8,
                NumberOfBeds = 8,
                PricePerNight = 8000,
                IsBooked = false
            });
            HotelRooms.Add(new HotelRoom
            {
                RoomNumber = 9,
                NumberOfBeds = 9,
                PricePerNight = 9000,
                IsBooked = false
            });
            HotelRooms.Add(new HotelRoom
            {
                RoomNumber = 10,
                NumberOfBeds = 10,
                PricePerNight = 10000,
                IsBooked = false
            });





        }






    }





}