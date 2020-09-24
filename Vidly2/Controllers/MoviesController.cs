using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly2.Models;

namespace Vidly2.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };

            //  return View(movie);
            //return Content("hi");
            //return HttpNotFound();
            //return new EmptyResult();
            // return RedirectToAction("Index", "Home", new { page = 1, sortby = "name" });
            // var customers = new List<Customers>

            //{
            //     new Customers {name="customer 1" },
            //new Customers { name="customer 2"} };

            // var viewmodel = new RandomMovieViewModel
            // {
            //     Movie = movie,

            //     Customers = customers
            // };

            // return View(viewmodel);
            return View(movie);
        }



        public ActionResult Edit(int movieId)
        {

            return Content("movieId= " + movieId);

        }

        public ActionResult Index(int? pageindex, string sortby)
        {

            if (!pageindex.HasValue)
            {
                pageindex = 1;
            }

            if (string.IsNullOrWhiteSpace(sortby))
            {
                sortby = "name";
            }
            return Content(string.Format("pageindex={0}, sortby={0}", pageindex, sortby));
        }

        public ActionResult realesdate(int year, int month)
        {

            return Content(year + "/" + month);
        }

//test
    }
}
