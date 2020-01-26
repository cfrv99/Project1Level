using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StepCourseProject.Entites
{
    public class Blog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ImageUrl { get; set; }
        public string BlogUrl { get; set; }
    }
}
