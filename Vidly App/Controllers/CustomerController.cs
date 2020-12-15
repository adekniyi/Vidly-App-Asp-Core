using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Vidly_App.Data;
using Vidly_App.Models;
using Vidly_App.ViewModel;

namespace Vidly_App.Controllers
{
    public class CustomerController : Controller
    {
        private ApplicationDbContext _context;

        public CustomerController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: Customers
        [Route("Customers")]
        public ActionResult Index()
        {
            //var customer = new List<Customer>
            //{
            //    new Customer {Name = "John Smith",  Id = 1 },
            //    new Customer {Name = "Mary William",  Id = 2}
            //};

            //var viewModel = new RandomMovieViewModel
            //{
            //    Customer = customer
            //};

            var customer = _context.Customers.Include(c => c.MembershipType).ToList();

            return View(customer);
        }

        [Route("Customers/Details/{id}")]
        public ActionResult Details(int id)
        {

            //var customer = new List<Customer>
            //{
            //    new Customer {Name = "John Smith" ,  Id = 1 },
            //    new Customer {Name = "Mary William",  Id = 2}
            //};

            //var viewModel = new RandomMovieViewModel
            //{
            //    Customer = customer
            //};


            //foreach (var custom in viewModel.Customer)
            //{
            //    if (custom.Id == id)
            //    {
            //        return View(custom);
            //    }
            //}
            //return NotFound();
            var customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);

            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

    }
}
