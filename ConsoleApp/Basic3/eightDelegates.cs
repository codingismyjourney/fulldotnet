using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Basic3
{
    public delegate void Del_oneHello(string msg);
    public delegate void Del_twoHelloWorld(string myName, string myTech);
    
    class eightDelegates
    {
        public static void oneHello(string msg)
        {
            Console.WriteLine(msg);
        }

        public static void twoHelloWorld(string myName, string myTech)
        {
            Console.WriteLine("I am {0} & I like to work in {1}", myName, myTech);
        }

        public static void thirdHello(string myClass)
        {
            Console.WriteLine(myClass);
        }
    }
}
