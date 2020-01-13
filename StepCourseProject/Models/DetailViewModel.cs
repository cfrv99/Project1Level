using StepCourseProject.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StepCourseProject.Models
{
    public class DetailViewModel
    {
        public int Id { get; set; }

        public string PostName { get; set; }

        public int PostId { get; set; }

        public string PostSkillName { get; set; }

        public string PostDescription { get; set; }

        public decimal PostStartPrice { get; set; }

        public decimal PostEndPrice { get; set; }

        public DateTime PostDate { get; set; }

        public string UserId { get; set; }

        public string UserName { get; set; }

        public DateTime PostDeadLine { get; set; }

        public List<Bid> Bids { get; set; }

        public Bid CreateBid { get; set; }

    }
}
