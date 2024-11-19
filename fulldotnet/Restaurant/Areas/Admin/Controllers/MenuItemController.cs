
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Restaurant.Data;
using Restaurant.Models;
using Restaurant.Models.ViewModels;
using Restaurant.Utility;

namespace Restaurant.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MenuItemController : Controller
    {

        private readonly ApplicationDbContext _db;

        // to save images on server we need to use IwebHostingEnv.
        private readonly IWebHostEnvironment _hostingEnvironment;

        // property bind so we can use it 

        [BindProperty]
        public MenuItemViewModel MenuItemVM { get; set; }


        public MenuItemController(ApplicationDbContext db, IWebHostEnvironment hostingEnvironment)
        {
            _db = db;
            _hostingEnvironment = hostingEnvironment;

            MenuItemVM = new MenuItemViewModel()
            {
                Category = _db.Category,
                MenuItem = new Models.MenuItem()
            };
        }       

        public async Task<IActionResult> Index()
        {
            //var menuItems = await _db.MenuItem.ToListAsync();

            var menuItems = await _db.MenuItem.Include(m => m.Category).Include(m => m.SubCategory).ToListAsync();

            return View(menuItems);
        }


        // Create Get Action 
        public IActionResult Create()
        {
            return View(MenuItemVM);
        }

        // Post - Create

        [HttpPost, ActionName("Create")]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> MenuItemCreate()
        {

            // MenuItemVM.MenuItem.SubCategoryId = Convert.ToInt32(Request.Form["SubCategoryId"].ToString());
            MenuItemVM.MenuItem.SubCategoryId = Convert.ToInt32(Request.Form["SubCategoryId"].ToString());



            if (ModelState.IsValid)
            {
                // add to db

                _db.MenuItem.Add(MenuItemVM.MenuItem);
                await _db.SaveChangesAsync();

                // Save Image 

                string webRootPath = _hostingEnvironment.WebRootPath;

                // get files which user has uploaded 

                var files = HttpContext.Request.Form.Files;


                // get menu item from data base which we saved for our image name.

                var menuItemFromDB = await _db.MenuItem.FindAsync(MenuItemVM.MenuItem.Id);

                // now check file uploaded or not 

                if (files.Count > 0)
                {
                    // files has been uploaded

                    var uploads = Path.Combine(webRootPath, "images");

                    // now get extension of file 

                    var extension = Path.GetExtension(files[0].FileName);

                    // now file streaming , so save image & rename image

                    using (var fileStream = new FileStream(Path.Combine(uploads, MenuItemVM.MenuItem.Id + extension), FileMode.Create))
                    {
                        files[0].CopyTo(fileStream);
                    }

                    // now save in data base about image 
                    menuItemFromDB.Image = @"\images\" + MenuItemVM.MenuItem.Id + extension;


                }
                else
                {
                    
                    // no file was uploaded, so now we will use our default image

                    var uploads = Path.Combine(webRootPath, @"images\" + StaticDetails.DefaultFoodImage);

                    // copy default image for current product 
                    System.IO.File.Copy(uploads, webRootPath + @"\images\" + MenuItemVM.MenuItem.Id + ".png");

                    // now save in data base about image 
                    menuItemFromDB.Image = @"\images\" + MenuItemVM.MenuItem.Id + ".png";
                    

                }

                await _db.SaveChangesAsync();

                return RedirectToAction(nameof(Index));

            }
            else
            {
                return View(MenuItemVM);
            }

            // return View();
        }

        // Edit Get Action 
        public async Task<IActionResult> Edit(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            MenuItemVM.MenuItem = await _db.MenuItem.Include(m => m.Category).Include(m => m.SubCategory).SingleOrDefaultAsync(m => m.Id == id);
            // also load sub cat for first time

            MenuItemVM.SubCategory = await _db.SubCategory.Where(s => s.CategoryId == MenuItemVM.MenuItem.CategoryId).ToListAsync();


            // check menu item 
            if (MenuItemVM.MenuItem == null)
            {
                return NotFound();
            }


            return View(MenuItemVM);
        }



        // Post - Create

        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> MenuItemEdit(int? id)
        {


            if (id == null)
            {
                return NotFound();
            }



            // MenuItemVM.MenuItem.SubCategoryId = Convert.ToInt32(Request.Form["SubCategoryId"].ToString());
            MenuItemVM.MenuItem.SubCategoryId = Convert.ToInt32(Request.Form["SubCategoryId"].ToString());



            if (ModelState.IsValid)
            {
                // add to db

                //   _db.MenuItem.Add(MenuItemVM.MenuItem);
                //   await _db.SaveChangesAsync();

                // Save Image 

                string webRootPath = _hostingEnvironment.WebRootPath;

                // get files which user has uploaded 

                var files = HttpContext.Request.Form.Files;


                // get menu item from data base which we saved for our image name.

                var menuItemFromDB = await _db.MenuItem.FindAsync(MenuItemVM.MenuItem.Id);

                // now check file uploaded or not 

                if (files.Count > 0)
                {
                    // new files has been uploaded

                    var uploads = Path.Combine(webRootPath, "images");

                    // now get extension of file 

                    var extension = Path.GetExtension(files[0].FileName);

                    //*************************
                    // Delete orginal file - uploaded before to save new one with same name.

                    var imagePath = Path.Combine(webRootPath, menuItemFromDB.Image.TrimStart('\\'));

                    if (System.IO.File.Exists(imagePath))
                    {
                        //delete image file 
                        System.IO.File.Delete(imagePath);
                    }



                    // End Delete orginal file


                    // now upload new file streaming , so save image & rename image

                    using (var fileStream = new FileStream(Path.Combine(uploads, MenuItemVM.MenuItem.Id + extension), FileMode.Create))
                    {
                        files[0].CopyTo(fileStream);
                    }

                    // now save in data base about image 
                    menuItemFromDB.Image = @"\images\" + MenuItemVM.MenuItem.Id + extension;


                }


                // Do work on other part of page - if user change some thing update - edit that 

                menuItemFromDB.Name = MenuItemVM.MenuItem.Name;
                menuItemFromDB.Description = MenuItemVM.MenuItem.Description;
                menuItemFromDB.Price = MenuItemVM.MenuItem.Price;
                menuItemFromDB.Spicyness = MenuItemVM.MenuItem.Spicyness;
                menuItemFromDB.CategoryId = MenuItemVM.MenuItem.CategoryId;
                menuItemFromDB.SubCategoryId = MenuItemVM.MenuItem.SubCategoryId;



                await _db.SaveChangesAsync();

                return RedirectToAction(nameof(Index));


            }
            else
            {
                MenuItemVM.SubCategory = await _db.SubCategory.Where(s => s.CategoryId == MenuItemVM.MenuItem.CategoryId).ToListAsync();

                return View(MenuItemVM);
            }


            // return View();



        }



        //Post - Delete MenuItem

        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var menuItem = await _db.MenuItem.FindAsync(id);

            if (menuItem == null)
            {
                return NotFound();
            }

            _db.Remove(menuItem);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
