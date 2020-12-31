﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vidly_App.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public DateTime ReleasedDate { get; set; }
        public DateTime DateAdded { get; set; }

        [Required]
        public string NumberInStock { get; set; }

        [Required]
        public int GenreId { get; set; }
    }
}
