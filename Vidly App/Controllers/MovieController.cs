using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Vidly_App.Models;
using Vidly_App.ViewModel;

namespace Vidly_App.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movies/random
        [Route("Movies/Random")]
        public ActionResult Random()
        {
            var movies = new Movie { Name = "Shark" };

            var customer = new List<Customer>
            {
                new Customer {Name = "Customer 1"},
                new Customer {Name = "Customer 2"}
            };

            var viewModel = new RandomMovieViewModel
            {
                //Movie = movies,
                Customer = customer
            };
            return View(viewModel);
            //return Content("Hello World");
            //return HttpNotFound();
            //return new EmptyResult();
        }


        // GET: Movies
        [Route("Movies")]
        public ActionResult Index()
        {
            var movies = new List<Movie>
            {
              new Movie { Name = "Shark", Id = 1 },
              new Movie {Name = "Wall e" , Id = 2}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movies,
            };
            return View(viewModel);
        }

        [Route("Movies/Edit")]
        public ActionResult Edit(int id)
        {
            return Content($"id = {id}");
        }
        [Route("movies/released/{{year}}/{{month:regex(\\d{2}):range(1,12)}}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content($"{ year } / {month}");
        }
    }
}
