using AQ1.Model.Models;
using AQ1.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AQ1.Web.infrastructure.Extentions
{
    public static class EntityExtentions
    {
        public static void UpdateNewsletterCategory(this NewsletterCategory newsletterCategory, NewsletterCategoryViewModel newsletterCategoryViewModel)
        {
            newsletterCategory.ID = newsletterCategoryViewModel.ID;
            newsletterCategory.Name = newsletterCategoryViewModel.Name;
            newsletterCategory.Description = newsletterCategoryViewModel.Description;
            newsletterCategory.Alias = newsletterCategoryViewModel.Alias;
            newsletterCategory.ParentID = newsletterCategoryViewModel.ParentID;
            newsletterCategory.DisplayOrder = newsletterCategoryViewModel.DisplayOrder;
            newsletterCategory.Image = newsletterCategoryViewModel.Image;
            newsletterCategory.HomeFlag = newsletterCategoryViewModel.HomeFlag;

            newsletterCategory.CreatedDate = newsletterCategoryViewModel.CreatedDate;
            newsletterCategory.CreatedBy = newsletterCategoryViewModel.CreatedBy;
            newsletterCategory.UpdatedDate = newsletterCategoryViewModel.UpdatedDate;
            newsletterCategory.UpdatedBy = newsletterCategoryViewModel.UpdatedBy;
            newsletterCategory.MetaKeyword = newsletterCategoryViewModel.MetaKeyword;
            newsletterCategory.MetaDescription = newsletterCategoryViewModel.MetaDescription;
            newsletterCategory.Status = newsletterCategoryViewModel.Status;
        }

        public static void UpdateNewsletter(this Newsletter newsletter,NewsletterViewModel newsletterViewModel)
        {
            newsletter.ID = newsletterViewModel.ID;
            newsletter.Name = newsletterViewModel.Name;
            newsletter.Description = newsletterViewModel.Description;
            newsletter.Alias = newsletterViewModel.Alias;
            newsletter.CategoryID = newsletterViewModel.CategoryID;
            newsletter.Image = newsletterViewModel.Image;
            newsletter.HomeFlag = newsletterViewModel.HomeFlag;
            newsletter.ViewCount = newsletterViewModel.ViewCount;

            newsletter.CreatedDate = newsletterViewModel.CreatedDate;
            newsletter.CreatedBy = newsletterViewModel.CreatedBy;
            newsletter.UpdatedDate = newsletterViewModel.UpdatedDate;
            newsletter.UpdatedBy = newsletterViewModel.UpdatedBy;
            newsletter.MetaKeyword = newsletterViewModel.MetaKeyword;
            newsletter.MetaDescription = newsletterViewModel.MetaDescription;
            newsletter.Status = newsletterViewModel.Status;
        }
    }
}