using MvcMusicStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMusicStore.Controllers
{
    public class StoreController : Controller
    {
        ApplicationDbContext storeDB = new ApplicationDbContext();
        // GET: Store
        public ActionResult Index()
        {
            var genres = storeDB.genres.ToList();
            return View(genres);
        }

        public ActionResult Browse(string genre)
        {
            //var genreModel = new Genre { Name = genre };
            //return View(genreModel);
            var genreModel = storeDB.genres.Include("Albums")
        .Single(g => g.Name == genre);

            return View(genreModel);
        }

        public ActionResult Details(int id)
        {
            var album = storeDB.albums.Find(id);

            return View(album);
        }

        //
        // GET: /Store/GenreMenu
        [ChildActionOnly]
        public ActionResult GenreMenu()
        {
            var genres = storeDB.genres.ToList();
            return PartialView(genres);
        }
    }
}