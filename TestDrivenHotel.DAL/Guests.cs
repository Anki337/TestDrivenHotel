using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDrivenHotel.DAL
{

    public class Guests
    {
        [Key]  
        public  int  GuestId { get; set; }
        public  string? FirstName { get; set; }
        public  string? LastName { get; set; }
        
        
    }
}
