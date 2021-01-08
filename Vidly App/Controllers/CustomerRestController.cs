using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vidly_App.Data;

namespace Vidly_App.Controllers
{
    [Route("api/customers")]
    [ApiController]
    public class CustomerRestController : ControllerBase
    {
        private ApplicationDbContext _context;

        public CustomerRestController(ApplicationDbContext context)
        {
            _context = context;
        }

        [Produces("application/json")]
        [HttpGet("search")]
        public async Task<IActionResult> Search()
        {
            try
            {
                string term = HttpContext.Request.Query["term"].ToString();
                var name = _context.Customers.Where(p => p.Name.Contains(term))
                    .Select(p => p.Name).ToList();
                return Ok(name);
            }
            catch (Exception)
            {

                return BadRequest();
            }
        }
    }
}
