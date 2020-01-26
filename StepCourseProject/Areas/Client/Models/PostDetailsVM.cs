using StepCourseProject.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace StepCourseProject.Areas.Client.Models
{
    public class PostDetailsVM
    {
        public int PostId { get; set; }
        public string PostName { get; set; }
        public string BidName { get; set; }
        public string BidDescription { get; set; }
        public List<Bid> Bids { get; set; }
    }
}
