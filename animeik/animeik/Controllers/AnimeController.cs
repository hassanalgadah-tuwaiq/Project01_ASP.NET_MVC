using System;
using System.Collections.Generic;
using animeik.Models;
using Microsoft.AspNetCore.Mvc;

namespace animeik.Controllers
{
    public class AnimeController : Controller
    {
        // GET
        public IActionResult Index(int id)
        {
            ViewData["list"] = Utilities.animelist;
            if (id != 0)
            {
                ViewData["list"] = Utilities.users.Find(i => i.id == id).Fav;
            }
            return View();
        }

        public IActionResult Details(int id)
        {
            ViewData["anime"] = Utilities.animelist.Find(a => a.id == id);
            return View();
        }
        public IActionResult Search(string animeName)
        {
            Console.WriteLine(animeName);
            return View();
        }
 
    }
}