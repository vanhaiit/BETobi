namespace TOBI.Model.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TOBI.Model.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<TOBI.Model.Models.TOBIDbConText>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }
        protected override void Seed(TOBI.Model.Models.TOBIDbConText context)
        {
            //var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new TOBIDbConText()));

            //var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new TOBIDbConText()));

            //var user = new ApplicationUser()
            //{
            //    UserName = "admin",
            //    Email = "vanhaiit@gmail.com",
            //    EmailConfirmed = true,
            //    BirthDay = DateTime.Now,
            //    FullName = "Van hai IT",
            //};

            //manager.Create(user, "123456");

            //if (!roleManager.Roles.Any())
            //{
            //    roleManager.Create(new IdentityRole { Name = "Admin" });
            //    roleManager.Create(new IdentityRole { Name = "User" });
            //}

            //var adminUser = manager.FindByEmail("vanhaiit@gmail.com");

            //manager.AddToRoles(adminUser.Id, new string[] { "Admin", "User" });

        }
    }
}
