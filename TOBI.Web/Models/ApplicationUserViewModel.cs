using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TOBI.Web.Models
{
    public class ApplicationUserViewModel
    {
        public Guid Account_id { get; set; }

        public string UserName { get; set; }

        public string PasswordHash { get; set; }

        public string User_id { get; set; }
        public string id { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
                   
        public string History_id { get; set; }

        public int? TotalAmount { get; set; }
        public int AccessFailedCount { get; set; }
        public string Address { get; set; }
        public DateTime BirthDay { get; set; }
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
        public string Password { get; set; }
    }
}