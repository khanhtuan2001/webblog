﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webblog.enums;
using Webblog.Models;
using Webblog.ModelViews;

namespace Webblog.Controllers.Components
{
    public class SocialViewComponent : ViewComponent
    {

        private readonly IConfiguration _config;
        private IMemoryCache _memoryCache;

        public SocialViewComponent(IMemoryCache memoryCache, IConfiguration config)
        {
            _config = config;
            _memoryCache = memoryCache;

        }

        public IViewComponentResult Invoke()
        {
            var _social = _memoryCache.GetOrCreate(Cachkey.Social, entry =>
            {
                entry.SlidingExpiration = TimeSpan.MaxValue;
                return GetlsSocials();
            });
            return View(_social);
        }

        public SocialVM GetlsSocials()
        {
            SocialVM socialVM = new SocialVM();
            socialVM.Facebook = _config.GetValue<string>("SocialLinks:facebook");
            socialVM.Twitter = _config.GetValue<string>("SocialLinks:twitter");
            socialVM.Instagram = _config.GetValue<string>("SocialLinks:instagram");
            socialVM.Youtube = _config.GetValue<string>("SocialLinks:youtube");
            socialVM.Pinterest = _config.GetValue<string>("SocialLinks:pinterest");
            return socialVM;

        }
    }
}
