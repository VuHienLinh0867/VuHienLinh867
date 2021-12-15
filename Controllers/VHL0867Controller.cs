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
    public class VHL0867Controller : Controller
    {
        private readonly MvcMovieContext _context;

        public VHL0867Controller(MvcMovieContext context)
        {
            _context = context;
        }

        // GET: VHL0867
        public async Task<IActionResult> Index()
        {
            return View(await _context.VHL0867.ToListAsync());
        }

        // GET: VHL0867/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vHL0867 = await _context.VHL0867
                .FirstOrDefaultAsync(m => m.VHLId == id);
            if (vHL0867 == null)
            {
                return NotFound();
            }

            return View(vHL0867);
        }

        // GET: VHL0867/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: VHL0867/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("VHLId,VHLName,VHLGender")] VHL0867 vHL0867)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vHL0867);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vHL0867);
        }

        // GET: VHL0867/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vHL0867 = await _context.VHL0867.FindAsync(id);
            if (vHL0867 == null)
            {
                return NotFound();
            }
            return View(vHL0867);
        }

        // POST: VHL0867/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("VHLId,VHLName,VHLGender")] VHL0867 vHL0867)
        {
            if (id != vHL0867.VHLId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vHL0867);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VHL0867Exists(vHL0867.VHLId))
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
            return View(vHL0867);
        }

        // GET: VHL0867/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vHL0867 = await _context.VHL0867
                .FirstOrDefaultAsync(m => m.VHLId == id);
            if (vHL0867 == null)
            {
                return NotFound();
            }

            return View(vHL0867);
        }

        // POST: VHL0867/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var vHL0867 = await _context.VHL0867.FindAsync(id);
            _context.VHL0867.Remove(vHL0867);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VHL0867Exists(string id)
        {
            return _context.VHL0867.Any(e => e.VHLId == id);
        }
    }
}
