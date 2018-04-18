using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Tomagotchi.Models;
using System;

namespace Tomagotchi.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            List<TomaName> yourTomagotchi = TomaName.GetAll();
            return View(yourTomagotchi);
        }

        [HttpGet("/items/{id}")]
        public ActionResult Details(int id)
        {
            TomaName tomagotchi = TomaName.Find(id);
            return View(tomagotchi);
        }

        [HttpGet("/tomagotchi/new")]
        public ActionResult CreateForm()
        {
            return View();
        }

        [HttpPost("/tomagotchi")]
        public ActionResult Create()
        {
          Attributes newAttribute = new Attributes(1, 1, 1);
          TomaName newToma = new TomaName(Request.Form["new-name"], newAttribute);

          List<TomaName> allToma = TomaName.GetAll();
          return View("Index", allToma);
        }
    }
}
