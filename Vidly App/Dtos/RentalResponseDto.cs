using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vidly_App.Dtos
{
    public class RentalResponseDto
    {
        public List<CustomerDto> Customers { get; set; }
        public List<MovieDto> Movies { get; set; }
    }
}
