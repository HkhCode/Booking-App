using Booking_App.Models;
namespace Booking_App.Data
{
    public class members_data
    {
        private static List<member> members = new List<member>
        {
            new member{Id =1 , Name = "Hosein" , Booked_place = "Meeting Room"},
            new member {Id=2 , Name = "Niam" , Booked_place = "Bed Room"},
            new member {Id=3 , Name = "Mahdi" , Booked_place = "Kitchen"},
            new member {Id=4 , Name = "Ahmad" , Booked_place = "Lunch Hall"}
        };
        public static IEnumerable<member> return_member()
        {
            return members;
        }
        public static void Add_member(member _member)
        {
            members.Add(_member);
        }
        public static void Remove_member(member _member)
        {
            members.Remove(_member);
        }
    }
}
