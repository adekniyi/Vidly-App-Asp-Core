using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using System.Web.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vidly_App.Data;
using Vidly_App.Dtos;
using Vidly_App.Models;

namespace Vidly_App.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private ApplicationDbContext _context;
        public CustomersController(ApplicationDbContext context)
        {
            _context = context;
        }


        public IEnumerable<CustomerDto> GetCustomers()
        {
            var customer = _context.Customers.ToList();


            return customer;
        }

        [Route("{id}")]
        public Customer GetCustomer(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customer == null)
                throw new System.Web.Http.HttpResponseException(System.Net.HttpStatusCode.NotFound);

            return customer;
        }

        [HttpPost]
        public Customer CreateCustomer(Customer customer)
        {
            if(!ModelState.IsValid)
            {
                throw new System.Web.Http.HttpResponseException(System.Net.HttpStatusCode.BadRequest);
            }

            _context.Customers.Add(customer);

            _context.SaveChanges();

            return customer;
        }

        [HttpPut]
        [Route("{id}")]
        public Customer UpdateCustomer(int id, Customer customer)
        {
            if (!ModelState.IsValid)
            {
                throw new System.Web.Http.HttpResponseException(System.Net.HttpStatusCode.BadRequest);
            }

            var customerInDb = _context.Customers.SingleOrDefault(c => c.Id == id);
            if(customerInDb == null)
                throw new System.Web.Http.HttpResponseException(System.Net.HttpStatusCode.NotFound);

            customerInDb.IsSubcribedToNewsletter = customer.IsSubcribedToNewsletter;
            customerInDb.MembershipTypeId = customer.MembershipTypeId;
            customerInDb.Name = customer.Name;
            customerInDb.Birthday = customer.Birthday;

            _context.SaveChanges();

            return customerInDb;
        }

        [HttpDelete]
        [Route("{id}")]
        public Customer DeleteCustomer(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (customer == null)
                throw new System.Web.Http.HttpResponseException(System.Net.HttpStatusCode.NotFound);

            _context.Customers.Remove(customer);
            _context.SaveChanges();

            return customer;
        }
    }
}
