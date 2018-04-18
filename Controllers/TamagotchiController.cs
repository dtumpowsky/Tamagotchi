using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Tamagotchi.Models;
using System;

namespace Tamagotchi.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            List<TamaName> yourTamagotchi = TamaName.GetAll();
            return View(yourTamagotchi);
        }

        [HttpGet("/items/{id}")]
        public ActionResult Details(int id)
        {
            TamaName Tamagotchi = TamaName.Find(id);
            return View(Tamagotchi);
        }

        [HttpGet("/tamagotchi/new")]
        public ActionResult CreateForm()
        {
            return View();
        }

        [HttpPost("/tamagotchi")]
        public ActionResult Create()
        {
          Attributes newAttribute = new Attributes(1, 1, 1);
          TamaName newTama = new TamaName(Request.Form["new-name"], newAttribute);

          List<TamaName> allTama = TamaName.GetAll();
          return View("Index", allTama);
        }
    }
}
