using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StepCourseProject.Models
{
    public class MessageListViewModel
    {
        public int Id { get; set; }
        public string MessageText { get; set; }
        public DateTime MessageDate { get; set; }
        public string MessagerSenderName { get; set; }
    }
}
