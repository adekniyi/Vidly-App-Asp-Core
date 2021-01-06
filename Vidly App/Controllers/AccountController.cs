using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using System.Web.Http;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Mvc;
using Vidly_App.Data;
using Vidly_App.Models;
using System.Web;
using Microsoft.Owin.Host.SystemWeb;
//using System.Web.Mvc;
using System.Net.Http;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Owin.Security;
using System.Security.Claims;
//using Microsoft.AspNetCore.Server.HttpSys;
//using System.Net;
//using System.Web.Mvc;


namespace Vidly_App.Controllers
{
    public class AccountController : Controller
    {

        private SignInManager<ApplicationUser> _signInManager;
        private Microsoft.AspNetCore.Identity.UserManager<ApplicationUser> _userManager;

        public AccountController(Microsoft.AspNetCore.Identity.UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        // GET: /Account/Login
        [AllowAnonymous]
        [Route("Account/Login")]
        public async Task<ActionResult> Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            var logInViewModel = new LoginViewModel
            {
                ReturnUrl = returnUrl,
                ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList()
            };
            return View(logInViewModel);
        }




        //
        // POST: /Account/ExternalLogin
        [HttpPost]
        [AllowAnonymous]
        [Route("Account/ExternalLogin")]
        [ValidateAntiForgeryToken]
        public ActionResult ExternalLogin(string provider, string returnUrl)
        {
            // Request a redirect to the external login provider
            var redirectUrl =  Url.Action("ExternalLoginCallback", "Account", 
                                            new { ReturnUrl = returnUrl });
            var properties = _signInManager
                .ConfigureExternalAuthenticationProperties(provider, redirectUrl);

            return new ChallengeResult(provider, properties);
        }

        //
        // GET: /Account/ExternalLoginCallback
        [HttpGet]
        [AllowAnonymous]
        [Route("Account/ExternalLoginCallback")]
        public async Task<ActionResult> ExternalLoginCallback(string returnUrl = null, string remoteError = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");


            var loginViewModel = new LoginViewModel
            {
                ReturnUrl = returnUrl,
                ExternalLogins = (await _signInManager
                .GetExternalAuthenticationSchemesAsync()).
                ToList()
            };

            if(remoteError != null)
            {
                ModelState.AddModelError(string.Empty, $"Error from external provider:{remoteError}");
                return View("Login", loginViewModel);
            }

            var loginInfo = await _signInManager.GetExternalLoginInfoAsync();
            if (loginInfo == null)
            {
                ModelState.AddModelError(string.Empty, $"Error loading external information");
                return RedirectToAction("Login", loginViewModel);
            }



            // Sign in the user with this external login provider if the user already has a login
            var result = await _signInManager.ExternalLoginSignInAsync(loginInfo.LoginProvider,loginInfo.ProviderKey ,isPersistent: false, bypassTwoFactor:true);
            if (result.Succeeded)
            {
                return LocalRedirect(returnUrl);     
            }
            else
            {
                var email = loginInfo.Principal.FindFirstValue(ClaimTypes.Email);

                if(email != null)
                {
                    var user = await _userManager.FindByEmailAsync(email);

                    if(user == null)
                    {
                         user = new ApplicationUser
                        {
                            UserName = loginInfo.Principal.FindFirstValue(ClaimTypes.Name),
                            Email = loginInfo.Principal.FindFirstValue(ClaimTypes.Email),
                        };
                       
                        await _userManager.CreateAsync(user);
                    }

                    await _userManager.AddLoginAsync(user, loginInfo);
                    await _signInManager.SignInAsync(user, isPersistent: false);

                    return LocalRedirect(returnUrl);
                }

                ViewBag.ErrorTitle = $"Email claim not recieved from {loginInfo.LoginProvider}";
                ViewBag.ErrorMessage = "Please confirm support on adekniyi@gmail.com";

                return View("Login", loginViewModel);
            }

           // return View("Login", loginViewModel);
        }




        //
        // POST: /Account/Login
        [HttpPost]
        [Route("Account/Login")]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(LoginViewModel model, string returnUrl)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // This doesn't count login failures towards account lockout
            // To enable password failures to trigger account lockout, change to shouldLockout: true
            var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, false);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Home");
            }
            if (result.IsLockedOut)
            {
                return View("Lockout");
            }
            if (result.IsNotAllowed)
            {
                return View("Not Allowed");
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                return View(model);
            }
        }


        // GET: /Account/Register
        [AllowAnonymous]
        public ActionResult Register()
        {
            return View();
        }

        //
        // POST: /Account/Register
        [HttpPost]
        [Route("Account/Register")]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser { 
                    UserName = model.Email, 
                    Email = model.Email,
                    DrivingLicense = model.DrivingLicense
                    };
                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    //Temp
                    //var roleStore = new RoleStore<IdentityRole>(new ApplicationDbContext());
                    //var roleManager = new RoleManager<IdentityRole>(roleStore);

                    await _signInManager.SignInAsync(user, isPersistent: false);

                    // For more information on how to enable account confirmation and password reset please visit http://go.microsoft.com/fwlink/?LinkID=320771
                    // Send an email with this link
                    // string code = await UserManager.GenerateEmailConfirmationTokenAsync(user.Id);
                    // var callbackUrl = Url.Action("ConfirmEmail", "Account", new { userId = user.Id, code = code }, protocol: Request.Url.Scheme);
                    // await UserManager.SendEmailAsync(user.Id, "Confirm your account", "Please confirm your account by clicking <a href=\"" + callbackUrl + "\">here</a>");

                    return RedirectToAction("Index", "Home");
                }

                foreach(var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                //AddErrors(result);
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }


        // POST: /Account/Logout
        [HttpPost]
        [Route("Account/Logout")]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }


        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}








//private IAuthenticationManager AuthenticationManager
//{
//    get
//    {
//        return HttpContext.GetOwinContext().Authentication;
//    }
//}