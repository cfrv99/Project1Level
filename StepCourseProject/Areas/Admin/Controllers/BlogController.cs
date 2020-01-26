using Microsoft.AspNetCore.Mvc;
using StepCourseProject.Models;
using StepCourseProject.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StepCourseProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BlogController : Controller
    {
        private readonly IAdminService adminService;

        public BlogController(IAdminService adminService)
        {
            this.adminService = adminService;
        }

        public IActionResult Blogs()
        {
            var blogs = adminService.Blogs();
            return View(blogs);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View(new BlogAdminPageVM());
        }
        [HttpPost]
        public IActionResult Create(BlogAdminPageVM vm)
        {
            adminService.Add(vm);
            return RedirectToAction("Blogs");
        }

        public IActionResult Details(int id)
        {
            var post = adminService.GetBlog(id);
            return View(post);

        }
    }
}
