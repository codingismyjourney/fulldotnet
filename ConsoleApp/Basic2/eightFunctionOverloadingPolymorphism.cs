using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Basic2
{
    class eightFunctionOverloadingPolymorphism
    {
        public void oneTestFunction()
        {
            Console.WriteLine("I am in oneTestFunction , with no argument...");
        }

        public void oneTestFunction(int no1)
        {
            Console.WriteLine("I am in oneTestFunction with no1 = {0}",no1);
        }

        public void oneTestFunction(int no1, int no2)
        {
            Console.WriteLine("I am in oneTestFunction with no1 = {0} & no2 = {1}",no1,no2);
        }

        public void oneTestFunction(string oneString)
        {
            Console.WriteLine("I am in oneTestFunction with oneString = {0}",oneString);
        }
    }
}
