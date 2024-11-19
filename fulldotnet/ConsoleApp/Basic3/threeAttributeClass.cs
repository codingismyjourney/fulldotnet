using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Basic3
{
    class threeAttributeClass
    {
     
    [Obsolete ("use oneSum(int No1,int No2,int No3) instead of oneSum(int No1,int No2)")]

        public int oneSum(int No1, int No2)
        {
            return No1 + No2;
        }

        public int oneSum(int No1, int No2, int No3)
        {
            return No1 + No2 + No3;
        }

    [Obsolete("use twoSum(int No1,int No2,int No3) instead of twoSum(int No1,int No2)",true)]

        public int twoSum(int No1, int No2)
        {
            return No1 + No2;
        }

        public int twoSum(int No1, int No2, int No3)
        {
            return No1 + No2 + No3;
        }
    }
}
