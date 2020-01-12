using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;
using StepCourseProject.Entites;
using StepCourseProject.Entites.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StepCourseProject.Hubs
{
    [Authorize]
    public class ChatHub:Hub
    {
        private readonly AppDbContext context;
        private readonly UserManager<AppUser> userManager;
        public static List<string> onlineUsers;
        public ChatHub(AppDbContext context,UserManager<AppUser> userManager)
        {
            this.context = context;
            this.userManager = userManager;
            onlineUsers = new List<string>();
        }
        

        public override async Task OnConnectedAsync()
        {
            var user = await userManager.FindByNameAsync(Context.User.Identity.Name);
            user.ConnectionId = Context.ConnectionId;
            user.IsOnline = true;
            onlineUsers.Add(user.UserName);
            
            await userManager.UpdateAsync(user);
            await base.OnConnectedAsync();
        }

        

        public override async Task OnDisconnectedAsync(Exception exception)
        {
            var user = await userManager.FindByNameAsync(Context.User.Identity.Name);
            user.IsOnline = false;
            await userManager.UpdateAsync(user);

            await base.OnDisconnectedAsync(exception);
        }
    }
}
