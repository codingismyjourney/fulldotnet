
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Basic
{
    class elevenStructures
    {
        public void oneStruc()
        {
            bookStructure book1;
            bookStructure book2;

            Console.WriteLine("Please Enter Book ID = ");
            book1.book_id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter Book Title = ");
            book1.title = Console.ReadLine();
            Console.WriteLine("Please Enter Book Author = ");
            book1.author = Console.ReadLine();
            Console.WriteLine("Please Enter Book Subject = ");
            book1.subject = Console.ReadLine();

            Console.WriteLine("*******************************************************************************");

            Console.WriteLine("Book ID = {0} , It's Name is = {1} , It's Author is = {2} & It's Subject is = {3}", book1.book_id, book1.title, book1.author, book1.subject);

            Console.WriteLine("*******************************************************************************");

            Console.WriteLine("Please Enter Book ID = ");
            book2.book_id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter Book Title = ");
            book2.title = Console.ReadLine();
            Console.WriteLine("Please Enter Book Author = ");
            book2.author = Console.ReadLine();
            Console.WriteLine("Please Enter Book Subject = ");
            book2.subject = Console.ReadLine();

            Console.WriteLine("*******************************************************************************");

            Console.WriteLine("Book ID = {0} , It's Name is = {1} , It's Author is =  {2} & It's Subject is = {3}" , book2.book_id,book2.title,book2.author,book2.subject);

            Console.WriteLine("*******************************************************************************");
        }
    }
}
