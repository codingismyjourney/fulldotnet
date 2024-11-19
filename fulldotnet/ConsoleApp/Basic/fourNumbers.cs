using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Basic
{
    class fourNumbers
    {
        public void whileLoopTest()
        {
            int i = 0;
            while (i <= 5)
            {
                Console.WriteLine("I is = {0}", i);
                i++;
            }
        }
        public void whileLoopTestNew()
        {
            int i = 5;
            while (i == 5)
            {
                Console.WriteLine("Yes I is 5");
                i = 0;

                Console.WriteLine("To continue Please Enter 5");
                i = Convert.ToInt32(Console.ReadLine());
            }
        }
        public void forLoopTest()
        {
            Console.WriteLine("This is Example of for loop");
            for(int i=0; i<=5; i++)
            {
                Console.WriteLine("I is = {0}",i);
            }
        }
        public void doWhileLoopTest()
        {
            int i = 0;
            do
            {
                Console.WriteLine("I is {0}", i);
                i++;
            } while (i <= 5);
        }
    }
}
