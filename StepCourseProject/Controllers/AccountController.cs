using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StepCourseProject.Entites;
using StepCourseProject.Entites.Contexts;
using StepCourseProject.Extensions;
using StepCourseProject.Models;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace StepCourseProject.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> userManager;
        private readonly SignInManager<AppUser> signInManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly AppDbContext context;

        public AccountController(UserManager<AppUser> userManager,
            SignInManager<AppUser> signInManager,
            RoleManager<IdentityRole> roleManager,
            AppDbContext context)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
            this.context = context;
        }

        public async Task<IActionResult> Test()
        {
            var user = await userManager.FindByNameAsync(User.Identity.Name);
            var roles = await userManager.GetRolesAsync(user);
            return View(roles);
        }

        public IActionResult Register()
        {
            return View(new RegisterVM());
        }

        [HttpGet]
        public IActionResult Role()
        {
            return View(new RoleVM());
        }
        [HttpPost]
        public async Task<IActionResult> Role(RoleVM vm)
        {
            if (ModelState.IsValid)
            {
                var role = await roleManager.FindByNameAsync(vm.Name);
                if (role == null)
                {
                    IdentityRole r = new IdentityRole();
                    r.Name = vm.Name;
                    var result = await roleManager.CreateAsync(r);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
            }
            return View(vm);
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterVM vm, string selectedRole)
        {
            if (ModelState.IsValid)
            {
                AppUser user = new AppUser()
                {
                    UserName = vm.UserName,
                    Email = vm.Email,
                    FullName = vm.FirstNameLastName
                };
                var userExist = await userManager.FindByNameAsync(vm.UserName);

                var result = await userManager.CreateAsync(user, vm.Password);
                if (result.Succeeded)
                {
                    //var role = await roleManager.FindByNameAsync("Admin");
                    //await userManager.AddToRoleAsync(user, role.Name);
                    var adminUsers = await userManager.GetUsersInRoleAsync("Admin");

                    foreach (var admin in adminUsers)
                    {
                        Notification n = new Notification()
                        {
                            AppUserId = admin.Id,
                            FromUserName = "System",
                            IsRead = false,
                            NotificationText = $"{vm.UserName} is registered",

                        };
                        context.Notifications.Add(n);
                    }


                    await signInManager.SignInAsync(user, false);
                    var role = await roleManager.FindByNameAsync(selectedRole);
                    if (role == null)
                    {
                        throw new Exception();
                    }
                    await userManager.AddToRoleAsync(user, selectedRole);
                    if (selectedRole == "Freelancer")
                    {
                        return Redirect("/Account/FillProfile");

                    }
                    else
                    {
                        return Redirect("/");
                    }
                }
            }
            else
            {
                ModelState.AddModelError("Register", "Register is faild");
            }
            return View(vm);
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View(new LoginVM());
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginVM vm)
        {
            if (ModelState.IsValid)
            {
                var user = await userManager.FindByNameAsync(vm.UserName);
                if (user != null)
                {
                    await signInManager.SignOutAsync();
                    var result = await signInManager.PasswordSignInAsync(user, vm.Password, false, false);
                    if (result.Succeeded)
                    {

                        var roles = await userManager.GetRolesAsync(user);
                        if (roles.Contains("Admin"))
                        {
                            return Redirect("/Admin/Home/Dashboard");
                        }

                        else { return Redirect("/"); }

                    }
                    ModelState.AddModelError("", "Login or Passwrod is incorrect");
                }
            }
            else
            {
                ModelState.AddModelError("Login", "Login is failed");
            }

            return View(vm);
        }

        public async Task<IActionResult> Logout()
        {
            if (User.Identity.IsAuthenticated)
            {
                await signInManager.SignOutAsync();
            }
            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> FillProfile()
        {
            var user = await userManager.FindByNameAsync(User.Identity.Name);

            var selectedItems = context.UserSkills.Where(i => i.AppUserId == user.Id).Select(i => i.SkillId);
            if (selectedItems == null)
            {
                ViewBag.Skills = new MultiSelectList(context.Skills, "Id", "SkillName");

            }

            ViewBag.Skills = new MultiSelectList(context.Skills, "Id", "SkillName", selectedItems);

            if (!await userManager.IsInRoleAsync(user, "Freelancer"))
            {
                return BadRequest();
            }


            FillFreelanceProfileVM model = new FillFreelanceProfileVM()
            {
                Email = user.Email,
                UserName = user.UserName,
                FullName = user.FullName,
                City = user.City,
                OwnWebSite = user.WebSiteLink,
                Age = user.Age,
                BirthDay = user.BirthDay,
                Experience = user.Experience,
                ImageUrl = user.ImageUrl,
                Description = user.Description,
                PhoneNumber = user.PhoneNumber

            };


            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> FillProfile(FillFreelanceProfileVM vm, int[] skillIds, IFormFile file)
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
                    vm.ImageUrl = filename;
                    user.FullName = vm.FullName;
                    user.BirthDay = vm.BirthDay;
                    user.Experience = vm.Experience;
                    user.PhoneNumber = vm.PhoneNumber;
                    user.Description = vm.Description;
                    user.City = vm.City;
                    user.Age = vm.Age;
                    user.ImageUrl = vm.ImageUrl;
                    user.UserName = vm.UserName;

                    if (user.UserSkills == null)
                    {
                        context.UserSkills.AddRange(skillIds.Select(i => new UserSkill { SkillId = i, AppUserId = user.Id }));

                    }
                    else
                        context.UpdateManyToMany(
                            context.UserSkills.Where(x => x.AppUserId == user.Id),
                            skillIds.Select(x => new UserSkill { AppUserId = user.Id, SkillId = x }),
                            x => x.SkillId);

                    var b = await context.SaveChangesAsync();

                    
                    var result = await userManager.UpdateAsync(user);
                    if (result.Succeeded)
                    {

                        TempData["OK"] = "Profile sucsessfully filled!!!";
                        return Redirect("/");
                    }
                }
            }
            var selectedItems = context.UserSkills.Where(i => i.AppUserId == user.Id).Select(i => i.SkillId);
            if (selectedItems == null)
            {
                ViewBag.Skills = new MultiSelectList(context.Skills, "Id", "SkillName");

            }
            ViewBag.Skills = new MultiSelectList(context.Skills, "Id", "SkillName", selectedItems);
            return View(vm);
        }
        [Route("{action}/User/{userId}")]
        public async Task<IActionResult> Profile(string userId)
        {
            var user = await userManager.FindByIdAsync(userId);


            if (user == null)
            {
                return BadRequest();
            }
            var skills = context.UserSkills.Include(i => i.Skill)
                .Where(i => i.AppUserId == userId).Select(i => i.SkillId).ToList();

            var users = userManager.Users;

            var profile = users.Include(i => i.UserSkills)
                .ThenInclude(i => i.Skill)
                .Where(i => i.Id == userId)
                .Select(i => new ProfileVM
                {
                    Id = i.Id,
                    AppUserId = i.Id,
                    ImageUrl = i.ImageUrl,
                    Age = i.Age,
                    Experiance = i.Experience,
                    Email = i.Email,
                    City = i.City,
                    Description = i.Description,
                    FullName = i.FullName,
                    UserName = i.UserName,
                    GitHubLink = i.GitHubLink,
                    WebSiteLink = i.WebSiteLink,
                    BirthDay = i.BirthDay,
                    Skills = i.UserSkills.Select(a => a.Skill).ToList()
                }).FirstOrDefault();

            ViewBag.Skills = skills;
            return View(profile);
        }
    }


}
