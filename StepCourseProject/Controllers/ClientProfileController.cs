using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StepCourseProject.Entites;
using StepCourseProject.Entites.Contexts;
using StepCourseProject.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace StepCourseProject.Controllers
{
    [Authorize(Roles = "Client")]
    public class ClientProfileController : Controller
    {
        private readonly UserManager<AppUser> userManager;
        private readonly AppDbContext context;

        public ClientProfileController(UserManager<AppUser> userManager, AppDbContext context)
        {
            this.userManager = userManager;
            this.context = context;
        }
        [Route("current/client/profile")]
        public async Task<IActionResult> ClientProfileSettings()
        {
            var user = await userManager.FindByNameAsync(User.Identity.Name);

            ClientProfileSettingsVM vm = new ClientProfileSettingsVM()
            {
                ClientId = user.Id,
                ClientName = user.UserName,
                FullName = user.FullName,
                Company = user.Company,
                Age = user.Age,
                ClientImageUrl = user.ImageUrl,
                City = user.City,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber,
                Description = user.Description
            };

            return View(vm);
        }

        [HttpPost]
        public async Task<IActionResult> Settings(ClientProfileSettingsVM vm, IFormFile file)
        {
            var user = await userManager.FindByNameAsync(User.Identity.Name);
            if (ModelState.IsValid)
            {
                if (file != null)
                {
                    var filename = $"{Guid.NewGuid().ToString()}{file.FileName}";
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\img", filename);

                    using (var fs = new FileStream(path, FileMode.OpenOrCreate))
                    {
                        await file.CopyToAsync(fs);
                    }
                    vm.ClientImageUrl = filename;

                    user.Age = vm.Age;
                    user.City = vm.City;
                    user.Company = vm.Company;
                    user.Description = vm.Description;
                    user.Email = vm.Email;
                    user.FullName = vm.FullName;
                    user.ImageUrl = vm.ClientImageUrl;
                    user.PhoneNumber = vm.PhoneNumber;
                    user.UserName = vm.ClientName;
                }

                var result = await userManager.UpdateAsync(user);
                if (result.Succeeded)
                {
                    return Redirect("/");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("Update", item.Description);
                    }
                }
            }
            return View(vm);
        }
    }
}
