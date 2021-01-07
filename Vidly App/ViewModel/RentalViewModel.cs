using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vidly_App.Models;

namespace Vidly_App.ViewModel
{
    public class RentalViewModel
    {
        public List<Customer> Customers { get; set; }
        public List<Movie> Movies { get; set; }
    }
}
