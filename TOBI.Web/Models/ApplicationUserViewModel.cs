using System;
using System.Collections.Generic;

namespace TOBI.Web.Models
{
    public class ApplicationUserViewModel
    {
        // "Claims": [],
        //public string Id { get; set; }
        //"Logins": [],
        //public string Id { get; set; }
        //"Roles": [],
        public string History_id { get; set; }
        public string Id { get; set; }
        public string TotalAmount { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public DateTime BirthDay { get; set; }
        public string Avatar { get; set; }
        public string Page { get; set; }
        public int Cost { get; set; }
        public int Evaluate { get; set; }
        public int Startus { get; set; }
        public int Refuse { get; set; }
        public int Finish { get; set; }
        public string Email { get; set; }
        public string EmailConfirmed { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public string TwoFactorEnabled { get; set; }
        public bool LockoutEndDateUtc { get; set; }
        public int LockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }
        public string UserName { get; set; }
        public string Password { set; get; }

        public IEnumerable<ApplicationGroupViewModel> Groups { set; get; }
    }
}