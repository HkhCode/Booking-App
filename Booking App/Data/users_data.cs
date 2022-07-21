using Booking_App.Models;
namespace Booking_App.Data
{
    public class users_data
    {
        private static List<user> Users = new List<user>
        {
            new user {username = "Hosein_khadem" , password="13811381kh"},
            new user {username = "Ahmad_Mortazavi" , password="2003__WP"},
            new user {username = "The_king_of_mountains" , password="NoBody_1122"}
        };
        public static IEnumerable<user> return_users()
        {
            return Users;
        }
        public static void Add_user(user _user)
        {
            Users.Add(_user);
        }
        public static void Remove_user(user _user)
        {
            Users.Remove(_user);
        }
    }
}
