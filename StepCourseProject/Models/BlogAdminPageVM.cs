using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StepCourseProject.Models
{
    public class BlogAdminPageVM
    {
        public int BlogId { get; set; }
        public string BlogName { get; set; }
        public string BlogUrl { get; set; }
        public DateTime BlogDate  { get; set; }
        public string BlogDesc { get; set; }
        public string ImageUrl { get; set; }
    }
}
