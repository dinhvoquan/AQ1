﻿using AQ1.Model.Models;
using AQ1.Web.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;

namespace AQ1.Web.Mappings
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.CreateMap<Newsletter, NewsletterViewModel>();
            Mapper.CreateMap<NewsletterCategory, NewsletterCategoryViewModel>();
            Mapper.CreateMap<Tag, TagViewModel>();
        }
    }
}