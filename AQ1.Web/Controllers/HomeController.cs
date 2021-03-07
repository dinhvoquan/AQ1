using AQ1.Model.Models;
using AQ1.Service;
using AQ1.Web.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AQ1.Web.Controllers
{
    public class HomeController : Controller
    {
        IProductCategoryService _productCategoryService;
        ICommonService _commonService;
        
        public HomeController(IProductCategoryService productCategoryService,ICommonService commonService)
        {
            _productCategoryService = productCategoryService;
            _commonService = commonService;
        }
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        //Home Shoppe
        //[ChildActionOnly]
        //public ActionResult ProductCategory()
        //{
        //    var model = _productCategoryService.GetAll();
        //    var listProductCategoryViewModel = Mapper.Map<IEnumerable<ProductCategory>, IEnumerable<ProductCategoryViewModel>>(model);
        //    return PartialView(listProductCategoryViewModel);
        //}

        //[ChildActionOnly]
        //public ActionResult Footer()
        //{
        //    var footerModel = _commonService.GetFooter();
        //    var footerViewModel = Mapper.Map<Footer, FooterViewModel>(footerModel);
        //    return PartialView(footerViewModel);
        //}


        //Big Shop
        [ChildActionOnly]
        public ActionResult Header()
        {
            return PartialView();
        }

        [ChildActionOnly]
        public ActionResult Category()
        {
            var model = _productCategoryService.GetAll();
            var listProductCategoryViewModel = Mapper.Map<IEnumerable<ProductCategory>, IEnumerable<ProductCategoryViewModel>>(model);
            return PartialView(listProductCategoryViewModel);
        }

        [ChildActionOnly]
        public ActionResult Footer()
        {
            var footerModel = _commonService.GetFooter();
            var footerViewModel = Mapper.Map<Footer, FooterViewModel>(footerModel);
            return PartialView(footerViewModel);
        }
    }
}