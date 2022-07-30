using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Basic2
{
    class twoDefaultClass
    {
        int No1, No2, result;
        int No3;

        public void oneFunctionTest()
        {
            No1 = 34;
            No2 = 565;
            result = No1 + No2;

            Console.WriteLine("Result is = {0}", result);

            threeFunctionTest();
        }

        public void twoFunctionTest()
        {
            result = result + No1 + No2;
            Console.WriteLine("Result is = {0}", result);
            Console.WriteLine("No3 = {0}", No3);
        }

        //private access specifier allows a class to hide its member variables and member functions
        //from other functions and objects. Only functions of the same class can access its private members.

        private void threeFunctionTest()
        {
            No3 = 6;
        }

        public twoDefaultClass()
        {
            Console.WriteLine("C# Contructors - just Created");
        }

        ~twoDefaultClass()
        {
            Console.WriteLine("Destructor was called");
        }
    }
}   