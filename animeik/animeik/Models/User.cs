using System;
using System.Collections.Generic;

namespace animeik.Models
{
    public class User
    {
        public int id;
        public string username;
        public List<Anime> Fav;

        public User(int id, string user)
        {
            this.id = id;
            this.username = user;
            Fav = new List<Anime>();
        }


        public void addToFav(Anime anime)
        {
            Console.WriteLine("hello");
            Fav.Add(anime);
        }
    }
}