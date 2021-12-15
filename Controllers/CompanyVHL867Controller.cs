using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VUHIENLINH867.Models;

namespace VuHienLinh867.Controllers
{
    public class CompanyVHL867Controller : Controller
    {
        private readonly MvcMovieContext _context;

        public CompanyVHL867Controller(MvcMovieContext context)
        {
            _context = context;
        }

        // GET: CompanyVHL867
        public async Task<IActionResult> Index()
        {
            return View(await _context.CompanyVHL867.ToListAsync());
        }

        // GET: CompanyVHL867/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var companyVHL867 = await _context.CompanyVHL867
                .FirstOrDefaultAsync(m => m.CompanyId == id);
            if (companyVHL867 == null)
            {
                return NotFound();
            }

            return View(companyVHL867);
        }

        // GET: CompanyVHL867/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CompanyVHL867/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CompanyId,CompanyName")] CompanyVHL867 companyVHL867)
        {
            if (ModelState.IsValid)
            {
                _context.Add(companyVHL867);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(companyVHL867);
        }

        // GET: CompanyVHL867/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var companyVHL867 = await _context.CompanyVHL867.FindAsync(id);
            if (companyVHL867 == null)
            {
                return NotFound();
            }
            return View(companyVHL867);
        }

        // POST: CompanyVHL867/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("CompanyId,CompanyName")] CompanyVHL867 companyVHL867)
        {
            if (id != companyVHL867.CompanyId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(companyVHL867);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CompanyVHL867Exists(companyVHL867.CompanyId))
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
            return View(companyVHL867);
        }

        // GET: CompanyVHL867/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var companyVHL867 = await _context.CompanyVHL867
                .FirstOrDefaultAsync(m => m.CompanyId == id);
            if (companyVHL867 == null)
            {
                return NotFound();
            }

            return View(companyVHL867);
        }

        // POST: CompanyVHL867/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var companyVHL867 = await _context.CompanyVHL867.FindAsync(id);
            _context.CompanyVHL867.Remove(companyVHL867);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CompanyVHL867Exists(string id)
        {
            return _context.CompanyVHL867.Any(e => e.CompanyId == id);
        }
    }
}
