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

            //var customer = _context.Customers.Include(c => c.MembershipType).ToList();

            //return View(customer);
            return View();
        }

        [Route("Customers/New")]
        public ActionResult New()
        {
            var membershiptype = _context.MembershipTypes;

            var viewmodel = new CustomerFormViewModel
            {
                Customer = new Customer(),
                MembershipTypes = membershiptype
            };
            return View("CustomerForm",viewmodel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("Customers/Save")]
        public ActionResult Save(Customer customer)
        {
            if(!ModelState.IsValid)
            {
                var viewModel = new CustomerFormViewModel
                {
                    Customer = customer,
                    MembershipTypes = _context.MembershipTypes.ToList()
                };
                return View("CustomerForm", viewModel);
            }
            if(customer.Id == 0)
                _context.Customers.Add(customer);
            else
            {
                var customerInDb = _context.Customers.Single(c => c.Id == customer.Id);


                customerInDb.Name = customer.Name;
                customerInDb.IsSubcribedToNewsletter = customer.IsSubcribedToNewsletter;
                customerInDb.Birthday = customer.Birthday;
                customerInDb.MembershipTypeId = customer.MembershipTypeId;

            }

            _context.SaveChanges();
            return RedirectToAction("Index","Customer");
        }

        [Route("Customers/Edit/{id}")]
        public ActionResult Edit(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (customer == null)
                return NotFound();
            var viewModel = new CustomerFormViewModel
            {
                Customer = customer,
                MembershipTypes = _context.MembershipTypes.ToList(),
            };

            return View("CustomerForm", viewModel);
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
