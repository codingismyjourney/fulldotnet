using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Basic
{
    class sixTypeFunctions
    {
        public void oneFunction()
        {
            Console.WriteLine("Hi This is a First Function of the sixTypeFunctions Class");
        }
        public int twoFunction()
        {   
            Console.WriteLine("it is int type function and it will return int in last");

            int no1 = Convert.ToInt32(Console.ReadLine());  

            no1 = no1 + 5;

            return no1;
        }
        public int threeFindMax(int num1 , int num2)
        {
            if(num1 > num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }
        public int fourFactorial(int num)
        {
            int result;
            if(num == 1)
            {
                return 1;
            }
            else
            {
                result = fourFactorial(num - 1) * num;
                return result;
            }
        }
        public void fiveSwap(ref int no1, ref int no2)
        {
            int temp;

            temp = no1;
            no1 = no2;
            no2 = temp;
        }
        public void sixNullTest()
        {
            int? firstNumber1 = null;
            int? secondNumber2 = null;
            
            if(firstNumber1 == null)
            {
                Console.WriteLine("Enter First Number: ");
                firstNumber1 = Convert.ToInt32(Console.ReadLine());
            }
            if(secondNumber2 == null)
            {
                Console.WriteLine("Enter Second Number: ");
                secondNumber2 = Convert.ToInt32(Console.ReadLine());
            }
            int? result = firstNumber1 + secondNumber2;

            Console.WriteLine("Result is: {0}",result);
        }
        //Coaleasing Operator
        public void sevenNullTest()
        {
            int? firstNumber1 = null;
            int? secondNumber2 = 420;

            int thirdNumber3 = firstNumber1 ?? 500;

            Console.WriteLine("Third Number is : {0}",thirdNumber3);

            int fourNumber4 = secondNumber2 ?? 1000;

            Console.WriteLine("Now four Number is: {0}",fourNumber4);
        }
    }
}
