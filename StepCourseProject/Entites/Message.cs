using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StepCourseProject.Entites
{
    public class Message
    {
        public int Id { get; set; }
        public string SenderId { get; set; }
        public string SenderConnectionId { get; set; }
        public string RecieverConnectionId { get; set; }
        public AppUser SenderUser { get; set; }
        public string MessageText { get; set; }
        public string RecieverId { get; set; }
        public AppUser RecieverUser { get; set; }

    }
}
