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

        public static void UpdateProductCategory(this ProductCategory productCategory, ProductCategoryViewModel productCategoryViewModel)
        {
            productCategory.ID = productCategoryViewModel.ID;
            productCategory.Name = productCategoryViewModel.Name;
            productCategory.Description = productCategoryViewModel.Description;
            productCategory.Alias = productCategoryViewModel.Alias;
            productCategory.ParentID = productCategoryViewModel.ParentID;
            productCategory.DisplayOrder = productCategoryViewModel.DisplayOrder;
            productCategory.Image = productCategoryViewModel.Image;
            productCategory.HomeFlag = productCategoryViewModel.HomeFlag;

            productCategory.CreatedDate = productCategoryViewModel.CreatedDate;
            productCategory.CreatedBy = productCategoryViewModel.CreatedBy;
            productCategory.UpdatedDate = productCategoryViewModel.UpdatedDate;
            productCategory.UpdatedBy = productCategoryViewModel.UpdatedBy;
            productCategory.MetaKeyword = productCategoryViewModel.MetaKeyword;
            productCategory.MetaDescription = productCategoryViewModel.MetaDescription;
            productCategory.Status = productCategoryViewModel.Status;
        }

        public static void UpdateProduct(this Product product, ProductViewModel productViewModel)
        {
            product.ID = productViewModel.ID;
            product.Name = productViewModel.Name;
            product.Description = productViewModel.Description;
            product.Alias = productViewModel.Alias;
            product.CategoryID = productViewModel.CategoryID;
            product.Detail = productViewModel.Detail;
            product.Image = productViewModel.Image;
            product.MoreImage = productViewModel.MoreImage;
            product.Price = productViewModel.Price;
            product.Promotion = productViewModel.Promotion;
            product.Warranty = productViewModel.Warranty;
            product.HomeFlag = productViewModel.HomeFlag;
            product.ViewCount = productViewModel.ViewCount;
            product.Tags = productViewModel.Tags;

            product.CreatedDate = productViewModel.CreatedDate;
            product.CreatedBy = productViewModel.CreatedBy;
            product.UpdatedDate = productViewModel.UpdatedDate;
            product.UpdatedBy = productViewModel.UpdatedBy;
            product.MetaKeyword = productViewModel.MetaKeyword;
            product.MetaDescription = productViewModel.MetaDescription;
            product.Status = productViewModel.Status;
        }
    }
}