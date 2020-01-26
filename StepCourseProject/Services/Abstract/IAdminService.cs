using StepCourseProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StepCourseProject.Services.Abstract
{
    public interface IAdminService
    {
        List<BlogAdminPageVM> Blogs();
        BlogAdminPageVM GetBlog(int id);
        void Add(BlogAdminPageVM entity);
    }
}
