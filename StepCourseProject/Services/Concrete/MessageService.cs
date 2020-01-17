using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using MoreLinq;
using StepCourseProject.Entites;
using StepCourseProject.Entites.Contexts;
using StepCourseProject.Models;
using StepCourseProject.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StepCourseProject.Services.Concrete
{
    public class MessageService : IMessageService
    {
        private readonly AppDbContext context;
        private readonly UserManager<AppUser> userManager;

        public MessageService(AppDbContext context, UserManager<AppUser> userManager)
        {
            this.context = context;
            this.userManager = userManager;
        }

        public Message GetMessage(int id)
        {
            var message = context.Messages.FirstOrDefault(i => i.Id == id);

            return message;
        }

        public List<MessageListViewModel> GetMessagesByCurrentUser(AppUser currentUser)
        {
            var messagesByCurrentUser = context.Messages
                .Include(i => i.RecieverUser)
                .Include(i => i.SenderUser)
                .Where(i => i.RecieverUserId == currentUser.Id || i.SenderUserId == currentUser.Id)
                .Select(i => new MessageListViewModel
                {
                    Id = i.Id,
                    MessagerSenderName = i.RecieverUser.UserName,
                    MessageText = i.MessageText
                })
                .OrderBy(i=>i.MessageDate)
                .DistinctBy(i=>i.MessagerSenderName)               
                .ToList();


            
            return messagesByCurrentUser;
        }

        public void SendMessage(AppUser senderUser, AppUser recieverUser, string messageText)
        {
            Message m = new Message()
            {
                RecieverUserId = recieverUser.Id,
                SenderUserId = senderUser.Id,
                MessageText = messageText,
                MessageDate = DateTime.Now
            };
            context.Messages.Add(m);
            context.SaveChanges();
        }


    }
}
