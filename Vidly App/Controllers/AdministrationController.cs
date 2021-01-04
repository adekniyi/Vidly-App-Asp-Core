using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Vidly_App.Data;
using Vidly_App.ViewModel;

namespace Vidly_App.Controllers
{
    public class AdministrationController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManger;
        private readonly UserManager<ApplicationUser> userManager;

        public AdministrationController(RoleManager<IdentityRole> roleManger, UserManager<ApplicationUser> userManager)
        {
            this.roleManger = roleManger;
            this.userManager = userManager;
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
                    return RedirectToAction("ListRoles", "administration");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View(model);
        }

        [HttpGet]
        [Route("administration/ListRoles")]
        public IActionResult ListRoles()
        {
            var roles = roleManger.Roles;

            return View(roles);
        } 
        
        [HttpGet]
        [Route("administration/ListRoles")]
        public async Task<IActionResult> EditRole(string id)
        {
            var role = await roleManger.FindByIdAsync(id);

            if(role == null)
                return NotFound();

            var model = new EditRoleViewModel
            {
                Id = role.Id,
                RoleName = role.Name
            };

            foreach(var user in userManager.Users)
            {
                if(await userManager.IsInRoleAsync(user,role.Name))
                {
                    model.Users.Add(user.UserName);
                }
            }
            return View(model);
        }

    }
}
