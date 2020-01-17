﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using StepCourseProject.Entites;
using StepCourseProject.Entites.Contexts;
using StepCourseProject.Hubs;
using StepCourseProject.Models;
using StepCourseProject.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StepCourseProject.Controllers
{
    [Authorize]
    public class MessageController : Controller
    {
        private readonly UserManager<AppUser> userManager;
        private readonly IMessageService messageService;
        private readonly AppDbContext context;
        private readonly IHubContext<ChatHub> hubContext;

        public MessageController(
            UserManager<AppUser> userManager,
            IMessageService messageService,
            AppDbContext context,
            IHubContext<ChatHub> hubContext
            )
        {
            this.userManager = userManager;
            this.messageService = messageService;
            this.context = context;
            this.hubContext = hubContext;
        }

        [HttpGet("/message/{userId}")]
        public async Task<IActionResult> SendMessage(string userId)
        {
            var user = await userManager.GetUserAsync(User);
            var recieverUser = await userManager.FindByIdAsync(userId);
            ViewBag.UserId = userId;
            var messagesByUser = context.Messages.Include(i => i.SenderUser)
                .Include(i => i.RecieverUser)
                .Where(i => (i.SenderUserId == user.Id && i.RecieverUserId == userId) || (i.SenderUserId == userId && i.RecieverUserId == user.Id))
                .OrderBy(i => i.MessageDate)
                .ToList();

            SendMessageViewModel vm = new SendMessageViewModel
            {
                Messages = messagesByUser
            };

            return View(vm);
        }

        [HttpPost]

        public async Task<IActionResult> Send(SendMessageViewModel vm, string recieverId)
        {
            var currentUser = await userManager.GetUserAsync(User);
            var recieverUser = await userManager.FindByIdAsync(recieverId);

            if (ModelState.IsValid)
            {

                messageService.SendMessage(currentUser, recieverUser, vm.Message.MessageText);
                await hubContext.Clients.Client(recieverUser.ConnectionId).SendAsync("RecieveMessage", vm.Message.MessageText);

                return RedirectToAction("SendMessage", new { userId = recieverId });
            }
            return RedirectToAction("Message", "SendMessage", new { userId = recieverId });
            
        }




    }
}
