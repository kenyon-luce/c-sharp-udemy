using System;
using System.Web.Mvc;
using c__exercises.Models;

namespace c__exercises.Controllers
{
    public class MoviesController : Controller
    {
        //GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie { Name = "Shrek!"};

            return View(movie);
        }
    }
}