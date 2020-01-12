using StepCourseProject.Entites;
using StepCourseProject.Entites.Contexts;
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

        public List<Post> GetYourPosts(AppUser currentUser)
        {
            var data = context.Posts
                .Where(i => i.AppUserId == currentUser.Id)
                .ToList();

            return data;
        }

        
    }
}
