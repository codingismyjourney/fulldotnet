using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleAppdb.linqex
{
    class threeSort
    {
        public void oneTest()
        {
            int[] numbers = { 3, 66, -32, -36, 25, 63 };

            var sortNumbers = from num in numbers
                              orderby num
                              select num;

            Console.WriteLine("Values in ascending order: ");

            foreach (var n in sortNumbers)
            {
                Console.WriteLine(n);
            }
        }

        public void twosTest()
        {
            int[] numbers = { 3, 66, -32, -36, 25, 63 };

            var sortNumbers = from num in numbers
                              orderby num descending
                              select num;

            Console.WriteLine("Values in descending order: ");

            foreach (var n in sortNumbers)
            {
                Console.WriteLine(n);
            }
        }
    }
}
