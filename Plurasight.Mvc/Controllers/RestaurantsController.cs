﻿using Microsoft.Ajax.Utilities;
using Plurasight.CommonLibraries.Models;
using Plurasight.CommonLibraries.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Plurasight.Mvc.Controllers
{
    public class RestaurantsController : Controller
    {
        // GET: Restaurants
        private readonly IRestaurantData db;
        public RestaurantsController(IRestaurantData db)
        {
            this.db = db;
        }
        public ActionResult Index()
        {
            var model = db.GetAll();
            return View(model);
        }

        public ActionResult Details(int id)
        {
            var model = db.Get(id);
            if (model == null) 
            {
                return View("NotFound");
            }
            return View(model);
        }
        
        [HttpGet]
        public ActionResult Create() 
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Restaurant restaurant)
        {
            if (ModelState.IsValid) 
            {
                db.Add(restaurant);
                return RedirectToAction("Details", new {id = restaurant.Id});
            }
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id) 
        {
            var model = db.Get(id);
            if (model == null) 
            {
                return View("NotFound");
            }
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Restaurant restaurant) 
        {
            if (ModelState.IsValid) 
            {
                db.Update(restaurant);
                return RedirectToAction("Details", new { id = restaurant.Id });
            }
            return View(restaurant);
        }
        public ActionResult Delete() 
        {
            return View();
        }
    }
}