        using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Basic
{
    class thirteenStructure
    {
        public void oneStructData()
        {
            bookStructure3 struct_bookStructure3 = new bookStructure3();

            char flagAns = 'y';

            while(flagAns == 'y')
            {
                Console.WriteLine("Please Enter ID = ");
                struct_bookStructure3.Id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please Enter FirstName = ");
                struct_bookStructure3.fName = Console.ReadLine();
                Console.WriteLine("Please Enter LastName = ");
                struct_bookStructure3.lName = Console.ReadLine();

                struct_bookStructure3.printDetail();

                Console.WriteLine("You Want Continue....");
                flagAns = Console.ReadKey().KeyChar;
            }
            
        }
    }
}
