using StepCourseProject.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StepCourseProject.Models
{
    public class ProfileVM
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public string UserName { get; set; }
        public string Description { get; set; }
        public int Age { get; set; }
        public DateTime BirthDay { get; set; }
        public int Experiance { get; set; }
        public string GitHubLink { get; set; }
        public string WebSiteLink { get; set; }
        public List<Skill> Skills { get; set; }
        public string ImageUrl { get; set; }
        public string Role { get; set; }
    }
}
