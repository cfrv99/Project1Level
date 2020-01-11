using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StepCourseProject.Entites;
using StepCourseProject.Entites.Contexts;
using StepCourseProject.Models;
using StepCourseProject.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StepCourseProject.Controllers
{
    public class ProjectController : Controller
    {
        private readonly IPostRepo repo;
        private readonly UserManager<AppUser> userManager;
        private readonly AppDbContext context;

        public ProjectController(IPostRepo repo,
            UserManager<AppUser> userManager,
            AppDbContext context)
        {
            this.repo = repo;
            this.userManager = userManager;
            this.context = context;
        }

        public async Task<IActionResult> AllPost()
        {
            var user = await userManager.FindByNameAsync(User.Identity.Name);
            var userSkills = context.UserSkills.Where(i => i.AppUserId == user.Id).ToList();

            HashSet<int> diffIds = new HashSet<int>(userSkills.Select(i => i.SkillId));

            var data = context.Posts.Where(i => diffIds.Contains(i.SkillId))
                .Include(i => i.AppUser)
                .Include(i => i.Bids)
                .Include(i => i.Skill)
                .Select(i => new AllPostViewModel()
                {
                    Id = i.Id,
                    PostName = i.PostName,
                    PostDesc = i.PostDescription,
                    PostDate = i.PostDate,
                    PostDeadLine = i.PostDeadLine,
                    PostUserId = i.AppUserId,
                    PostUserName = i.AppUser.UserName,
                    CountBids = i.Bids.Count(),
                    EndPrice = i.EndPrice,
                    SkillName = i.Skill.SkillName,
                    StartPrice = i.StartPrice
                }).ToList();

            if (data.Count == 0)
            {
                return NotFound();
            }
            return View(data);
        }
    }
}
