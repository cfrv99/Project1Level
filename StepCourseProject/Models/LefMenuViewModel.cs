using StepCourseProject.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StepCourseProject.Models
{
    public class LeftMenuViewModel
    {
        public string UserId { get; set; }
        public string ImageUrl { get; set; }
        public string FullName { get; set; }
        public string UserName { get; set; }
        public List<UserSkill> Skills { get; set; }
        public int Experiance { get; internal set; }
    }
}
