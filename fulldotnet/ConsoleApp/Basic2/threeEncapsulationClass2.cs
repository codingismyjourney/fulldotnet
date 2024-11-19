using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Basic2
{
    class threeEncapsulationClass2
    {
        int firstNumber, secondNumber, result;

        public int oneResult()
        {
            getData();
            return result = firstNumber + secondNumber;
        }

        private void getData()
        {
            Console.WriteLine("Please Enter First Number = ");
            firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter Second Number = ");
            secondNumber = Convert.ToInt32(Console.ReadLine());
        }
    }
}
