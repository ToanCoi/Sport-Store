using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SportStore.Models;

namespace SportStore.Controllers
{
    public class HomeController : Controller
    {
        public EFDBContext db = new EFDBContext();
        public ActionResult Index()
        {
            ViewBag.Sports = db.Sports.ToList();
            ViewBag.LastSport = db.Sports.ToList().Last();
            ViewBag.Menus = db.Sports.ToList();
            ViewBag.Submenus = db.Categories.ToList();
            ViewBag.Home = true;
            return View();
        }   

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}