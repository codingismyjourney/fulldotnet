using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Exam
{
    class test4
    {
        public int firstNumber, secondNumber;

        public void getNumberfromUser()
        {
            Console.WriteLine("Please Enter First Number  = ");
            firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter Second Number = ");
            secondNumber = Convert.ToInt32(Console.ReadLine());
        }
    }
}
