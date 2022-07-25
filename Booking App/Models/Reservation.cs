using Booking_App.Models;
using System.ComponentModel.DataAnnotations;

namespace Booking_App.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        [Display(Name = "Customer")]
        public string Reservar_Name { get; set; }
        public Locations location { get; set; }
    }
}
