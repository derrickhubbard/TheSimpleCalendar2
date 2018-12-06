using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TheSimpleCalendar2018.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Input = hour < 12 ? "What is your event time Morning" : "Afternoon";
            return View();
        }
    }
}