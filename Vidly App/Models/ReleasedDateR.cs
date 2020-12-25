using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vidly_App.Models
{
    public class ReleasedDateR : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var movie = (Movie)validationContext.ObjectInstance;

           
            return (movie.NumberInStock == null) ? new ValidationResult("The Released Date field is required.") : ValidationResult.Success;
        }
    }
}
