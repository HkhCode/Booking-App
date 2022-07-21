namespace Booking_App.Infrustructes
{
    public class User_Access
    {
        private static bool Access = false;
        public static void Give_Access()
        {
            Access = true;
        }

        public static void Deny_Access()
        {
            Access = false;
        }

        public static bool Has_Access()
        {
            return Access;
        }
    }
}
