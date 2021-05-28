using System.Collections.Generic;
using animeik.Models;
using Microsoft.AspNetCore.Mvc;

namespace animeik.Controllers
{
    public class UsersController : Controller
    {
        // GET
        public static List<User> users = new List<User>()
        {
            new User(1, "hassan"),
            new User(2, "sara")
        };
        public IActionResult Index()
        {
            ViewData["users"] = users;
            return View();
        }

        public void addFav(int id,int animeId)
        {
             
            // users.Find(u => u.id == id).addToFav();
        }
    }
}