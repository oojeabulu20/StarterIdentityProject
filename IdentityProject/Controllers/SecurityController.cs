using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using IdentityProject.Models;
using IdentityProject.Security;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace IdentityProject.Controllers
{
    public class SecurityController : Controller
    {

        private readonly UserManager<AppIdentityUser> userManager;
        private readonly RoleManager<AppIdentityRole> roleManager;
        private readonly SignInManager<AppIdentityUser> signinManager;

        public SecurityController(UserManager<AppIdentityUser> userManager, RoleManager<AppIdentityRole> roleManager,
            SignInManager<AppIdentityUser> signinManager)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
            this.signinManager = signinManager;
        }
        

        public IActionResult AccessDenied()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(Register obj)
        {
            if (ModelState.IsValid)
            {
                if (!roleManager.RoleExistsAsync("Manager").Result)
                {
                    AppIdentityRole role = new AppIdentityRole();
                    role.Name = "Manager";
                    IdentityResult roleResult = roleManager.
                    CreateAsync(role).Result;
                }

                AppIdentityUser user = new AppIdentityUser();
                user.UserName = obj.UserName;
                user.Email = obj.Email;
                user.FullName = obj.FullName;
                user.BirthDate = obj.BirthDate;

                IdentityResult result = userManager.CreateAsync
                (user, obj.Password).Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Manager").Wait();
                    return RedirectToAction("SignIn", "Security");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid user details");
                }
            }
            return View(obj);
        }

    }
}