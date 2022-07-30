using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Exam
{
    class functionOverloading
    {

        public void oneFunction(int h, int w)
        {
            long lgResult = h * w;
            Console.WriteLine("Result is = {0}", lgResult);
        }

        public void oneFunction(int l, int b, int h)

        {
            long lgResult = h * b * l;
            Console.WriteLine("Result is = {0}", lgResult);
        }
    }
}
