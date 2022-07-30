using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Basic2
{
    class sevenMultipleInheritanceClassChild : sevenMultipleInheritanceClassBase, sevenMultipleInheritanceInterface 
    {
        public void twoTest()
        {
            Console.WriteLine("This is a Child Class...");
        }
        public void threeTest()
        {
            Console.WriteLine("This is a Interface Method...");
        }
    }
}
