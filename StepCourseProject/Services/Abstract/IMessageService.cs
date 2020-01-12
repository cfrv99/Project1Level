using StepCourseProject.Entites;
using StepCourseProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StepCourseProject.Services.Abstract
{
    public interface IMessageService
    {
        void SendMessage(AppUser senderUser, AppUser recieverUser, string messageText);
        Message GetMessage(int id);
        List<MessageListViewModel> GetMessagesByCurrentUser(AppUser currentUser);
    }
}
