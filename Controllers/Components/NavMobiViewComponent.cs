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
    public class NavMobiViewComponent : ViewComponent
    {
        private readonly BlogWebContext _context;
        private IMemoryCache _memoryCache;

        public NavMobiViewComponent(BlogWebContext context, IMemoryCache memoryCache)
        {
            _context = context;
            _memoryCache = memoryCache;

        }

        public IViewComponentResult Invoke()
        {
            var _lsDanhmuc = _memoryCache.GetOrCreate(Cachkey.Categories, entry =>
            {
                entry.SlidingExpiration = TimeSpan.MaxValue;
                return GetlsCategories();
            });
            return View(_lsDanhmuc);
        }

        public List<Category> GetlsCategories()
        {
            List<Category> listins = new List<Category>();
            listins = _context.Categories
      
                .Where(x => x.Published == true)
                .OrderBy(x => x.Ordering)
                .ToList();
            return listins;
        }

    }
}
