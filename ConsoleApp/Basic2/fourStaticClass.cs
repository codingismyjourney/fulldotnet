using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Basic2
{
    class fourStaticClass
    {
        public static string fName = "Ajay";
        public static string lName = "Jethava";

        public static void fullName()
        {
            Console.WriteLine("Full Name = {0}",fName + " " + lName);
        }
    }
}
