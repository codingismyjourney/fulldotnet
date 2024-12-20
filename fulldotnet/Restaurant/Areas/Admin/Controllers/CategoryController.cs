﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Restaurant.Data;
using Restaurant.Models;

namespace Restaurant.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }
        
        public async Task<IActionResult> Index()
        {
            return View(await _db.Category.ToListAsync());
        }

        public IActionResult Create()
        {
            return View();
        }

        // Post - Add Categories.

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create(Category category)
        {
            if (ModelState.IsValid)
            {
                _db.Category.Add(category);
                await _db.SaveChangesAsync();

                //return RedirectToAction("Index");
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }

        //Get Category for data

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await _db.Category.FindAsync(id);

            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        // Post-Add Category Data.

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Category category)
        {
            if (ModelState.IsValid)
            {
                _db.Category.Update(category);
                await _db.SaveChangesAsync();

                //return RedirectToAction("Index");
                return RedirectToAction(nameof(Index));
            }

            return View(category);
        }

        //Post - Delete Category data.

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var category = await _db.Category.FindAsync(id);

            if (category == null)
            {
                return NotFound();
                //return View();
            }

            _db.Category.Remove(category);
            await _db.SaveChangesAsync();
            //return RedirectToAction("Index");
            return RedirectToAction(nameof(Index));
        }
    }
}