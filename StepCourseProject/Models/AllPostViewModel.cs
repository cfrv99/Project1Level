using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StepCourseProject.Models
{
    public class AllPostViewModel
    {
        public int Id { get; set; }
        public string PostName { get; set; }
        public string PostDesc { get; set; }
        public decimal StartPrice { get; set; }
        public decimal EndPrice { get; set; }
        public string SkillName { get; set; }
        public int CountBids { get; set; }
        public DateTime PostDate { get; set; }
        public DateTime PostDeadLine { get; set; }
        public string PostUserName { get; set; }
        public string PostUserId { get; set; }

    }
}
