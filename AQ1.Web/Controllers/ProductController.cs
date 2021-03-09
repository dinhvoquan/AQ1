using AQ1.Model.Models;
using AQ1.Service;
using AQ1.Web.Infrastructure.Core;
using AQ1.Web.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AQ1.Web.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        //IProductService _productService;
        //IProductCategoryService _productCategoryService;
        //public ProductController(IProductService productService, IProductCategoryService productCategoryService)
        //{
        //    this._productService = productService;
        //    this._productCategoryService = productCategoryService;
        //}
        IProductService _productService;
        IProductCategoryService _productCategoryService;
        public ProductController(IProductService productService, IProductCategoryService productCategoryService)
        {
            this._productService = productService;
            this._productCategoryService = productCategoryService;
        }

        public ActionResult Detail(int productId)
        {
            return View();
        }

        public ActionResult Category(int id, int page = 1)
        {
            //int pageSize = 3;
            //int totalRow = 0;
            //var productModel = _productService.GetListProductByCategoryIdPaging(id, page, pageSize, out totalRow);
            //var productViewModel = Mapper.Map<IEnumerable<Product>, IEnumerable<ProductViewModel>>(productModel);
            //int totalPage = (int)Math.Ceiling((double)totalRow / pageSize);

            //var category = _productCategoryService.GetById(id);
            //ViewBag.Category = Mapper.Map<ProductCategory, ProductCategoryViewModel>(category);
            //var paginationSet = new PaginationSet<ProductViewModel>()
            //{
            //    Items = productViewModel,
            //    MaxPage = 5,
            //    Page = page,
            //    TotalCount = totalRow,
            //    TotalPages = totalPage
            //};
            //return View(paginationSet);
            int pageSize = 3;
            int totalRow = 0;
            var productModel = _productService.GetListProductByCategoryIdPaging(id, page, pageSize, out totalRow);
            var productViewModel = Mapper.Map<IEnumerable<Product>, IEnumerable<ProductViewModel>>(productModel);
            int totalPage = (int)Math.Ceiling((double)totalRow / pageSize);

            var category = _productCategoryService.GetById(id);
            ViewBag.Category = Mapper.Map<ProductCategory, ProductCategoryViewModel>(category);
            var paginationSet = new PaginationSet<ProductViewModel>()
            {
                Items = productViewModel,
                MaxPage = 5,
                Page = page,
                TotalCount=totalRow,
                TotalPages=totalPage
            };
            return View(paginationSet);
        }
    }
}