using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vidly_App.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Display(Name = "Released Date")]
        public DateTime ReleasedDate { get; set; }

        [Display(Name = "Date Added")]
        public DateTime DateAdded { get; set; }

        [Display(Name = "Number In Stock")]
        public string NumberInStock { get; set; }
        public Genre Genre { get; set; }
        public int GenreId { get; set; }

    }
}
