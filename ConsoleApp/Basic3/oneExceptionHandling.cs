using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Basic3
{
    class oneExceptionHandling
    {
        public void oneTryCatch()
        {
            int firstNumber, secondNumber, result;
            try
            {
                Console.WriteLine("Please Enter First Number = ");
                firstNumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please Enter Second Number = ");
                secondNumber = Convert.ToInt32(Console.ReadLine());

                result = firstNumber / secondNumber;

                Console.WriteLine("Result is = {0}", result);
            }
            catch (Exception e)
            {
                Console.WriteLine("Please Do not use 0 as Second Number [{0}]", e);

                //when you want to throw e to user(user define or system define)
                //throw e;
            }
        }
    }
}
