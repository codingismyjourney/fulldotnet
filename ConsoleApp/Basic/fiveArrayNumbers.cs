using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Basic
{
    class fiveArrayNumbers
    { 
        public void singleArrayTest()
        {
            int[] arrayNumbers = new int[5];

            arrayNumbers[0] = 00;
            arrayNumbers[1] = 11;
            arrayNumbers[2] = 22;
            arrayNumbers[3] = 33;
            arrayNumbers[4] = 44;

            for(int i = 0; i < arrayNumbers.Length; i++)
            {
                Console.WriteLine("So ArrayNumbers [{0}] = {1}",i,arrayNumbers[i]);
            }
        }
        public void singleArrayTestReadWrite() 
        {
            int[] arrayNumbers = new int[5];
            for(int i = 0; i<arrayNumbers.Length; i++)
            {
                Console.WriteLine("please enter int Numbers for arrayNumbers [{0}]",i);
                arrayNumbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach(int j in arrayNumbers)
            {
                Console.WriteLine("arrayNumbers = {0}",j);
            }
        }
        public void doubleArrayTestReadWrite()
        {
            double[] arrayNumbers = new double[5];
            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                Console.WriteLine("please enter double Numbers for arrayNumbers [{0}]", i);
                arrayNumbers[i] = Convert.ToDouble(Console.ReadLine());
            }
            foreach (double j in arrayNumbers)
            {
                Console.WriteLine("arrayNumbers = {0}", j);
            }
        }
    }
}
