using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDrivenHotel.DAL
{
    public class HotelRoomsDB : DbContext
    {
        private int _nextGuestId = 1;
        public HotelRoomsDB(DbContextOptions<HotelRoomsDB> options) :base(options)
        {
            
            
        }

        // Lista med alla tillgängliga rum
        public DbSet<HotelRoom> HotelRooms { get; set; }
        // Lista med alla bokade rum
        public DbSet<BookedRoom> BookedRooms { get; set; }
        // Lista med alla gäster
        public DbSet<Guests> Guests { get; set; }
        // Function to get the next available guest ID, test this.
        public int GetNextGuestId()
        {
            return _nextGuestId++;
        }
        public class BookedRoom
        {
            public int RoomNumber { get; set; }
            public int GuestId { get; set; }

            // Navigation properties
            public HotelRoom? Room { get; set; }
            public Guests? Guest { get; set; }
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<BookedRoom>()
                .HasKey(br => new { br.RoomNumber, br.GuestId });

            modelBuilder.Entity<BookedRoom>()
                .HasOne(br => br.Room)
                .WithMany()
                .HasForeignKey(br => br.RoomNumber);

            modelBuilder.Entity<BookedRoom>()
                .HasOne(br => br.Guest)
                .WithMany()
                .HasForeignKey(br => br.GuestId);

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<HotelRoom>().HasData(new HotelRoom
            {
                
                RoomNumber = 1,
                NumberOfBeds = 1,
                PricePerNight = 1000,
                IsBooked = false,
            },
            new HotelRoom()
            {
                
                RoomNumber = 2,
                NumberOfBeds = 2,
                PricePerNight = 2000,
                IsBooked = false,
            },
            new HotelRoom()
            {
                
                RoomNumber = 3,
                NumberOfBeds = 3,
                PricePerNight = 3000,
                IsBooked = false,
            },
            new HotelRoom
            {   
                
                RoomNumber = 4,
                NumberOfBeds = 4,
                PricePerNight = 4000,
                IsBooked = false,
            },
            new HotelRoom
            {   
                
                RoomNumber = 5,
                NumberOfBeds = 5,
                PricePerNight = 5000,
                IsBooked = false,
            },
            new HotelRoom
            {
                
                RoomNumber = 6,
                NumberOfBeds = 6,
                PricePerNight = 6000,
                IsBooked = false,
            },
            new HotelRoom
            {   

                RoomNumber = 7,
                NumberOfBeds = 7,
                PricePerNight = 7000,
                IsBooked = false,
            },
            new HotelRoom
            {   

                RoomNumber = 8,
                NumberOfBeds = 8,
                PricePerNight = 8000,
                IsBooked = false,
            },
            new HotelRoom
            {   

                RoomNumber = 9,
                NumberOfBeds = 9,
                PricePerNight = 9000,
                IsBooked = false,
            },
            new HotelRoom
            {
                
                RoomNumber = 10,
                NumberOfBeds = 10,
                PricePerNight = 10000,
                IsBooked = false
            });

        }
    }
}