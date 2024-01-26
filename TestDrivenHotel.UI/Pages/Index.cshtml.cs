using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TestDrivenHotel.BLL;
using TestDrivenHotel.DAL;

namespace TestDrivenHotel.UI.Pages
{
    public class IndexModel : PageModel
    {
        private readonly HotelRoomsDB _db;
        private readonly BookingManager _bookingManager;
        

        public List<HotelRoom> AllRooms { get; set; } = new();
        [BindProperty]
        public int SelectedRoomNumber { get; set; }

        [BindProperty]
        public int GuestId { get; set; }

        public IndexModel(HotelRoomsDB dB, BookingManager bookingManager)
        {
            _db = dB;
            _bookingManager = bookingManager;
        }

        public void OnGet()
        {
            AllRooms = _db.HotelRooms.ToList();
        }

        public IActionResult OnPostBook(int roomId)
        {
            // Call the BookingManager to handle the booking logic
            if (_bookingManager.BookRoom(roomId, GuestId)) // 0 is a placeholder for guestId, you might want to handle this differently
            {
                // Booking successful, you can redirect or perform other actions
                return RedirectToPage("Details");
            }
            else
            {
                // Booking failed, handle accordingly (e.g., show a message to the user)
                return RedirectToPage("Index");
            }
        }


    }        
}
