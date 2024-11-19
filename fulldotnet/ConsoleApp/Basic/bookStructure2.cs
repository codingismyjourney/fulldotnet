using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Basic
{
    struct bookStructure2
    {
        public int book_id;
        public string title;
        public string author;
        public string subject;

        public void getValues(string strSubject, string strAuthor, string strTitle, int intBook_id)
        {
            subject = strSubject;
            author = strAuthor;
            title = strTitle;
            book_id = intBook_id;
        }

        public void display()
        {
            Console.WriteLine("Subject is = {0}",subject);
            Console.WriteLine("Author is = {0}" , author);
            Console.WriteLine("Title is = {0}" , title);
            Console.WriteLine("Book ID is = {0}", book_id);
        }
    }
}
