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


        //UI yoxdur
        public async Task<IActionResult> AllPost()
        {
            var user = await userManager.FindByNameAsync(User.Identity.Name);
            if (user == null)
            {
                return Unauthorized();
            }
            var userSkills = context.UserSkills.Where(i => i.AppUserId == user.Id).ToList();

            if (userSkills == null)
            {
                var d = context.Posts.Include(i => i.AppUser)
                    .Include(i => i.Bids)
                    .Include(i => i.Skill)
                    .Select(i => new AllPostViewModel
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
                return View(d);
            }

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

        [HttpGet] //UI yoxdur
        public IActionResult Details(int id)
        {
            var data = repo.GetPost(id);
            var entity = context.Posts.Where(i => i.Id == id)
                .Include(i => i.AppUser)
                .Include(i => i.Bids)
                .Include(i => i.Skill)
                .Select(i => new DetailViewModel
                {
                    Id=i.Id,
                    PostName=i.PostName,
                    PostSkillName=i.Skill.SkillName,
                    PostDescription=i.PostDescription,
                    PostStartPrice=i.StartPrice,
                    PostEndPrice=i.EndPrice,
                    Bids= i.Bids.Where(a=>a.isPublic).ToList(),
                    PostDate=i.PostDate,
                    PostDeadLine=i.PostDeadLine,
                    UserId=i.AppUser.Id,
                    UserName=i.AppUser.UserName
                }).FirstOrDefault();

            return View();
        }
    }
}
