using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StepCourseProject.Entites;
using StepCourseProject.Entites.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StepCourseProject.Areas.Admin.ViewComponents
{
    public class NotificationViewComponent:ViewComponent
    {

        private readonly AppDbContext context;
        private readonly UserManager<AppUser> userManager;

        public NotificationViewComponent(AppDbContext context,UserManager<AppUser> userManager)
        {
            this.context = context;
            this.userManager = userManager;
        }

        public async  Task<IViewComponentResult> InvokeAsync()
        {
            var user = await userManager.FindByNameAsync("Admin");

            var data = context.Notifications.Include(i=>i.AppUser).Where(i => i.AppUserId == user.Id).Take(5);
            ViewBag.Count = context.Notifications.Where(i => i.IsRead==false).Count();
            return View(data);
        }
    }
}
