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


        public HomeController(UserManager<AppUser> userManager, IHubContext<ChatHub> hubContext)
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







            //document.getElementById("sendButton").addEventListener("click", function(event) {
            //var message = document.getElementById("txtText").value;
            ////var user = document.getElementById("userInput").value;
            //var userId = @userName;
            //connection.invoke("SendMessage", message).catch (function (err) {
            //    return console.error(err.toString());
            //});
            //    event.preventDefault();
            //});

    //document.getElementById("send").addEventListener("click", function (event) {
    //    var messages = {
    //        MessageText: document.getElementById("txtText").value,
    //        RecieverId: document.getElementById("recieverId").value
    //    }

    //    var p = document.getElementById("rrr");
    //    $.ajax({
    //        type: "POST",
    //        url: "/Message/Send",
    //        data: messages,
    //        success: function (data) {
    //            console.log(messages.MessageText);
    //            var text = document.createTextNode(messages.MessageText);
    //            p.appendChild(text);

    //        }

    //    });
    //});
            return View();
}

public IActionResult Privacy()
{
    var onlineUsers = userManager.Users.Where(i => i.IsOnline == true).ToList();

    ViewBag.a = ChatHub.onlineUsers;

    return View(onlineUsers);
}

[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
public IActionResult Error()
{
    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
}
    }
}
