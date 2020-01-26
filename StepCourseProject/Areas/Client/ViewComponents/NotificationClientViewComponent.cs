using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StepCourseProject.Entites;
using StepCourseProject.Entites.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StepCourseProject.Areas.Client.ViewComponents
{
    public class NotificationClientViewComponent:ViewComponent
    {

        private readonly AppDbContext context;
        private readonly UserManager<AppUser> userManager;

        public NotificationClientViewComponent(AppDbContext context, UserManager<AppUser> userManager)
        {
            this.context = context;
            this.userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var currentUserName = User.Identity.Name;
            var currentUser = await userManager.FindByNameAsync(currentUserName);
            var data = context.Notifications.Include(i => i.AppUser).Where(i => i.AppUserId == currentUser.Id).ToList();
            ViewBag.Count = data.Where(i => i.IsRead == false).Count();
            data=data.Take(5).ToList();
            return View(data);
        }
    }
}
