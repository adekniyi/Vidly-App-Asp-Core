using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vidly_App.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

    //[Min18YearsIfAMember]
        public DateTime? Birthday { get; set; }
        public bool IsSubcribedToNewsletter { get; set; }

        public MembershipTypeDto MembershipType { get; set; }

        public int? MembershipTypeId { get; set; }
    }
}
