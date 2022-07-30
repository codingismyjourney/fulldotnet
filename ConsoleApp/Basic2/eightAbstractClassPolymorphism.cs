using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Basic2
{
    abstract class eightAbstractClassPolymorphism
    {
        public abstract void oneSumFunction();
        
        public void twoSumFunction()
        {
            int no1 = 10, no2 = 20;

            int total = no1 + no2;

            Console.WriteLine("Total is = {0}",total);
        }

        public virtual void verFunctionTest()
        {
            Console.WriteLine("This is a Virtual Function...");
        }
    }
}
