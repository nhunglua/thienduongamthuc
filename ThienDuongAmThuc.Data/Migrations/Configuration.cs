namespace ThienDuongAmThuc.Data.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Model.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ThienDuongAmThuc.Data.ThienDuongAmThucDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ThienDuongAmThuc.Data.ThienDuongAmThucDbContext context)
        {
            //  This method will be called after migrating to the latest version.
            var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ThienDuongAmThucDbContext()));

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new ThienDuongAmThucDbContext()));

            var user = new ApplicationUser()
            {
                UserName = "VietFood",
                Email = "lenhungth9x@gmail.com",
                EmailConfirmed = true,
                Birthday = DateTime.Now,
                FullName ="NhungLT"
            };
            manager.Create(user, "123654$");
            if (!roleManager.Roles.Any())
            {
                roleManager.Create(new IdentityRole { Name = "Admin" });
                roleManager.Create(new IdentityRole { Name = "User" });
            }
            var adminUser = manager.FindByEmail("lenhungth9x@gmail.com");
            manager.AddToRoles(adminUser.Id, new string[] { "Admin", "User" });
        }
    }
}
