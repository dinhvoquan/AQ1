using AQ1.Model.Models;
using AQ1.Service;
using AQ1.Web.Infrastructure.Core;
using AQ1.Web.Infrastructure.Extentions;
using AQ1.Web.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AQ1.Web.Api
{
    [RoutePrefix("api/newslettercategory")]
    [Authorize]
    public class NewsletterCategoryController : ApiControllerBase
    {
        INewsletterCategoryService _newsletterCategoryService;

        public NewsletterCategoryController(IErrorService errorService, INewsletterCategoryService newsletterCategoryService):
            base(errorService)
        {
            this._newsletterCategoryService = newsletterCategoryService;
        }

        [Route("getall")]
        public HttpResponseMessage Get(HttpRequestMessage request)
        {
            return CreateHttpResponse(request, () =>
            {
                var listNewsletterCategory = _newsletterCategoryService.GetAll();
                var listNewsletterCategoryViewModel = Mapper.Map<List<NewsletterCategoryViewModel>>(listNewsletterCategory);
                HttpResponseMessage response = request.CreateResponse(HttpStatusCode.OK, listNewsletterCategoryViewModel);
                return response;
            });
        }

        [Route("add")]
        public HttpResponseMessage Post(HttpRequestMessage request, NewsletterCategoryViewModel newsletterCategoryViewModel)
        {
            return CreateHttpResponse(request, () => 
            {
                HttpResponseMessage response = null;
                if (!ModelState.IsValid)
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    NewsletterCategory newNewsletterCategory = new NewsletterCategory();
                    newNewsletterCategory.UpdateNewsletterCategory(newsletterCategoryViewModel);
                    var category = _newsletterCategoryService.Add(newNewsletterCategory);
                    _newsletterCategoryService.Save();
                    response = request.CreateResponse(HttpStatusCode.Created, category);
                }
                return response;
            });
        }

        [Route("update")]
        public HttpResponseMessage Put(HttpRequestMessage request, NewsletterCategoryViewModel newsletterCategoryViewModel)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                if (!ModelState.IsValid)
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    var newsletterCategoryDb = _newsletterCategoryService.GetById(newsletterCategoryViewModel.ID);
                    newsletterCategoryDb.UpdateNewsletterCategory(newsletterCategoryViewModel);
                    _newsletterCategoryService.Update(newsletterCategoryDb);
                    _newsletterCategoryService.Save();
                    response = request.CreateResponse(HttpStatusCode.OK);
                }
                return response;
            });
        }

        public HttpResponseMessage Delete(HttpRequestMessage request, int id)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                if (!ModelState.IsValid)
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    _newsletterCategoryService.Delete(id);
                    _newsletterCategoryService.Save();
                    response = request.CreateResponse(HttpStatusCode.OK);
                }
                return response;
            });
        }
    }
}