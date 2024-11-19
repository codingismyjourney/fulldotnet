using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Exam
{
    class test6 : test4
    {
        public void subNumbers()
        {
            decimal decResult;
            decResult = firstNumber - secondNumber;
            Console.WriteLine("Substraction is = {0}",decResult);
        }
    }
}
