using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using StepCourseProject.Entites;
using StepCourseProject.Hubs;
using StepCourseProject.Models;

namespace StepCourseProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserManager<AppUser> userManager;
        private readonly IHubContext<ChatHub> hubContext;
        

        public HomeController(UserManager<AppUser> userManager,IHubContext<ChatHub> hubContext)
        {
            this.userManager = userManager;
            this.hubContext = hubContext;
            
        }

        public IActionResult Index()
        {

            //var user = await userManager.FindByNameAsync(User.Identity.Name);
            //ViewBag.Id = user.Id;


            return View();
        }

        public IActionResult Privacy()
        {
            var onlineUsers = userManager.Users.Where(i=>i.IsOnline==true).ToList();

            ViewBag.a= ChatHub.onlineUsers;
            
            return View(onlineUsers);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
