using Booking_App.Models;
namespace Booking_App.Data
{
    public class Reservation_data
    {
        private static List<Reservation> reservations = new List<Reservation>()
        {
            new Reservation{Id=1 , Reservar_Name = "Hosein" , location = new Locations{Name = "Lecture Hall" , isReserved=true }},
            new Reservation{Id=2 , Reservar_Name = "Ahmad" , location = new Locations{Name = "Study Room" , isReserved = true }},
            new Reservation{Id=3 , Reservar_Name = "Reza" , location = new Locations{Name = "Rest Room" , isReserved=true }}
        };
        public static IEnumerable<Reservation> getReservations()
        {
            return reservations;
        }
        public static void addReservation(Reservation reserved)
        {
            reservations.Add(reserved);
        }
        public static bool removeReservation(Reservation reserved)
        {
            if (reservations.Contains(reserved))
            {
                reservations.Remove(reserved);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
