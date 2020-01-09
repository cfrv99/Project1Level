using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using StepCourseProject.Entites;

namespace StepCourseProject
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var host = CreateWebHostBuilder(args).Build();
            using (var container = host.Services.CreateScope())
            {
                var userManager = container.ServiceProvider.GetRequiredService<UserManager<AppUser>>();
                var roleManager = container.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
                var configuration = container.ServiceProvider.GetRequiredService<IConfiguration>();

                if (!await roleManager.RoleExistsAsync("Admin"))
                {
                    var result = await roleManager.CreateAsync(new IdentityRole { Name = "Admin" });
                    if (!result.Succeeded)
                        throw new Exception(result.Errors.First().Description);
                }
                if (!await roleManager.RoleExistsAsync("Freelancer"))
                {
                    var result = await roleManager.CreateAsync(new IdentityRole { Name = "Freelancer" });

                    if (!result.Succeeded)
                    {
                        throw new Exception(result.Errors.First().Description);
                    }
                }

                if (!await roleManager.RoleExistsAsync("Client"))
                {
                    var result = await roleManager.CreateAsync(new IdentityRole { Name = "Client" });

                    if (!result.Succeeded)
                    {
                        throw new Exception(result.Errors.First().Description);
                    }
                }

                var adminLogin = configuration["AdminAccount:Login"];
                var adminPassword = configuration["AdminAccount:Password"];

                var user = userManager.FindByNameAsync(adminLogin);
                if (user == null)
                {
                    AppUser u = new AppUser
                    {
                        UserName = adminLogin,
                        Email = "admin@freelancer.com",
                        FullName = "Admin"
                    };

                    var result = await userManager.CreateAsync(u, adminPassword);

                    if (!result.Succeeded)
                        throw new Exception(result.Errors.First().Description);

                    result = await userManager.AddToRoleAsync(u, "Admin");
                    if (!result.Succeeded)
                        throw new Exception(result.Errors.First().Description);
                }
            }


            CreateWebHostBuilder(args).Build().Run();


        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
