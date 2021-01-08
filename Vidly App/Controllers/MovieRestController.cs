using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vidly_App.Data;

namespace Vidly_App.Controllers
{
    [Route("api/movies")]
    [ApiController]
    public class MovieRestController : ControllerBase
    {
        private ApplicationDbContext _context;

        public MovieRestController(ApplicationDbContext context)
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
                var name = _context.Movies.Where(p => p.Name.Contains(term))
                    .Where(p=>p.NumberAvailable > 0)
                    //.Select(p=>p.Id)
                    .Select(c => new { id = c.Id, value = c.Name })
                    .ToList();
                return Ok(name);
            }
            catch (Exception)
            {

                return BadRequest();
            }
        }
    }
}
