using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StepCourseProject.Entites;
using StepCourseProject.Entites.Contexts;
using StepCourseProject.Entites.Enums;
using StepCourseProject.Models;
using StepCourseProject.Repository.Abstract;
using StepCourseProject.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StepCourseProject.Controllers
{
    [Authorize(Roles = "Freelancer")]
    public class ProjectController : Controller
    {
        private readonly IPostRepo repo;
        private readonly UserManager<AppUser> userManager;
        private readonly AppDbContext context;
        private readonly IBidService bidService;
        private readonly IPostService postService;

        public ProjectController(IPostRepo repo,
            UserManager<AppUser> userManager,
            AppDbContext context,
            IBidService bidService,
            IPostService postService)
        {
            this.repo = repo;
            this.userManager = userManager;
            this.context = context;
            this.bidService = bidService;
            this.postService = postService;
        }


        //UI yoxdur
        [HttpGet]
        public async Task<IActionResult> AllPost(decimal from, decimal to)
        {
            var user = await userManager.FindByNameAsync(User.Identity.Name);
            if (user == null)
            {
                return Unauthorized();
            }
            var userSkills = context.UserSkills.Where(i => i.AppUserId == user.Id).ToList();

            var data = postService.AllPostInMainPage();
            if (userSkills == null)
            {
                return View(data);
            }
            HashSet<int> diffIds = new HashSet<int>(userSkills.Select(i => i.SkillId));

            data = data.Where(i => diffIds.Contains(i.SkillId)).ToList();

            if (to != 0 && from != 0)
            {
                data = data.Where(i => i.StartPrice > from && i.StartPrice <= to).ToList();
            }

            return View(data);
        }

        [HttpGet] //UI yoxdur
        public IActionResult Details(int id)
        {           
            var entity = postService.GetPostDetail(id);

            return View(entity);
        }
        [HttpPost]
        public async Task<IActionResult> CreateBid(DetailViewModel vm)
        {
            var post = context.Posts.Where(i => i.Id == vm.CreateBid.PostId).FirstOrDefault();

            var user = await userManager.FindByNameAsync(User.Identity.Name);

            Bid b = new Bid
            {
                BidBody = vm.CreateBid.BidBody,
                BidDate = DateTime.Now,
                BidPrice = vm.CreateBid.BidPrice,
                Status = BidStatus.Waiting
            };

            bidService.CreateBidToProject(post, b, user);

            return RedirectToAction("Details", new { id=vm.CreateBid.PostId });
        }


        [ActionName("My")]
        [Route("/projects")]
        public async Task<IActionResult> CurrentFreelancerProjects()
        {
            var currentUser = await userManager.FindByNameAsync(User.Identity.Name);
            string currentUserId = currentUser.Id;

            var entity = await context.Posts.Include(i => i.FreelancerPosts)
                .Include(i => i.AppUser)
                .Include(i => i.Bids)
                .Where(i => i.FreelancerPosts.Any(f => f.FreelancerId == currentUserId))
                .Select(i => new FreelancerOwnPostVM
                {
                    Id = i.Id,
                    PostAuthorId = i.AppUser.Id,
                    PostAuthorName = i.AppUser.UserName,
                    PostDeadLine = i.PostDeadLine,
                    PostDescription = i.PostDescription,
                    PostName = i.PostName,
                    PostPrice = i.Bids
                    .Where(b => b.PostId == i.Id && b.AppUserId == currentUserId && b.IsDone == true && b.Status == BidStatus.Accepted)
                    .Select(b => b.BidPrice)
                    .FirstOrDefault()
                })
                .ToListAsync();


            return View();
        }

        public async Task<IActionResult> AllFreeLancers()
        {
            var currentUser = await userManager.FindByNameAsync(User.Identity.Name);

            var freelancers = await userManager.GetUsersInRoleAsync("Freelancer");


            var coverData = freelancers.OrderByDescending(i => i.Rating).Take(10).AsQueryable();

            return View(coverData);
        }


    }
}
