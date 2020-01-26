using StepCourseProject.Entites;
using StepCourseProject.Entites.Contexts;
using StepCourseProject.Models;
using StepCourseProject.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StepCourseProject.Services.Concrete
{
    public class AdminService : IAdminService
    {
        private readonly AppDbContext context;

        public AdminService(AppDbContext context)
        {
            this.context = context;
        }

        public void Add(BlogAdminPageVM entity)
        {
            if (entity != null)
            {
                Blog b = new Blog
                {
                    BlogUrl = entity.BlogUrl,
                    CreatedDate = DateTime.Now,
                    Description = entity.BlogDesc,
                    ImageUrl = entity.ImageUrl,
                    Name = entity.BlogName
                };
                context.Blogs.Add(b);
                context.SaveChanges();
            }
        }

        public List<BlogAdminPageVM> Blogs()
        {
            return context.Blogs.Select(i => new BlogAdminPageVM
            {
                BlogId = i.Id,
                BlogName = i.Name,
                BlogDate = i.CreatedDate,
                BlogDesc = i.Description,
                BlogUrl = i.BlogUrl,
                ImageUrl = i.ImageUrl
            }).ToList();
        }

        public BlogAdminPageVM GetBlog(int id)
        {
            return context.Blogs.Where(i => i.Id == id).Select(i => new BlogAdminPageVM
            {
                ImageUrl=i.ImageUrl,
                BlogId=i.Id,
                BlogDate=i.CreatedDate,
                BlogDesc=i.Description,
                BlogName=i.Name,
                BlogUrl=i.BlogUrl
            }).FirstOrDefault();
        }
    }
}
