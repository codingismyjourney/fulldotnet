using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Restaurant.Data;
using Restaurant.Models;
using Restaurant.Models.ViewModels;

namespace Restaurant.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SubCategoryController : Controller
    {
        private readonly ApplicationDbContext _db;

        [TempData]

        public string StatusMessage { get; set; }


        public SubCategoryController(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> Index()
        {
            //var subCategory = await _db.SubCategory.ToListAsync();
            //to get all data from subcategory and also from category table
            var subCategory = await _db.SubCategory.Include(s => s.Category).ToListAsync();
            return View(subCategory);
        }

        //Get - Create

        public async Task<IActionResult> Create()
        {
            //to use SubCategoryandCategoryViewModel to create it's object with property - with value
            SubCategoryandCategoryViewModel model = new SubCategoryandCategoryViewModel()
            {
                CategoryList = await _db.Category.ToListAsync(),
                SubCategory = new Models.SubCategory(),
                SubCategoryList = await _db.SubCategory.OrderBy(p => p.Name).Select(p => p.Name).Distinct().ToListAsync()
            };
            return View(model);
        }

        //Post - Create

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create(SubCategoryandCategoryViewModel model)
        {
            if (ModelState.IsValid)
            {
                var doesSubCategoryExists = _db.SubCategory.Include(s => s.Category)
                .Where(s => s.Name == model.SubCategory.Name && s.Category.Id == model.SubCategory.CategoryId);

                if (doesSubCategoryExists.Count() > 0)
                {
                    //status will be here

                    StatusMessage = "Error : Sub Category Exists under " + doesSubCategoryExists.First().Category.Name +
                        "Category, Please use another name. ";
                }
                else
                {
                    _db.SubCategory.Add(model.SubCategory);
                    await _db.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }


            //to use SubCategoryandCategoryViewModel to create it's object with property - with value
            SubCategoryandCategoryViewModel modelVM = new SubCategoryandCategoryViewModel()
            {
                CategoryList = await _db.Category.ToListAsync(),
                SubCategory = new Models.SubCategory(),
                SubCategoryList = await _db.SubCategory.OrderBy(p => p.Name).Select(p => p.Name).Distinct().ToListAsync(),
                StatusMessage = StatusMessage
            };
            return View(modelVM);
        }
            
        //Get list of sub Category.
            
        [ActionName("GetSubCategory")]

        public async Task<IActionResult> GetSubCategory(int id)
        {
            //Create object of subcategory model.
        
            List<SubCategory> subCategories = new List<SubCategory>();

            //select sub category based on id which we get & also will use linq for that.

            subCategories = await (from subCategory in _db.SubCategory
                                   where
                                   subCategory.CategoryId == id
                                   select subCategory).ToListAsync();

            return Json(new SelectList(subCategories, "Id", "Name"));
        }

        [ActionName("Edit")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subCategory = await _db.SubCategory.SingleOrDefaultAsync(s => s.Id == id);

            if (subCategory == null)
            {
                return NotFound();
            }

            //to use SubCategoryandCategoryViewModel to create it's object with property - with value
            SubCategoryandCategoryViewModel model = new SubCategoryandCategoryViewModel()
            {
                CategoryList = await _db.Category.ToListAsync(),
                SubCategory = subCategory,
                SubCategoryList = await _db.SubCategory.OrderBy(p => p.Name).Select(p => p.Name).Distinct().ToListAsync()
            };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Edit(int id, SubCategoryandCategoryViewModel model)
        {
            if (ModelState.IsValid)
            {
                var doesSubCategoryExists = _db.SubCategory.Include(s => s.Category)
                .Where(s => s.Name == model.SubCategory.Name && s.Category.Id == model.SubCategory.CategoryId);

                if (doesSubCategoryExists.Count() > 0)
                {
                    //status will be here

                    StatusMessage = "Error : Sub Category Exists under " + doesSubCategoryExists.First().Category.Name +
                        "Category, Please use another name. ";
                }

                else
                {
                    var subCatfromDB = await _db.SubCategory.FindAsync(id);
                    subCatfromDB.Name = model.SubCategory.Name;

                    await _db.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            //to use SubCategoryandCategoryViewModel to create it's object with property - with value
            SubCategoryandCategoryViewModel modelVM = new SubCategoryandCategoryViewModel()
            {
                CategoryList = await _db.Category.ToListAsync(),
                SubCategory = new Models.SubCategory(),
                SubCategoryList = await _db.SubCategory.OrderBy(p => p.Name).Select(p => p.Name).Distinct().ToListAsync(),
                StatusMessage = StatusMessage
            };
            modelVM.SubCategory.Id = id;
            return View(modelVM);
        }
    
        //Post - Delete SubCategories

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var subCategory = await _db.SubCategory.FindAsync(id);

            if (subCategory == null)
            {
                return NotFound();
            }

            _db.Remove(subCategory);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
