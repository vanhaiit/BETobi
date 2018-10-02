using TOBI.Model.Models;
using System;
using TOBI.Web.Models;

namespace TOBI.Web.Infrastructure.Extensions
{
    public static class EntityExtensisons
    {
        public static void UpdateUser(this ApplicationUser appUser, ApplicationUserViewModel appUserViewModel, string action = "add")
        {

            appUser.Id = appUserViewModel.id;
            appUser.AccessFailedCount = appUserViewModel.AccessFailedCount;
            appUser.Address = appUserViewModel.Address;
            appUser.BirthDay = appUserViewModel.BirthDay;
            appUser.Email = appUserViewModel.Email;
            appUser.EmailConfirmed = appUserViewModel.EmailConfirmed;
           

        }
    }
}