using System.ComponentModel.DataAnnotations;

namespace Booking_App.Models
{
    public class Locations
    {
        [Display(Name = "Location")]
        public string Name { get; set; }
        public bool isReserved { get; set; }
    }
}
