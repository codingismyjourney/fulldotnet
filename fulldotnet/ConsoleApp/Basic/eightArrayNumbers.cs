using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Basic
{
    class eightArrayNumbers
    {
        public void oneCheckJArray()    
        {
            int[][] a = new int[][]
            {
                new int[]{ 0,0 },
                new int[]{ 1,2 },
                new int[]{ 2,4 },
                new int[]{ 3,6 },
                new int[]{ 4,8 }    
            };
            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 2; j++)
                {
                    Console.WriteLine("a[{0}][{1}] = {2}",i ,j ,a[i][j]);
                }
            }
        }
        //C# - Passsing Arrays as an Arguments

        public double twoPassArrays(int[] myNumbers)
        {
            double sum = 0; 

            for(int i = 0; i < myNumbers.Length; i++)
            {
                sum = sum + myNumbers[i];
            }
            return sum;
        }

        //C# param Array

        public int threeParamArray(params int[] myNumbers)
        {
            int mySum = 0;

            foreach (int myNumber in myNumbers)
            {
                mySum = mySum + myNumber;
            }

            return mySum;
        }

        //C# Array Class
        public void fourArrayClass()
        {
            int[] myNumbers = new int[] { 2, 454, 5676, 2, 60 };

            //Get length of Array

            int myNumberlength = myNumbers.Length;
            Console.WriteLine("Length is: {0}" ,myNumberlength);

            //reverse Array

            int[] tempArray = myNumbers;
            Array.Reverse(tempArray);
            Console.WriteLine("Reverse Array is:");

            foreach(int i in tempArray)
            {
                Console.Write(i + " ");
            }

            //sort Array

            Array.Sort(tempArray);

            Console.WriteLine("Sorted Array is:");

            foreach(int i in tempArray)
            {
                Console.Write(i + " ");
            }
        }
    }
}
