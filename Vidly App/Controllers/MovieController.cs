﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Vidly_App.Data;
using Vidly_App.Models;
using Vidly_App.ViewModel;

namespace Vidly_App.Controllers
{
    public class MovieController : Controller
    {
        private ApplicationDbContext _context;

        public MovieController(ApplicationDbContext context)
        {
            _context = context;
        }
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
            //var movies = new List<Movie>
            //{
            //  new Movie { Name = "Shark", Id = 1 },
            //  new Movie {Name = "Wall e" , Id = 2}
            //};

            //var viewModel = new RandomMovieViewModel
            //{
            //    Movie = movies,
            //};

            //var movies = _context.Movies.Include(c => c.Genre);

            if(User.IsInRole("CanManageMovies"))
               return View("List");
            else
               return View("ReadOnlyView");


        }

        [Route("Movies/Details/{id}")]
        public ActionResult Details(int id)
        {
            var movie = _context.Movies.Include(c => c.Genre);


            foreach(var oneMovie in movie)
            {
                if(oneMovie.Id == id)
                {
                    return View(oneMovie);
                }
            }

             return NotFound();
        }

        [Route("Movies/Edit/{id}")]
        public ActionResult Edit(int id)
        {
            var movie = _context.Movies.SingleOrDefault(c => c.Id == id);

            if (movie == null)
                return NotFound();

            var viewModel = new MovieViewModel(movie)
            {
                Genres = _context.Genres.ToList()
            };

            return View("New", viewModel);
        }

        [Route("Movies/New")]
        public ActionResult New()
        {
            var Genre = _context.Genres;
            var viewModel = new MovieViewModel
            {
                Genres = Genre
            };

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("Movies/Create")]
        public ActionResult Create(Movie movie)
        {
            if(!ModelState.IsValid)
            {
                var viewModel = new MovieViewModel(movie)
                {
                    Id = movie.Id,
                    NumberInStock = movie.NumberInStock,
                    GenreId = movie.GenreId,
                    ReleasedDate = movie.ReleasedDate,
                    Name = movie.Name,
                    Genres = _context.Genres.ToList()
                };

                return View("New", viewModel);
            }
            if(movie.Id == 0)
                _context.Movies.Add(movie);
            else
            {
                var movieInDb = _context.Movies.Single(c => c.Id == movie.Id);
                movieInDb.Name = movie.Name;
                movieInDb.NumberInStock = movie.NumberInStock;
                movieInDb.ReleasedDate = movie.ReleasedDate;
                movieInDb.GenreId = movie.GenreId;
                
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Movie");
        }

        [Route("movies/released/{{year}}/{{month:regex(\\d{2}):range(1,12)}}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content($"{ year } / {month}");
        }
    }
}
