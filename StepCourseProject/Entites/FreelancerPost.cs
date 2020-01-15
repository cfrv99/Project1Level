using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StepCourseProject.Entites
{
    public class FreelancerPost
    {

        public string FreelancerId { get; set; }

        public AppUser Freelancer { get; set; }

        public int PostId { get; set; }

        public Post Post { get; set; }
    }
}
