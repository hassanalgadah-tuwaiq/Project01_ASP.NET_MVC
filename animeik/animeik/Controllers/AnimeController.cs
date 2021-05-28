using System;
using System.Collections.Generic;
using animeik.Models;
using Microsoft.AspNetCore.Mvc;

namespace animeik.Controllers
{
    public class AnimeController : Controller
    {
        // GET
        public static List<Anime> animelist = new List<Anime>()
        {
            new Anime(1,"this is  of the first assssssssssssssssssssssnime ", "https://myanimelist.net/anime/47778/Kimetsu_no_Yaiba__Yuukaku-hen",
                "https://cdn.myanimelist.net/images/anime/1257/113753.jpg?s=8395309ce3fedbed1c91674f472c08a5", "TV", 23,
                "ams", "end date 20230",9),
            new Anime(2,"this is title", "url",
                "https://cdn.myanimelist.net/images/anime/1257/113753.jpg?s=8395309ce3fedbed1c91674f472c08a5", "TV", 23,
                "ams", "end date 20230",9),
            new Anime(1,"this is  of the first anime ", "url",
                "https://cdn.myanimelist.net/images/anime/1257/113753.jpg?s=8395309ce3fedbed1c91674f472c08a5", "TV", 23,
                "ams", "end date 20230",9),
            new Anime(2,"this is title", "url",
                "https://cdn.myanimelist.net/images/anime/1257/113753.jpg?s=8395309ce3fedbed1c91674f472c08a5", "TV", 23,
                "ams", "end date 20230",9),
            new Anime(1,"this is  of the first anime ", "url",
                "https://cdn.myanimelist.net/images/anime/1257/113753.jpg?s=8395309ce3fedbed1c91674f472c08a5", "TV", 23,
                "ams", "end date 20230",9),
            new Anime(2,"this is title", "url",
                "https://cdn.myanimelist.net/images/anime/1257/113753.jpg?s=8395309ce3fedbed1c91674f472c08a5", "TV", 23,
                "ams", "end date 20230",9),
            new Anime(1,"this is  of the first anime ", "url",
                "https://cdn.myanimelist.net/images/anime/1257/113753.jpg?s=8395309ce3fedbed1c91674f472c08a5", "TV", 23,
                "ams", "end date 20230",9),
            new Anime(2,"this is title", "url",
                "https://cdn.myanimelist.net/images/anime/1257/113753.jpg?s=8395309ce3fedbed1c91674f472c08a5", "TV", 23,
                "ams", "end date 20230",9)
        };

        public IActionResult Index(int id)
        {
            ViewData["list"] = animelist;
            if (id != 0)
            {
                // ViewData["list"] = users.find(i => i.id == id).Fav;
            }
            return View();
        }

        public IActionResult Details(int id)
        {
            ViewData["anime"] = animelist.Find(a => a.id == id);
            return View();
        }
        public IActionResult Search(string animeName)
        {
            Console.WriteLine(animeName);
            return View();
        }
 
    }
}