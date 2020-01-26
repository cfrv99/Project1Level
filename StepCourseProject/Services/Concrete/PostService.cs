using Microsoft.EntityFrameworkCore;
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
    public class PostService : IPostService
    {
        private readonly AppDbContext context;

        public PostService(AppDbContext context)
        {
            this.context = context;
        }
        public List<AllPostViewModel> AllPostInMainPage()
        {
            var data = context.Posts.Include(i => i.AppUser)
                    .Include(i => i.Bids)
                    .Include(i => i.Skill)
                    .Select(i => new AllPostViewModel
                    {
                        Id = i.Id,
                        PostName = i.PostName,
                        PostDesc = i.PostDescription,
                        PostDate = i.PostDate,
                        PostDeadLine = i.PostDeadLine,
                        PostUserId = i.AppUserId,
                        PostUserName = i.AppUser.UserName,
                        CountBids = i.Bids.Count(),
                        EndPrice = i.EndPrice,
                        SkillName = i.Skill.SkillName,
                        StartPrice = i.StartPrice,
                        SkillId = i.SkillId
                    }).ToList();
            return data;
        }
        public void CreatePostFromClient(Post post, Skill skill,AppUser user)
        {
            Post p = new Post
            {
                PostName = post.PostName,
                PostDate = post.PostDate,
                PostDeadLine = post.PostDeadLine,
                PostDescription = post.PostDescription,
                EndPrice = post.EndPrice,
                StartPrice = post.StartPrice,
                AppUserId = user.Id,
                SkillId = skill.Id
                
            };
            context.Posts.Add(p);
            context.SaveChanges();
            
        }

        public DetailViewModel GetPostDetail(int id)
        {
            var data = context.Posts.Where(i => i.Id == id)
                .Include(i => i.AppUser)
                .Include(i => i.Bids)
                .Include(i => i.Skill)
                .Select(i => new DetailViewModel
                {
                    Id = i.Id,
                    PostName = i.PostName,
                    PostSkillName = i.Skill.SkillName,
                    PostDescription = i.PostDescription,
                    PostStartPrice = i.StartPrice,
                    PostEndPrice = i.EndPrice,
                    Bids = i.Bids.Where(a => a.isPublic).ToList(),
                    PostDate = i.PostDate,
                    PostDeadLine = i.PostDeadLine,
                    UserId = i.AppUser.Id,
                    UserName = i.AppUser.UserName
                }).FirstOrDefault();
            return data;
        }

        //Client
        public List<Post> GetYourPosts(AppUser currentUser)
        {
            var data = context.Posts
                .Include(i=>i.Skill)
                .Include(i=>i.Bids)
                .ThenInclude(i=>i.AppUser)
                .Include(i=>i.AppUser)
                .Where(i => i.AppUserId == currentUser.Id)
                .ToList();

            return data;
        }

        
    }
}
