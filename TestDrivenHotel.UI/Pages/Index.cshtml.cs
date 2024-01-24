using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TestDrivenHotel.DAL;

namespace TestDrivenHotel.UI.Pages
{
    public class IndexModel : PageModel
    {
        private readonly HotelRoomsDB _db;

        public List<HotelRoom> AllRooms { get; set; } = new();
        public IndexModel(HotelRoomsDB _dB)
        {
            this._db = _dB;
        }
        public void OnGet()
        {
            AllRooms = this._db.HotelRooms.ToList();
        }
    }
}
