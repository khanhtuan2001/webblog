using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webblog.enums;
using Webblog.Models;

namespace Webblog.Controllers.Components
{
    public class PopularViewComponent : ViewComponent
    {
        
        
            private readonly BlogWebContext _context;
            private IMemoryCache _memoryCache;

            public PopularViewComponent(BlogWebContext context, IMemoryCache memoryCache)
            {
                _context = context;
                _memoryCache = memoryCache;

            }

            public IViewComponentResult Invoke()
            {
                var _lsDanhmuc = _memoryCache.GetOrCreate(Cachkey.Popular, entry =>
                {
                    entry.SlidingExpiration = TimeSpan.MaxValue;
                    return GetlsPost();
                });
                return View(_lsDanhmuc);
            }

            public List<Post> GetlsPost()
            {
                List<Post> listins = new List<Post>();
                listins = _context.Posts
              
                    .Where(x => x.Published == true)
                    .OrderByDescending(x => x.views)
                    .Take(6)
                    .ToList();
                return listins;
            }
    }
    
}
