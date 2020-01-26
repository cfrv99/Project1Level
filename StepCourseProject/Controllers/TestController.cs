using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StepCourseProject.Entites;
using StepCourseProject.Entites.Contexts;
using StepCourseProject.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StepCourseProject.Controllers
{
    public class TestController : Controller
    {
        private readonly AppDbContext context;
        private readonly IPostService postService;
        private readonly IBidService bidService;

        public TestController(AppDbContext context,
            IPostService postService,
            IBidService bidService,
            IMessageService messageService,
            UserManager<AppUser> userManager)
        {
            this.context = context;
            this.postService = postService;
            this.bidService = bidService;
        }
    }
}
