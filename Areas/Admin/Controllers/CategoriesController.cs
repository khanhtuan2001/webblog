using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Webblog.Models;
using Webblog.helper;

using PagedList.Core;
using System.IO;
using Microsoft.AspNetCore.Authorization;

namespace Webblog.Areas.Admin.Controllers
{
    [Area("Admin")]
 
    public class CategoriesController : Controller
    {
        private readonly BlogWebContext _context;

        public CategoriesController(BlogWebContext context)
        {
            _context = context;
        }

        // GET: Admin/Categories
        //public async Task<IActionResult> Index()
        //{
        //    return View(await _context.Categories.ToListAsync());
        //}
        public IActionResult Index(int? page)
        {
            var pageNumber = page == null || page <= 0 ? 1 : page.Value;
            //var pageSize = utility.Page_size;
            var pageSize = 2;
            var lsCategories = _context.Categories
                .OrderByDescending(x => x.CatId);
            PagedList<Category> models = new PagedList<Category>(lsCategories, pageNumber, pageSize);
            ViewBag.CurrentPage = pageNumber;
            return View(models);
        }

        // GET: Admin/Categories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await _context.Categories
                .FirstOrDefaultAsync(m => m.CatId == id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        // GET: Admin/Categories/Create
        public IActionResult Create()
        {
            ViewData["DanhMucGoc"] = new SelectList(_context.Categories.Where(x => x.Levels == 1), "CatId", "CatName");
            return View();
        }

        // POST: Admin/Categories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CatId,CatName,Title,Alias,MetaDesc,Metakey,Thumb,Published,Ordering,Parent,Levels,Icon,Cover,Decription")] Category category,Microsoft.AspNetCore.Http.IFormFile fThumb, Microsoft.AspNetCore.Http.IFormFile FCover, Microsoft.AspNetCore.Http.IFormFile fIcon)
        {
            if (ModelState.IsValid)
            {
                category.Alias = utility.seourl(category.CatName);
                if(category.Parent == null)
                {
                    category.Levels = 1;
                }
                else
                {
                    category.Levels = category.Parent == 0 ? 1 : 2;
                }
                if(fThumb != null)
                {
                    string extension = Path.GetExtension(fThumb.FileName);
                    string Newname = utility.seourl(category.CatName) + "preview_" + extension;
                    category.Thumb = await utility.UPloadfile(fThumb, @"Categories\", Newname.ToLower());
                }
                if(FCover != null)
                {
                    string extension = Path.GetExtension(FCover.FileName);
                    string Newname = "Cover_" + utility.seourl(category.CatName) + extension;
                    category.Cover = await utility.UPloadfile(FCover, @"Cover\", Newname.ToLower());

                }
                if (fIcon != null)
                {
                    string extension = Path.GetExtension(fIcon.FileName);
                    string Newname = "Icon_" + utility.seourl(category.CatName) + extension;
                    category.Cover = await utility.UPloadfile(FCover, @"Icon\", Newname.ToLower());

                }
                _context.Add(category);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }

        // GET: Admin/Categories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await _context.Categories.FindAsync(id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        // POST: Admin/Categories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CatId,CatName,Title,Alias,MetaDesc,Metakey,Thumb,Published,Ordering,Parent,Levels,Icon,Cover,Decription")] Category category, Microsoft.AspNetCore.Http.IFormFile fThumb, Microsoft.AspNetCore.Http.IFormFile FCover, Microsoft.AspNetCore.Http.IFormFile fIcon)
        {
            if (id != category.CatId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    category.Alias = utility.seourl(category.CatName);
                    if (category.Parent == null)
                    {
                        category.Levels = 1;
                    }
                    else
                    {
                        category.Levels = category.Parent == 0 ? 1 : 2;
                    }
                    if (fThumb != null)
                    {
                        string extension = Path.GetExtension(fThumb.FileName);
                        string Newname = utility.seourl(category.CatName) + "preview_" + extension;
                        category.Thumb = await utility.UPloadfile(fThumb, @"categories\", Newname.ToLower());
                    }
                    if (FCover != null)
                    {
                        string extension = Path.GetExtension(FCover.FileName);
                        string Newname = "cover_" + utility.seourl(category.CatName) + extension;
                        category.Cover = await utility.UPloadfile(FCover, @"cover\", Newname.ToLower());

                    }
                    if (fIcon != null)
                    {
                        string extension = Path.GetExtension(fIcon.FileName);
                        string Newname = "icon_" + utility.seourl(category.CatName) + extension;
                        category.Cover = await utility.UPloadfile(FCover, @"icon\", Newname.ToLower());

                    }
                    _context.Update(category);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CategoryExists(category.CatId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }

        // GET: Admin/Categories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await _context.Categories
                .FirstOrDefaultAsync(m => m.CatId == id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        // POST: Admin/Categories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var category = await _context.Categories.FindAsync(id);
            _context.Categories.Remove(category);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CategoryExists(int id)
        {
            return _context.Categories.Any(e => e.CatId == id);
        }
    }
}
