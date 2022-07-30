using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Basic3
{
    class tenGenerics
    {
        public static void oneFunction(int no1, int no2)
        {
            bool result = no1 == no2;

            Console.WriteLine(result);
        }

        public static void twoFunction<T>(T no1, T no2)
        {
            bool result = no1.Equals(no2);

            Console.WriteLine(result);
        }
    }
}
