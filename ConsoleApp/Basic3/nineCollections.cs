using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Basic3
{
    class nineCollections
    {
        public void oneArrayList()
        {
            ArrayList AL_Numbers = new ArrayList();

            Console.WriteLine("Let's Add some Numbers in it");

            AL_Numbers.Add(1485);
            AL_Numbers.Add(255);
            AL_Numbers.Add(285);
            AL_Numbers.Add(295);
            AL_Numbers.Add(14785);

            Console.WriteLine("Capacity: {0}", AL_Numbers.Capacity);
            Console.WriteLine("Count: {0}", AL_Numbers.Count);

            Console.WriteLine("All Numbers:");

            foreach(int i in AL_Numbers)
            {
                Console.WriteLine("{0}", i);
            }

            Console.WriteLine();
            Console.WriteLine("Sorted Content:");
            AL_Numbers.Sort();
            foreach(int i in AL_Numbers)
            {
                Console.WriteLine(i + " ");
            }
        }

        public void twoHashTable()
        {
            Console.WriteLine("Hash Table");

            Hashtable HT_Students = new Hashtable();

            HT_Students.Add(001, "Samir Vohra");
            HT_Students.Add(002, "Ajay Jethava");
            HT_Students.Add(003, "Aj Jethava");

            //Get a collection of the keys.

            ICollection key = HT_Students.Keys;

            foreach(int k in key)
            {
                Console.WriteLine(k + ": " + HT_Students[k]);
                
            }
        }

        public void thirdSortedList()
        {
            SortedList SL_Students = new SortedList();

            SL_Students.Add(001, "Samir Vohra");
            SL_Students.Add(002, "Ajay Jethava");
            SL_Students.Add(003, "Ajju Jethava");

            ICollection key = SL_Students.Keys;
                
            foreach (int k in key)
            {
                Console.WriteLine(k + ": " + SL_Students[k]);
            }

            Console.WriteLine("Let me Check AJ Jethava is in List If not then add him");

            if (SL_Students.ContainsValue("AJ Jethava"))
            {
                Console.WriteLine("Yes that value is in List");
            }
            else 
            {
                SL_Students.Add(004, "AJ Jethava");
            }

            ICollection newKeys = SL_Students.Keys;

            foreach(int k in newKeys)
            {
                Console.WriteLine(k + ":" + SL_Students[k]);
            }
        }

        public void fourStack()
        {
            Stack ST_emp = new Stack();

            ST_emp.Push("Samir");
            ST_emp.Push("Ajay");
            ST_emp.Push("Apurv");

            Console.WriteLine("Current Stack : ");
            foreach(String emp in ST_emp)
            {
                Console.WriteLine(emp + " ");
            }

            ST_emp.Pop();

            Console.WriteLine("After Pop Current Stack : ");

            foreach(string emp in ST_emp)
            {   
                Console.WriteLine(emp + " ");
            }
        }

        public void fiveQueue()
        {
            Queue Q_Students = new Queue();

            Q_Students.Enqueue("Apurv");
            Q_Students.Enqueue("Ajay");
            Q_Students.Enqueue("Samir");

            Console.WriteLine("Current Queue : ");
            foreach (string stu in Q_Students)
            {
                Console.WriteLine(stu + " ");
            }

            Q_Students.Dequeue();

            Console.WriteLine("After DeQueue Current Queue is : ");
            foreach (string stu in Q_Students)
            {
                Console.WriteLine(stu + " ");
            }
        }
    }
}
