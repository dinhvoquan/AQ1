namespace AQ1.Data.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Model.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AQ1.Data.AQ1DbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AQ1.Data.AQ1DbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new AQ1DbContext()));
            var rolemanager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new AQ1DbContext()));

            var user = new ApplicationUser()
            {
                UserName = "quandv",
                Email = "dinhvoquan@gmail.com",
                EmailConfirmed = true,
                BirthDay = DateTime.Now,
                FullName="Đinh Võ Quan"
            };

            manager.Create(user, "1Dinh@Quan2");
            if (!rolemanager.Roles.Any())
            {
                rolemanager.Create(new IdentityRole { Name = "Admin" });
                rolemanager.Create(new IdentityRole { Name = "User" });
            }

            var adminUser = manager.FindByEmail("dinhvoquan@gmail.com");
            manager.AddToRoles(adminUser.Id, new string[] { "Admin", "User" });
        }
    }
}
