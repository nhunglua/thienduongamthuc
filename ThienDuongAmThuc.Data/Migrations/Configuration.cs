namespace ThienDuongAmThuc.Data.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Model.Models;
    using System;
    using System.Collections.Generic;
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
            creatProductCategorySimple(context);
            ////  This method will be called after migrating to the latest version.
            //var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ThienDuongAmThucDbContext()));

            //var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new ThienDuongAmThucDbContext()));

            //var user = new ApplicationUser()
            //{
            //    UserName = "VietFood",
            //    Email = "lenhungth9x@gmail.com",
            //    EmailConfirmed = true,
            //    Birthday = DateTime.Now,
            //    FullName ="NhungLT"
            //};
            //manager.Create(user, "123654$");
            //if (!roleManager.Roles.Any())
            //{
            //    roleManager.Create(new IdentityRole { Name = "Admin" });
            //    roleManager.Create(new IdentityRole { Name = "User" });
            //}
            //var adminUser = manager.FindByEmail("lenhungth9x@gmail.com");
            //manager.AddToRoles(adminUser.Id, new string[] { "Admin", "User" });
        }
        private void creatProductCategorySimple(ThienDuongAmThuc.Data.ThienDuongAmThucDbContext context)
        {
            if (context.ProductCategories.Count() == 0)
            {
                List<ProductCategory> listProductCategory = new List<ProductCategory>()
            {
                new ProductCategory() { Name="ĐIện lạnh", Alias="dien-lanh", Status=true },
                 new ProductCategory() { Name="Viễn thông", Alias="vien-thong", Status=true },
                  new ProductCategory() { Name="Đồ gia dụng", Alias="do-gia-dung", Status=true },
                   new ProductCategory() { Name="Mỹ phẩm", Alias="my-pham", Status=true }

            };
                context.ProductCategories.AddRange(listProductCategory);
                context.SaveChanges();
            }
           
        }
    }
}
