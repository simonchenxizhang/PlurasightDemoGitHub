using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Plurasight.CommonLibraries.Models;

namespace Plurasight.Mvc.Controllers
{
    public class GreetingController : Controller
    {
        // GET: Greeting
        public ActionResult Index(string name)
        {
            var model = new GreetingViewModel
            {
                Message = ConfigurationManager.AppSettings["message"],
                Name = name ?? "no name" 
            };          
            return View(model);
        }
    }
}