using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Vidly_App.ViewModel;

namespace Vidly_App.Controllers
{
    public class AdministrationController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManger;

        public AdministrationController(RoleManager<IdentityRole> roleManger)
        {
            this.roleManger = roleManger;
        }

        [HttpGet]
       // [Route("administration/createrole")]
        public IActionResult CreateRole()
        {
            return View();
        }

        [HttpPost]
        [Route("administration/createrole")]
        public async Task<IActionResult> CreateRole(CreateRoleViewModel model)
        {
            if(ModelState.IsValid)
            {
                IdentityRole identityRole = new IdentityRole
                {
                    Name = model.RoleName,
                };

                IdentityResult result = await roleManger.CreateAsync(identityRole);

                if(result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View(model);
        }
    }
}
