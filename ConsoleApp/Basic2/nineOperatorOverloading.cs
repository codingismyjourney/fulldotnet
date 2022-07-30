using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Basic2
{
    class nineOperatorOverloading
    {
        public int oneNumber, twoNumber;

        public static nineOperatorOverloading operator +(nineOperatorOverloading nOO1, nineOperatorOverloading nOO2)
        {
            nineOperatorOverloading nOO3 = new nineOperatorOverloading();

            nOO3.oneNumber = nOO1.oneNumber + nOO2.oneNumber;
            nOO3.twoNumber = nOO1.twoNumber + nOO2.twoNumber;

            return nOO3;
        }

        public void oneTotal()
        {
            int result = oneNumber + twoNumber;

            Console.WriteLine("Total is = {0}",result);
        }
    }
}
