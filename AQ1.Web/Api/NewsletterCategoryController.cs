using AQ1.Model.Models;
using AQ1.Service;
using AQ1.Web.infrastructure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AQ1.Web.Api
{
    [RoutePrefix("api/newslettercategory")]
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
            return CreateHttpResponseMessage(request, () =>
            {
                HttpResponseMessage response = null;
                if (!ModelState.IsValid)
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    var listCategory = _newsletterCategoryService.GetAll();
                    response = request.CreateResponse(HttpStatusCode.OK, listCategory);
                }
                return response;
            });
        }

        public HttpResponseMessage Post(HttpRequestMessage request, NewsletterCategory newsletterCategory)
        {
            return CreateHttpResponseMessage(request, () => 
            {
                HttpResponseMessage response = null;
                if (!ModelState.IsValid)
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    var category = _newsletterCategoryService.Add(newsletterCategory);
                    _newsletterCategoryService.Save();
                    response = request.CreateResponse(HttpStatusCode.Created, category);
                }
                return response;
            });
        }

        public HttpResponseMessage Put(HttpRequestMessage request, NewsletterCategory newsletterCategory)
        {
            return CreateHttpResponseMessage(request, () =>
            {
                HttpResponseMessage response = null;
                if (!ModelState.IsValid)
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    _newsletterCategoryService.Update(newsletterCategory);
                    _newsletterCategoryService.Save();
                    response = request.CreateResponse(HttpStatusCode.OK);
                }
                return response;
            });
        }

        public HttpResponseMessage Delete(HttpRequestMessage request, int id)
        {
            return CreateHttpResponseMessage(request, () =>
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