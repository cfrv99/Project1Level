using StepCourseProject.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StepCourseProject.Services.Abstract
{
    public interface IBidService
    {

        void AcceptBid(int bidId,int postId,AppUser currentUser);
        void CreateBidToProject(Post post, Bid bid,AppUser user);
        List<Bid> GetBidsByPostId(int postId);
    }
}
