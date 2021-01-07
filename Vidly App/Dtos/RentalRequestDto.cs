using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vidly_App.Dtos
{
    public class RentalRequestDto
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public List<int> MoviesId { get; set; }
    }
}
