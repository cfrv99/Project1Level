using StepCourseProject.Entites;
using StepCourseProject.Entites.Contexts;
using StepCourseProject.Entites.Enums;
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
            if (bid.IsDone == true)
            {
                post.HaveIsDoneBid = true;
            }
            bid.Status = BidStatus.Accepted;

            //var stayingBids = context.Bids.Where(i => i.Id != bidId && i.PostId != postId).ToList();
            //foreach (var item in stayingBids)
            //{
            //    item.Status = BidStatus.Decline;
            //}
            context.SaveChanges();

            Notification n = new Notification
            {
                PostId = postId,
                NotificationText = $"{currentUser.UserName} accepted your bid to project",
                FromUserName = currentUser.UserName,
                AppUserId = bid.AppUserId,
                IsRead = false
            };
            context.Notifications.Add(n);

            context.FreelancerPosts.Add(new FreelancerPost { PostId = postId, FreelancerId = bid.AppUserId }); //baxilacaq
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
                Status=Entites.Enums.BidStatus.Waiting,
                isPublic = bid.isPublic,
                PostId = post.Id
            };
            context.Bids.Add(b);

            Notification n = new Notification()
            {
                FromUserName = user.UserName,
                AppUserId = post.AppUserId,
                PostId = post.Id,
                NotificationText = $"{user.UserName} applyed your {post.PostName} project",
                IsRead = false
            };

            context.Notifications.Add(n);
            context.SaveChanges();
        }

        public List<Bid> GetBidsByPostId(int postId)
        {
            return context.Bids.Where(i => i.PostId == postId).ToList();
        }
    }
}
