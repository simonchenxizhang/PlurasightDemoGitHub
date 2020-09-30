using Plurasight.CommonLibraries.Models;
using Plurasight.CommonLibraries.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Plurasight.Mvc.Controllers
{
    public class HomeController : Controller
    {
        IRestaurantData db;

        public HomeController()
        {
            db = new InMemoryRestaurantData();
        }

        public ActionResult Index()
        {
            var model = db.GetAll();
            return View(model);
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

        [HttpPost]
        public ActionResult Subscribe(SubscribeModel model)
        {
            if (ModelState.IsValid)
            {
                //TODO: SubscribeUser(model.Email);
            }

            return View("Index", model);
        }
    }
}