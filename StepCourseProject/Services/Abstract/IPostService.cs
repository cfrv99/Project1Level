using StepCourseProject.Entites;
using StepCourseProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StepCourseProject.Services.Abstract
{
    public interface IPostService
    {
        void CreatePostFromClient(Post post, Skill skill, AppUser user);
        List<Post> GetYourPosts(AppUser currentUser);
        List<AllPostViewModel> AllPostInMainPage();
        DetailViewModel GetPostDetail(int id);
    }
}
