namespace AQ1.Data.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Model.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Validation;
    using System.Diagnostics;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AQ1.Data.AQ1DbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AQ1.Data.AQ1DbContext context)
        {
            //CreateProductCategorySample(context);
            //CreateSlide(context);
            //CreatePage(context);
            //CreatePage(context);
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            //var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new AQ1DbContext()));
            //var rolemanager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new AQ1DbContext()));

            //var user = new ApplicationUser()
            //{
            //    UserName = "quandv",
            //    Email = "dinhvoquan@gmail.com",
            //    EmailConfirmed = true,
            //    BirthDay = DateTime.Now,
            //    FullName="Đinh Võ Quan"
            //};

            //manager.Create(user, "1Dinh@Quan2");
            //if (!rolemanager.Roles.Any())
            //{
            //    rolemanager.Create(new IdentityRole { Name = "Admin" });
            //    rolemanager.Create(new IdentityRole { Name = "User" });
            //}

            //var adminUser = manager.FindByEmail("dinhvoquan@gmail.com");
            //manager.AddToRoles(adminUser.Id, new string[] { "Admin", "User" });
        }

        //private void CreateProductCategorySample(AQ1.Data.AQ1DbContext context)
        //{
        //    if (context.ProductCategories.Count() == 0)
        //    {
        //        List<ProductCategory> listProductCategory = new List<ProductCategory>()
        //        {
        //            new ProductCategory() { Name="Điện lạnh", Alias="dien-lanh",Status=true}
        //            //new ProductCategory() { Name = "Điện thoại", Alias = "dien-thoai", Status = true },
        //            //new ProductCategory() { Name = "Điện gia dụng", Alias = "dien-gia-dung", Status = true }
        //        };
        //        context.ProductCategories.AddRange(listProductCategory);
        //        context.SaveChanges();
        //    }
        //}

        //private void CreateSlide(AQ1.Data.AQ1DbContext context)
        //{
        //    if (context.Slides.Count() == 0)
        //    {
        //        List<Slide> listSlide = new List<Slide>()
        //        {
        //            new Slide()
        //            {
        //                Name="Slide1",
        //                DisplayOrder=1,
        //                Status=true,
        //                URL="#",
        //                Image="/Content/images/bag.jpg",
        //                Detail=@"	<h2>FLAT 50% 0FF</h2>
        //                        <label>FOR ALL PURCHASE <b>VALUE</b></label>
        //                        <p>Lorem ipsum dolor sit amet, consectetur 
        //                    adipisicing elit, sed do eiusmod tempor incididunt ut labore et </ p >
        //                <span class=""on-get"">GET NOW</span>"
        //            },
        //            new Slide()
        //            {
        //                Name="Slide2",
        //                DisplayOrder=2,
        //                Status=true,
        //                URL="#",
        //                Image="/Content/images/bag1.jpg",
        //                Detail=@"<h2>FLAT 50% 0FF</h2>
        //                        <label>FOR ALL PURCHASE <b>VALUE</b></label>

        //                        <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et </ p >

        //                        <span class=""on-get"">GET NOW</span>"
        //            },
        //        };
        //        context.Slides.AddRange(listSlide);
        //        context.SaveChanges();
        //    }
        //}

        //private void CreatePage(AQ1DbContext context)
        //{
        //    if (context.Pages.Count() == 0)
        //    {
        //        try
        //        {
        //            var page = new Page()
        //            {
        //                Name = "Giới thiệu",
        //                Alias = "gioi-thieu",
        //                Detail = @"Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium",
        //                Status = true
        //            };
        //            context.Pages.Add(page);
        //            context.SaveChanges();
        //        }
        //        catch (DbEntityValidationException ex)
        //        {
        //            foreach (var eve in ex.EntityValidationErrors)
        //            {
        //                Trace.WriteLine($"Entity of type \"{eve.Entry.Entity.GetType().Name}\" in state \"{eve.Entry.State}\" has the following validation error.");
        //                foreach (var ve in eve.ValidationErrors)
        //                {
        //                    Trace.WriteLine($"- Property: \"{ve.PropertyName}\", Error: \"{ve.ErrorMessage}\"");
        //                }
        //            }
        //        }
        //    }
        //}

        
    }
}
