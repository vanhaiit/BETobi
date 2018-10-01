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

        public string History_id { get; set; }

        public int? TotalAmount { get; set; }
    }
}