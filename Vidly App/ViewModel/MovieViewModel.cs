using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Vidly_App.Models;

namespace Vidly_App.ViewModel
{
    public class MovieViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }

        public int? Id { get; set; }
        [Required]
        public string Name { get; set; }

        [Display(Name = "Released Date")]
        [ReleasedDateR]
        public DateTime? ReleasedDate { get; set; }

        [Display(Name = "Number In Stock")]
        [NumberInStock]
        [Required]
        public int? NumberInStock { get; set; }

        [Display(Name = "Genre")]
        [Required]
        public int? GenreId { get; set; }

        public MovieViewModel()
        {
            Id = 0;
        }

        public MovieViewModel(Movie movie)
        {
            Id = movie.Id;
            NumberInStock = movie.NumberInStock;
            GenreId = movie.GenreId;
            ReleasedDate = movie.ReleasedDate;
            Name = movie.Name;
        }
    }
}
