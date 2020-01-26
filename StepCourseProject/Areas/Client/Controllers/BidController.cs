using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StepCourseProject.Entites;
using StepCourseProject.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace StepCourseProject.Areas.Client.Controllers
{
    [Area("Client")]
    public class BidController:Controller
    {
        private IBidService _bidService;
        private UserManager<AppUser> _userManager;

        public BidController(IBidService bidService, UserManager<AppUser> userManager)
        {
            _bidService = bidService;
            _userManager = userManager;
        }

        [HttpPost]
        public IActionResult AcceptBid(int bidId, int postId)
        {
            var currentUser = _bidService.GetBidsByPostId(postId).FirstOrDefault(x => x.Id == bidId).AppUser;
            
            _bidService.AcceptBid(bidId, postId, currentUser);
            return Redirect("/Client/Home/Index");
        }
    }
}
