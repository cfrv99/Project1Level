using Microsoft.AspNetCore.Mvc;
using StepCourseProject.Entites.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StepCourseProject.ViewComponents
{
    public class LeftFilterMenuViewComponent : ViewComponent
    {
        private readonly AppDbContext context;

        public LeftFilterMenuViewComponent(AppDbContext context)
        {
            this.context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {

            return View();
        }
    }
}
