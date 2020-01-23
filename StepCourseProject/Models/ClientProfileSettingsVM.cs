using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StepCourseProject.Models
{
    public class ClientProfileSettingsVM
    {
        public string ClientId { get; set; }
        public string ClientName { get; set; }
        public string ClientImageUrl { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public string Company { get; set; }
        public string Description { get; set; }
    }
}
