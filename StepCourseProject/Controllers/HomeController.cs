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

            //[HttpPost] with ajax
            //public async Task<IActionResult> Send(Message vm)
            //{
            //    var currentUser = await userManager.GetUserAsync(User);
            //    var recieverUser = await userManager.FindByIdAsync(vm.RecieverId);

            //    if (string.IsNullOrEmpty(vm.MessageText))
            //    {
            //        return View(vm);
            //    }
            //    //ViewBag.Id = recieverUser.UserName;
            //    messageService.SendMessage(currentUser, recieverUser, vm.MessageText);
            //    await hubContext.Clients.Client(recieverUser.ConnectionId).SendAsync("RecieveMessage", vm.MessageText);
            //    return RedirectToAction("SendMessage", new { userId = vm.RecieverId });
            //}
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
