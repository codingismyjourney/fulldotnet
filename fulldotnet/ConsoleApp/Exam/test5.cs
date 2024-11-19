using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Exam
{
    class test5 : test4
    {
        public void addNumbers()
        {
            decimal decResult;
            decResult = firstNumber + secondNumber;
            Console.WriteLine("Addition is =  {0}",decResult);
        }
    }
}
