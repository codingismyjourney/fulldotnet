using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStoreRazors.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookStoreRazors.Pages.BookList
{
    public class EditModel : PageModel
    {
        //Connection string from pipeline

        private readonly ApplicationDbContext _db;

        //ctor for Constructor

        public EditModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Book Book { get; set; }

        public async Task OnGet(int id)
        {
            Book = await _db.Books.FindAsync(id);
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var BookFromDataBase = await _db.Books.FindAsync(Book.Id);
                BookFromDataBase.Name = Book.Name;
                BookFromDataBase.Author = Book.Author;
                BookFromDataBase.ISBN = Book.ISBN;

                await _db.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            else
            {
                return RedirectToPage();
            }
        }
    }
}