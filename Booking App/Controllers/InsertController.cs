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
        public ActionResult Index(member _member)
        {
            members_data.Add_member(_member);
            return View("Index");
        }
    }
}
