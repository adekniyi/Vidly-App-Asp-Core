using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vidly_App.Controllers
{
    public class RentalController : Controller
    {

        [Route("Rental/New")]
        public ActionResult New()
        {
            return View();
        }
    }
}
