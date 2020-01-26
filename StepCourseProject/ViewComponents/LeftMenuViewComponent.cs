using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StepCourseProject.Entites;
using StepCourseProject.Entites.Contexts;
using StepCourseProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StepCourseProject.ViewComponents
{
    public class LeftMenuViewComponent : ViewComponent
    {
        private readonly AppDbContext context;
        private readonly UserManager<AppUser> userManager;

        public LeftMenuViewComponent
            (
            AppDbContext context,
            UserManager<AppUser> userManager         
            )
        {
            this.context = context;
            this.userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var user = await userManager.FindByNameAsync(User.Identity.Name);

            LeftMenuViewModel vm = new LeftMenuViewModel()
            {
                UserId = user.Id,
                UserName = user.UserName,
                FullName = user.FullName,
                ImageUrl = user.ImageUrl,
                Skills = context.UserSkills.Include(i => i.Skill).Where(i => i.AppUserId == user.Id).ToList(),
                Experiance=user.Experience
            };
            return View(vm);
        }

    }
}
