using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StepCourseProject.Models
{
    public class FreelancerOwnPostVM
    {
        public int Id { get; set; }
        public string PostName { get; set; }
        public string PostDescription { get; set; }
        public string PostAuthorName { get; set; }
        public string PostAuthorId { get; set; }
        public DateTime PostDeadLine { get; set; }
        public decimal PostPrice { get; set; }
    }
}
