using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Basic
{
    class sevenArrayNumbers
    {
        public void oneTwoArray()
        {
            int[,] oneTwoArrayNumber = new int[2, 3]
            {
                {11,12,13},
                {21,22,23}
            };
            for(int i=0; i<2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("oneTwoArrayNumber [{0},{1}] : {2}",i,j,oneTwoArrayNumber[i,j]);
                }
            }
        }
        public void twoReadandWriteDArray()
        {
            int[,] oneTwoArrayNumbers = new int[2, 3];

            for(int i = 0 ; i < 2 ; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("oneTwoArrayNumbers[{0},{1}] : ", i, j);
                    oneTwoArrayNumbers[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("oneTwoArrayNumber [{0},{1}] : {2}", i, j, oneTwoArrayNumbers[i, j]);
                }
            }
        
        }
    }
}
