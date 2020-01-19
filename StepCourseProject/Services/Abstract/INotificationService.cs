using StepCourseProject.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StepCourseProject.Services.Abstract
{
    public interface INotificationService
    {
        void CreateNotification(Notification n);
    }
}
