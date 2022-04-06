using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebShopApplication_project.Data;
using WebShopApplication_project.Models;

namespace WebShopApplication_project.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ArticleController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ArticleController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/Article
        public async Task<IActionResult> Index(int categoryId)
        {
            if(categoryId != 0)
            {
                List<Article> list = await _context.Articles
                    .Where(c => c.Categorys
                    .Any(c=>c.ID == categoryId))
                    .ToListAsync();
                return View(list);
            }
            else
            {
                return View(await _context.Articles.ToListAsync());
            }

        }

        // GET: Admin/Article/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var article = await _context.Articles
                .FirstOrDefaultAsync(m => m.ID == id);
            if (article == null)
            {
                return NotFound();
            }

            return View(article);
        }

        // GET: Admin/Article/Create
        public async Task<IActionResult> CreateAsync()
        {
            var categorys = await _context.Categories.ToListAsync();
            #region viewBag
            List<SelectListItem> categorylist = new List<SelectListItem>();
            foreach(var c in categorys)
            {
                categorylist.Add(new SelectListItem { Text = c.Titel, Value = c.ID.ToString() });
            }
            ViewBag.CategoryList = categorylist;
            #endregion



            return View();
        }

        // POST: Admin/Article/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,ArticleNumber,Name,Categorys,Price,Description,Hight,Whith,Depth,NetWweight,GrossWeight,DateTimeItemCreated,DateTimeItemUpdated")] Article temparticle)
        {
            var categorySelectedItem = Request.Form["category-select-list"];
            var category = _context.Categories.Where(c => c.ID == Convert.ToInt32(categorySelectedItem)).ToList();
            Article article = new Article
            {
                ArticleNumber = temparticle.ArticleNumber,
                Name = temparticle.Name,
                Categorys = category,
                Price = temparticle.Price,
                Description = temparticle.Description,
                Hight = temparticle.Hight,
                Whith = temparticle.Whith,
                Depth = temparticle.Depth,
                NetWweight = temparticle.NetWweight,
                GrossWeight = temparticle.GrossWeight,
                DateTimeItemCreated = DateTime.Now,
                DateTimeItemUpdated = DateTime.Now


            };
            if (ModelState.IsValid)
            {
                _context.Add(article);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(article);
        }

        // GET: Admin/Article/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var article = await _context.Articles.FindAsync(id);
            if (article == null)
            {
                return NotFound();
            }
            return View(article);
        }

        // POST: Admin/Article/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,ArticleNumber,Name,Price,Description,Hight,Whith,Depth,NetWweight,GrossWeight,DateTimeItemCreated,DateTimeItemUpdated,CategoryId")] Article article)
        {
            if (id != article.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(article);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ArticleExists(article.ID))
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
            return View(article);
        }

        // GET: Admin/Article/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var article = await _context.Articles
                .FirstOrDefaultAsync(m => m.ID == id);
            if (article == null)
            {
                return NotFound();
            }

            return View(article);
        }

        // POST: Admin/Article/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var article = await _context.Articles.FindAsync(id);
            _context.Articles.Remove(article);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ArticleExists(int id)
        {
            return _context.Articles.Any(e => e.ID == id);
        }
    }
}
