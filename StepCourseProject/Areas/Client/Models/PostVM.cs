using StepCourseProject.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StepCourseProject.Areas.Client.Models
{
    public class PostViewModel
    {
       
        public int Id { get; set; }
        public string PostName { get; set; }
        public DateTime PostDate { get; set; } = DateTime.Now;
        public DateTime PostDeadLine { get; set; }
        public string PostDescription { get; set; }
        public decimal StartPrice { get; set; }
        public decimal EndPrice { get; set; }
        public string AppUserId { get; set; }
        public int SkillId { get; set; }
        public string SkillName { get; set; }
    }
}
