using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Basic
{
    class threeNumbers
    {
        public void switchTestOne()
        {
            Console.WriteLine("Please Enter Any Number:");
            int numberOneByUser = Convert.ToInt32(Console.ReadLine());

            switch (numberOneByUser)
            {
                case (1):
                    Console.WriteLine("I am in Number one");
                    break;
                case (2):
                    Console.WriteLine("I am in number Two");
                    break;
                case (3):
                    Console.WriteLine("I am in number Three");
                    break;
                default:
                    Console.WriteLine("I am in Default");
                    break;
            }
        }
        public void switchTestNested()
        {
            Console.WriteLine("Please Enter Any Number:");
            int numberOneByUser = Convert.ToInt32(Console.ReadLine());
            int numberTwoBySystem = 6;
            switch (numberOneByUser)
            {
                case (1):
                    Console.WriteLine("I am in Number one");
                    break;
                case (2):
                    Console.WriteLine("I am in number Two");
                    break;
                case (3):
                    Console.WriteLine("I am in number Three");
                    break;
                case (5):
                    switch(numberTwoBySystem)
                    {
                        case (1):
                            Console.WriteLine("I am in inner switch");
                            break;
                        case (6):
                            Console.WriteLine("Ok now it has number 6");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("I am in Default");
                    break;
            }
        }
    }
}