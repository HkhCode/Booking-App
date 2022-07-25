using Microsoft.AspNetCore.Mvc;
using Booking_App.Models;
using Booking_App.Controllers;
using Booking_App.Infrustructes;
using Booking_App.Data;
namespace Booking_App.Controllers
{
    public class InsertController : Controller
    {
        public ActionResult Index()
        {
            if (User_Access.Has_Access())
                return View();
            else
                return Redirect("Home/Login");
        }
        [HttpPost]
        public ActionResult Index(Reservation reserved)
        {
            int result = 0;
            foreach (var item in Reservation_data.getReservations())
            {
                if (item.location.Name == reserved.location.Name)
                {
                    result = 0;
                    break;
                }
                else
                {
                    result = 1;
                }
            }
            if (result == 1)
            {
                Reservation_data.addReservation(reserved);
                return Redirect("Home/Index");
            }
            else
            {
                return View("Error" , reserved);
            }
        }
        public IActionResult Edit()
        {
            if (User_Access.Has_Access())
                return View();
            else
                return Redirect("Home/Login");
        }
    }
}
