using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vidly_App.Data;
using Vidly_App.Dtos;
using Vidly_App.Models;
using Vidly_App.ViewModel;

namespace Vidly_App.Controllers.Api
{

    [AllowAnonymous]
    [Route("api/[controller]")]
    [ApiController]
    public class RentalController : ControllerBase
    {
        private ApplicationDbContext _context;
        public RentalController(ApplicationDbContext context)
        {
            _context = context;
        }

        //[HttpGet]
        //public IActionResult Index()
        //{
        //    var customers = _context.Customers.ToList();
        //    var movies = _context.Movies.ToList();
        //    var rentalView = new RentalViewModel
        //    {
        //        Customers = customers,
        //        Movies = movies
        //    };

        //    return View(rentalView);
        //}




        [HttpPost]
        public Rental CreateRental(RentalRequestDto rentalRequestDto)
        {
            if (!ModelState.IsValid)
            {
                throw new System.Web.Http.HttpResponseException(System.Net.HttpStatusCode.BadRequest);
            }

            Rental rental = null;

            var customer = _context.Customers.Single(c => c.Id == rentalRequestDto.CustomerId);
            foreach(var movieId in rentalRequestDto.MoviesId)
            {
                var movie = _context.Movies.SingleOrDefault(c => c.Id == movieId);

                if (movie.NumberAvailable == 0)
                    throw new System.Web.Http.HttpResponseException(System.Net.HttpStatusCode.BadRequest);

                movie.NumberAvailable--;

                rental = new Rental
                {
                    Customer = customer,
                    Movies = movie,
                    DateRented = DateTime.Now
                };

                _context.Rentals.Add(rental);
                _context.SaveChanges();

                rentalRequestDto.Id = rental.Id;
            }


            return rental;
        }

    }
}
