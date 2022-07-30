using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStoreRazors.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookStoreRazors.Pages.BookList
{
    public class CreateModel : PageModel
    {
        //Connection string from pipeline
        private readonly ApplicationDbContext _db;
        //ctor for Constructor

        public CreateModel(ApplicationDbContext db)
        {
            _db = db;
        }

        //use bind property to use this property to use Book object from cshtml page.
        [BindProperty]
        public Book Book { get; set; }

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                //to add data in db.
                await _db.Books.AddAsync(Book);
                await _db.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }

    }
}