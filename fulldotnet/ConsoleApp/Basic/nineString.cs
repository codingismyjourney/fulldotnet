using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Basic
{
    class nineString
    {
        public void oneString()
        {
            string fName, lName, fullName;

            Console.WriteLine("Enter the First Name: ");
            fName = Console.ReadLine();

            Console.WriteLine("Enter the Last Name: ");
            lName = Console.ReadLine();

            fullName = fName + " " + lName;

            Console.WriteLine("Your first Name is {0} and last Name is {1} and Your Full Name is = {2} ", fName, lName, fullName);
        }

        // Read Char and Convert Char Array to String

        public void twoCharToString()
        {
            Console.WriteLine("You want to convert char array to String....");
            char flagCheck = Console.ReadKey().KeyChar;

            Console.WriteLine("Your Flag is = {0}", flagCheck);
            char[] charData = { 'A', 'j', 'a', 'y' };
            string stringData = " ";

            if (flagCheck == 'y' || flagCheck == 'Y')
            {
                stringData = new String(charData);
            }
            Console.WriteLine("Your String is = {0}", stringData);
        }
        public void threeJoinArray()
        {
            string[] strTestArra = { "I", "am", "Ajay", "Jethava" };

            string strNewTestAray = string.Join(" ", strTestArra);

            Console.WriteLine("New String from Array = {0}", strNewTestAray);

        }
        // Compare two String

        public void fourCompareString()
        {
            string firstEntry, lastEntry;

            Console.WriteLine("Please Enter the First String: ");
            firstEntry = Console.ReadLine();

            Console.WriteLine("Please Enter the Second String: ");
            lastEntry = Console.ReadLine();

            if (firstEntry.Equals(lastEntry))
            {
                Console.WriteLine("Both String Are Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
        }
        public void fiveSearchString()
        {
            string strPara, strSearchKeyword;

            Console.WriteLine("Please Enter para For Testing : ");
            strPara = Console.ReadLine();

            Console.WriteLine("Please  Enter Search Keyword : ");
            strSearchKeyword = Console.ReadLine();

            if (strPara.Contains(strSearchKeyword))
            {
                Console.WriteLine("yes This Keyword is in String");
            }
            else
            {
                Console.WriteLine("No Not Contain Keyword");
            }
        }
        public void sixSearchString()
        {
            string strPara, strSearchKeyword;

            Console.WriteLine("Please Enter para For Testing : ");
            strPara = Console.ReadLine().ToLower();

            Console.WriteLine("Please  Enter search Keyword : ");
            strSearchKeyword = Console.ReadLine().ToLower();

            if (strPara.Contains(strSearchKeyword))
            {
                Console.WriteLine("yes This Keyword is in String");
            }
            else
            {
                Console.WriteLine("No Not Contain Keyword");
            }
        }
    }
}
