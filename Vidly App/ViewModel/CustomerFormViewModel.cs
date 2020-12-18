using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vidly_App.Models;

namespace Vidly_App.ViewModel
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}
