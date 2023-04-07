using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PagedList.Core;
using Webblog.helper;
using Webblog.Models;
using Webblog.extention;
using System.IO;
using Microsoft.AspNetCore.Authorization;

namespace Webblog.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class PostsController : Controller
    {
        private readonly BlogWebContext _context;

        public PostsController(BlogWebContext context)
        {
            _context = context;
        }

        // GET: Admin/Posts
        //public async Task<IActionResult> Index()
        //{
        //    var blogWebContext = _context.Posts.Include(p => p.Account).Include(p => p.Cat);
        //    return View(await blogWebContext.ToListAsync());
        //}
        public IActionResult Index(int? page)
        {
            //if (!User.Identity.IsAuthenticated) Response.Redirect("/dang-nhap.html");
            //var taikhoanID = HttpContext.Session.GetString("AccountId");
            //if (taikhoanID == null) return RedirectToAction("Login", "Accounts", new { Areas = "Admin" });
            //var account = _context.Accounts.AsNoTracking().FirstOrDefault(x => x.AccountId == int.Parse(taikhoanID));
            //if (account == null) return NotFound();

            //List<Post> lspost = new List<Post>();

            var pageNumber = page == null || page <= 0 ? 1 : page.Value;
           // var pageSize = utility.Page_size;
            var pageSize = 1;
            //if (account.RoleId == 1)//admin
            //{
            //    lspost = _context.Posts
            //        .Include(p => p.Account)
            //        .Include(p => p.Cat)
            //        .OrderByDescending(x => x.CatId).ToList();
            //}
            //else
            //{
            //    lspost = _context.Posts
            //       .Include(p => p.Account)
            //       .Include(p => p.Cat).Where(x=>x.AccountId==account.AccountId)
            //       .OrderByDescending(x => x.CatId).ToList();
            //}

           var lspost = _context.Posts
                    .Include(p => p.Account)
                    .Include(p => p.Cat)
                    .OrderByDescending(x => x.CatId);



            PagedList<Post> models = new PagedList<Post>(lspost, pageNumber, pageSize);
            //ViewBag.CurrentPage = pageNumber;
            return View(models);
        }
        // GET: Admin/Posts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var post = await _context.Posts
                .Include(p => p.Account)
                .Include(p => p.Cat)
                .FirstOrDefaultAsync(m => m.PostId == id);
            if (post == null)
            {
                return NotFound();
            }

            return View(post);
        }

        // GET: Admin/Posts/Create
        public IActionResult Create()
        {
            if (!User.Identity.IsAuthenticated) Response.Redirect("/dang-nhap.html");
            var taikhoanID = HttpContext.Session.GetString("AccountId");
            if (taikhoanID == null) return RedirectToAction("Login", "Accounts", new { Areas = "Admin" });

           
            ViewData["DanhMuc"] = new SelectList(_context.Categories, "CatId", "CatName");
            return View();
        }

        // POST: Admin/Posts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PostId,Title,Contents,Thumb,Published,Alias,CreateDate,Author,AccountId,Tags,CatId,IsHot,IsNewfeed")] Post post, Microsoft.AspNetCore.Http.IFormFile fThumb)
        {
            if (!User.Identity.IsAuthenticated) Response.Redirect("/dang-nhap.html");
            var taikhoanID = HttpContext.Session.GetString("AccountId");
            if (taikhoanID == null) return RedirectToAction("Login", "Accounts", new { Areas = "Admin" });
            var account = _context.Accounts.AsNoTracking().FirstOrDefault(x => x.AccountId == int.Parse(taikhoanID));
            if (account == null) return NotFound();
            if (ModelState.IsValid)
            {
                post.AccountId = account.AccountId;
                post.Author = account.FullName;
                if (post.CatId == null) post.CatId = 1;
                post.CreateDate = DateTime.Now;
                post.Alias = utility.seourl(post.Title);
                if(fThumb!= null)
                {
                    string Extension = Path.GetExtension(fThumb.FileName);
                    string newname = utility.seourl(post.Title) + Extension;
                    post.Thumb =await utility.UPloadfile(fThumb, @"news\", newname.ToLower());
                }

                _context.Add(post);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AccountId"] = new SelectList(_context.Accounts, "AccountId", "AccountId", post.AccountId);
            ViewData["DanhMuc"] = new SelectList(_context.Categories, "CatId", "CatName", post.CatId);
            return View(post);
        }

        // GET: Admin/Posts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            if (!User.Identity.IsAuthenticated) Response.Redirect("/dang-nhap.html");
            var taikhoanID = HttpContext.Session.GetString("AccountId");
            if (taikhoanID == null) return RedirectToAction("Login", "Accounts", new { Areas = "Admin" });

            var post = await _context.Posts.FindAsync(id);
            if (post == null)
            {
                return NotFound();
            }
            ViewData["AccountId"] = new SelectList(_context.Accounts, "AccountId", "AccountId", post.AccountId);
            ViewData["DanhMuc"] = new SelectList(_context.Categories, "CatId", "CatName", post.CatId);
            return View(post);
        }

        // POST: Admin/Posts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PostId,Title,Contents,Thumb,Published,Alias,CreateDate,Author,AccountId,Tags,CatId,IsHot,IsNewfeed")] Post post, Microsoft.AspNetCore.Http.IFormFile fThumb)
        {
            if (id != post.PostId)
            {
                return NotFound();
            }
            if (!User.Identity.IsAuthenticated) Response.Redirect("/dang-nhap.html");
            var taikhoanID = HttpContext.Session.GetString("AccountId");
            if (taikhoanID == null) return RedirectToAction("Login", "Accounts", new { Areas = "Admin" });
            var account = _context.Accounts.AsNoTracking().FirstOrDefault(x => x.AccountId == int.Parse(taikhoanID));
            if (account == null) return NotFound();
            if (ModelState.IsValid)
            {
                try
                {
                    post.AccountId = account.AccountId;
                    post.Author = account.FullName;
                    if (post.CatId == null) post.CatId = 1;
                    post.CreateDate = DateTime.Now;
                    post.Alias = utility.seourl(post.Title);
                    if (fThumb != null)
                    {
                        string Extension = Path.GetExtension(fThumb.FileName);
                        string newname = utility.seourl(post.Title) + Extension;
                        post.Thumb = await utility.UPloadfile(fThumb, @"news\", newname.ToLower());
                    }
                    _context.Update(post);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PostExists(post.PostId))
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
            ViewData["AccountId"] = new SelectList(_context.Accounts, "AccountId", "AccountId", post.AccountId);
            ViewData["DanhMuc"] = new SelectList(_context.Categories, "CatId", "CatName", post.CatId);
            return View(post);
        }

        // GET: Admin/Posts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var post = await _context.Posts
                .Include(p => p.Account)
                .Include(p => p.Cat)
                .FirstOrDefaultAsync(m => m.PostId == id);
            if (post == null)
            {
                return NotFound();
            }

            return View(post);
        }

        // POST: Admin/Posts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var post = await _context.Posts.FindAsync(id);
            _context.Posts.Remove(post);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PostExists(int id)
        {
            return _context.Posts.Any(e => e.PostId == id);
        }
    }
}
