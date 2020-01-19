using StepCourseProject.Entites;
using StepCourseProject.Entites.Contexts;
using StepCourseProject.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StepCourseProject.Services.Concrete
{
    public class NotificationService : INotificationService
    {
        private readonly AppDbContext context;

        public NotificationService(AppDbContext context)
        {
            this.context = context;
        }

        public void CreateNotification(Notification n)
        {

            Notification notification = new Notification()
            {
                PostId = n.PostId,
                IsRead = n.IsRead,
                NotificationText = n.NotificationText,
                AppUserId = n.AppUserId,
                FromUserName = n.FromUserName
            };
            context.Notifications.Add(notification);
            context.SaveChanges();
           
        }
    }
}
