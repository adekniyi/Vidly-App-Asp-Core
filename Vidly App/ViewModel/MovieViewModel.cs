using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vidly_App.Models;

namespace Vidly_App.ViewModel
{
    public class MovieViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }
        public Movie Movie { get; set; }
    }
}
