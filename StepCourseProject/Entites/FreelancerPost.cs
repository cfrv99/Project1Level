using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StepCourseProject.Entites
{
    public class FreelancerPost
    {
        
        public string FeelancerId { get; set; }

        public int PostId { get; set; }

        [ForeignKey("FreelancerId")]
        public AppUser Freelancer { get; set; }
        [ForeignKey("PostId")]
        public Post Post { get; set; }
    }
}
