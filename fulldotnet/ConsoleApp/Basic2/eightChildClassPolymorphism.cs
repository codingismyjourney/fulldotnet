using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Basic2
{
    class eightChildClassPolymorphism : eightAbstractClassPolymorphism
    {
        public override void oneSumFunction()
        {
            int no1 = 10, no2 = 20;
            int total = no1 + no2;
            Console.WriteLine("Result is = {0}",total);
        }

        public override void verFunctionTest()
        {
            Console.WriteLine("This is Overide Virtual Function..");
        }
    }
}
