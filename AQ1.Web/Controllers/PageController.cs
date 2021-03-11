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
    public class PageController : Controller
    {
        // GET: Pages
        IPageService _pageService;
        public PageController(IPageService pageService)
        {
            this._pageService = pageService;
        }
        public ActionResult Index(string alias)
        {
            var pageModel = _pageService.GetByAlias(alias);
            var pageViewModel = Mapper.Map<Page, PageViewModel>(pageModel);
            return View(pageViewModel);
        }
    }
}