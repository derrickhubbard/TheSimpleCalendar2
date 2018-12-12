using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TheSimpleCalendar2018.Models;

namespace TheSimpleCalendar2018.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Input = hour < 12 ? "Welcome to " : "Afternoon";
            return View();
        }
        [HttpGet]
        public ViewResult ProfileForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult ProfileForm(ProflieResponse proflieResponse)
        {
            return View("Thanks you for your entry", proflieResponse);
        }
    }
}