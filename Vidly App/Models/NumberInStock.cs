using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vidly_App.Models
{
    public class NumberInStock : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var movie = (Movie)validationContext.ObjectInstance;

            //if (movie.NumberInStock == "0")
            //    new ValidationResult("The field Number in Stock must be between 1-20");

            if (movie.NumberInStock == null)
                return new ValidationResult("The Number In Stock field is required.");

            return (movie.NumberInStock == "0") ? new ValidationResult("The field Number in Stock must be between 1-20") : ValidationResult.Success;
        }
    }
}
