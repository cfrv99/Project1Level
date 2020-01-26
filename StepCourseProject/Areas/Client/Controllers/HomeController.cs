using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StepCourseProject.Areas.Client.Models;
using StepCourseProject.Entites;
using StepCourseProject.Entites.Contexts;
using StepCourseProject.Repository.Abstract;
using StepCourseProject.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace StepCourseProject.Areas.Client.Controllers
{
    [Area("Client")]
    [Authorize(Roles = "Client")]
    public class HomeController : Controller
    {
        private IPostService _postService;
        private readonly AppDbContext context;
        private UserManager<AppUser> _userManager;
        private ISkillRepo _skillRepo;
        private IBidService _bidService;

        public HomeController(IPostService postService, AppDbContext context, UserManager<AppUser> userManager, ISkillRepo skillRepo, IBidService _bidService)
        {
            _postService = postService;
            this.context = context;
            _userManager = userManager;
            _skillRepo = skillRepo;
            this._bidService = _bidService;
        }

        [HttpGet]
        public IActionResult CreateProject()
        {
            ViewBag.Skills = new SelectList(_skillRepo.GetSkills(), "Id", "SkillName");
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateProject(PostViewModel postVM)
        {
            var currentUserName = User.Identity.Name;
            var currentUser = await _userManager.FindByNameAsync(currentUserName);
            ViewBag.Skills = new SelectList(_skillRepo.GetSkills(), "Id", "SkillName");
            var post = new Post()
            {
                AppUserId = currentUser.Id,
                Id = postVM.Id,
                EndPrice = postVM.EndPrice,
                PostDate = postVM.PostDate,
                PostDeadLine = postVM.PostDeadLine,
                PostDescription = postVM.PostDescription,
                PostName = postVM.PostName,
                StartPrice = postVM.StartPrice,
                SkillId = postVM.SkillId,

            };


            var skill = _skillRepo.GetSkill(post.SkillId);
            _postService.CreatePostFromClient(post, skill, currentUser);
            return RedirectToAction("Index");



        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var currentUserName = User.Identity.Name;
            var currentUser = await _userManager.FindByNameAsync(currentUserName);
            return View("List", _postService.GetYourPosts(currentUser).Where(x => x.HaveIsDoneBid == false));
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var currentUserName = User.Identity.Name;
            var currentUser = await _userManager.FindByNameAsync(currentUserName);
            var posts = _postService.GetYourPosts(currentUser);
            var post = posts.FirstOrDefault(i => i.Id == id);
            var postVM = new PostDetailsVM()
            {
                PostName = post.PostName,
                PostId = post.Id,
                Bids = post.Bids
                .Where(i => i.IsDone == false && i.Status == Entites.Enums.BidStatus.Waiting).ToList()
            };

            return View(postVM);
        }
        [HttpGet]
        public IActionResult DeletePost(int id)
        {
            //_postService.DeletePost(id);
            return RedirectToAction("Index");
        }
    }
}
