using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Basic
{
    class twoNumbers
    {
        public void ifCheckPrint()
        {
            Console.WriteLine("Enter the First Number: ");
            decimal numberOneByUser = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter the Second Number: ");
            decimal numberTwoByUser = Convert.ToDecimal(Console.ReadLine());

            if(numberOneByUser > numberTwoByUser)
            {
                Console.WriteLine("Number one is Big");
            }
        }   
        public void ifElseCheckPrint()
        {
            Console.WriteLine("Enter the First Number: ");
            decimal numberOneByUser = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter the Second Number: ");
            decimal numberTwoByUser = Convert.ToDecimal(Console.ReadLine());

            if (numberOneByUser > numberTwoByUser)
            {
                Console.WriteLine("Number one is Big");
            }
            else
            {
                Console.WriteLine("Number two is Big");
            }
        }
        public void ifElseCheckPrintWithEq()
        {
            Console.WriteLine("Enter the First Number: ");
            decimal numberOneByUser = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter the Second Number: ");
            decimal numberTwoByUser = Convert.ToDecimal(Console.ReadLine());

            if (numberOneByUser >= numberTwoByUser)
            {
                Console.WriteLine("Number one is Big");
            }
            else
            {
                Console.WriteLine("Number two is Big");
            }
        }
        public void ifElseElsePrint()
        {
            Console.WriteLine("Enter the First Number: ");
            decimal numberOneByUser = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter the Second Number: ");
            decimal numberTwoByUser = Convert.ToDecimal(Console.ReadLine());

            if (numberOneByUser > numberTwoByUser)
            {
                Console.WriteLine("Number one is Big");
            }
            else if (numberOneByUser < numberTwoByUser)
            {
                Console.WriteLine("Number two is Big");
            }
            else
            {
                Console.WriteLine("Number One and Number two are Equal");
            }
        }
    }
}
