using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Webblog.Models;
using Webblog.ModelViews;

namespace Webblog.Controllers
{

    public class HomeController : Controller
    {

        private readonly ILogger<HomeController> _logger;
        private readonly BlogWebContext _context;

        public HomeController(ILogger<HomeController> logger, BlogWebContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var tin = _context.Posts.Find(1);
            for (int i = 0; i < 20; i++)
            {
                Post post = new Post();
                post = tin;
                _context.Add(post);
                _context.SaveChangesAsync();
            }


            HomeViewModel model = new HomeViewModel();

            var ls = _context.Posts.Include(x => x.Cat).AsNoTracking().ToList();
            model.LatestPosts = ls;
            model.Populars = ls;
            model.Recents = ls;
            model.Trending = ls;
            model.Inspiration = ls;
            model.Fetured = ls.FirstOrDefault(); //tuy nhu cau

            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

