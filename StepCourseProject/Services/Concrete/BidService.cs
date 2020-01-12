using StepCourseProject.Entites;
using StepCourseProject.Entites.Contexts;
using StepCourseProject.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StepCourseProject.Services.Concrete
{
    public class BidService : IBidService
    {
        private readonly AppDbContext context;

        public BidService(AppDbContext context)
        {
            this.context = context;
        }

        public void AcceptBid(int bidId, int postId, AppUser currentUser)
        {
            var bid = context.Bids.Where(i => i.Id == bidId && i.PostId == postId)
                .FirstOrDefault();
            bid.IsDone = true;
            var post = context.Posts.Where(i => i.Id == postId).FirstOrDefault();
            post.HaveIsDoneBid = true;
            context.SaveChanges();

            Notification n = new Notification
            {
                PostId = postId,
                NotificationText = $"{currentUser.UserName} accept your bid to project",
                FromUserName = currentUser.UserName,
                AppUserId = bid.AppUserId,
                IsRead = false
            };
            context.Notifications.Add(n);
            context.SaveChanges();
        }

        public void CreateBidToProject(Post post, Bid bid, AppUser user)
        {
            Bid b = new Bid
            {
                AppUserId = user.Id,
                BidBody = bid.BidBody,
                BidDate = bid.BidDate,
                BidPrice = bid.BidPrice,
                IsDone = false,
                isPublic = bid.isPublic,
                PostId = post.Id
            };
            context.Bids.Add(b);
            context.SaveChanges();
        }

        public List<Bid> GetBidsByPostId(int postId)
        {
            return context.Bids.Where(i => i.PostId == postId).ToList();
        }
    }
}
