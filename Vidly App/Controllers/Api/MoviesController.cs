using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vidly_App.Data;
using Vidly_App.Dtos;
using Vidly_App.Models;
using Microsoft.AspNetCore.Authorization;

namespace Vidly_App.Controllers.Api
{
    [AllowAnonymous]
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private ApplicationDbContext _context;
        public MoviesController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<MovieDto> GetMovies()
        {
            return _context.Movies
                .Include(c =>c.Genre)
                .ToList()
                .Select(Mapper.Map<Movie, MovieDto>); ;
        }

        [Route("{id}")]
        public MovieDto GetMovie(int id)
        {
            var movie = _context.Movies.SingleOrDefault(c => c.Id == id);

            if (movie == null)
                throw new System.Web.Http.HttpResponseException(System.Net.HttpStatusCode.NotFound);



            return Mapper.Map<Movie, MovieDto>(movie);
        }

        [HttpPost]
        public MovieDto CreateMovie(MovieDto movieDto)
        {
            if (!ModelState.IsValid)
            {
                throw new System.Web.Http.HttpResponseException(System.Net.HttpStatusCode.BadRequest);
            }

            var movie = Mapper.Map<MovieDto, Movie>(movieDto);
            movie.NumberAvailable = movie.NumberInStock;
            _context.Movies.Add(movie);

            _context.SaveChanges();
            movieDto.Id = movie.Id;

            return movieDto;
        }

        [HttpPut]
        [Route("{id}")]
        public MovieDto UpdateMovie(int id, MovieDto movieDto)
        {
            if (!ModelState.IsValid)
            {
                throw new System.Web.Http.HttpResponseException(System.Net.HttpStatusCode.BadRequest);
            }

            var movieInDb = _context.Movies.SingleOrDefault(c => c.Id == id);
            if (movieInDb == null)
                throw new System.Web.Http.HttpResponseException(System.Net.HttpStatusCode.NotFound);

            Mapper.Map(movieDto, movieInDb);

            _context.SaveChanges();

            return movieDto;
        }

        [HttpDelete]
        [Route("{id}")]
        public Movie DeleteMovie(int id)
        {
            var movie = _context.Movies.SingleOrDefault(c => c.Id == id);
            if (movie == null)
                throw new System.Web.Http.HttpResponseException(System.Net.HttpStatusCode.NotFound);

            _context.Movies.Remove(movie);
            _context.SaveChanges();

            return movie;
        }
    }
}
