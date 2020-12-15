﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vidly_App.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]

        public string Name { get; set; }
        public bool IsSubcribedToNewsletter { get; set; }
        public MembershipType MembershipType { get; set; }
    }
}
