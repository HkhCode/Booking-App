using Microsoft.AspNetCore.Mvc;
using Booking_App.Models;
using Booking_App.Infrustructes;
using Booking_App.Data;
namespace Booking_App.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (User_Access.Has_Access())
                return View(Reservation_data.getReservations());
            else
            {
                return RedirectToAction("Login");
            }
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(user _user)
        {
            int result = 0;
            foreach(var item in users_data.return_users())
            {
                if (item.username == _user.username && item.password == _user.password)
                {
                    result = 1;
                }
            }
            if (result == 1)
            {
                User_Access.Give_Access();
                return Redirect("/Home/Index");
            }
            else
            {
                return RedirectToAction("Login");
            }
        }
        public IActionResult SignOut()
        {
            User_Access.Deny_Access();
            return RedirectToAction("Login");
        }
    }
}
