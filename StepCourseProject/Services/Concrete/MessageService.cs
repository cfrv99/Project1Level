using Microsoft.EntityFrameworkCore;
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

        public MessageService(AppDbContext context)
        {
            this.context = context;
        }

        public Message GetMessage(int id)
        {
            var message = context.Messages.FirstOrDefault(i => i.Id == id);

            return message;
        }

        public List<MessageListViewModel> GetMessagesByCurrentUser(AppUser currentUser)
        {
            var messagesByCurrentUser = context.Messages.Include(i => i.RecieverUser)
                .Include(i => i.SenderUser)
                .Where(i => i.RecieverId == currentUser.Id)
                .Select(i => new MessageListViewModel
                {
                    Id = i.Id,
                    MessagerSenderName = i.SenderUser.Id,
                    MessageText = i.MessageText
                }).ToList();

            return messagesByCurrentUser;
        }

        public void SendMessage(AppUser senderUser, AppUser recieverUser, string messageText)
        {
            Message m = new Message()
            {
                RecieverId = recieverUser.Id,
                SenderId = senderUser.Id,
                SenderConnectionId = senderUser.ConnectionId,
                RecieverConnectionId = recieverUser.ConnectionId,
                MessageText = messageText
            };
            context.Messages.Add(m);
            context.SaveChanges();
        }


    }
}
