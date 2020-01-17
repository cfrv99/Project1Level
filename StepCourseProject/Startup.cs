using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using StepCourseProject.Entites;
using StepCourseProject.Entites.Contexts;
using StepCourseProject.Extensions;
using StepCourseProject.Hubs;
using StepCourseProject.Repository.Abstract;
using StepCourseProject.Repository.Concrete;
using StepCourseProject.Services.Abstract;
using StepCourseProject.Services.Concrete;

namespace StepCourseProject
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
           // services.AddTransient<ICategoryService, CategoryService>();
            services.AddTransient<ICategoryRepo, CategoryRepository>();
            services.AddTransient<ISkillRepo, SkillRepository>();
            services.AddTransient<IPostRepo, PostRepository>();
            services.AddTransient<IBidService, BidService>();
            services.AddTransient<IMessageService, MessageService>();
            services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            //services.AddAuthentication();
            services.AddAuthorization();
            services.AddIdentity<AppUser, IdentityRole>().AddEntityFrameworkStores<AppDbContext>()
                .AddDefaultTokenProviders();
            //services.AddSignalR();
            services.AddSignalR().AddJsonProtocol(options =>
            {
                options.PayloadSerializerSettings.NullValueHandling = NullValueHandling.Ignore;
                options.PayloadSerializerSettings.DateTimeZoneHandling = DateTimeZoneHandling.Utc;
                options.PayloadSerializerSettings.ContractResolver = new DefaultContractResolver();
            });
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseAuthentication();
            app.UseSignalR(routes =>
            {
                routes.MapHub<ChatHub>("/not");
            });
            app.UseRouter(new FileRouter(env));
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");


                routes.MapRoute(
                    name: "areas",
                    template: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

            });
        }
    }
}
