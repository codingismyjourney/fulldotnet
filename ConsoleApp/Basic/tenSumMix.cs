using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Basic
{
    class tenSumMix
    {
        public void oneDataType()
        {
            int intNo1, intNo2, intResult;
            Console.WriteLine("*******************");

            Console.WriteLine("Please Enter First Number: ");
            intNo1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter Second Number:");
            intNo2 = Convert.ToInt32(Console.ReadLine());

            intResult = intNo1 + intNo2;

            Console.WriteLine("Total is = {0}", intResult);
        }
        public void twoBool()
        {
            Console.WriteLine("*******************");

            bool flagCheck;
            flagCheck = Convert.ToBoolean(Console.ReadLine());

            if(flagCheck == true)
            {
                Console.WriteLine("bool is true");
            }
            else
            {
                Console.WriteLine("Something Wrong");
            }
        }
        public void threeByte()
        {
            byte byNo1, byNo2;
            int intResult;

            Console.WriteLine("*******************");

            Console.WriteLine("Please Enter First Number: ");
            byNo1 = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Please Enter Second Number: ");
            byNo2 = Convert.ToByte(Console.ReadLine());

            intResult = byNo1 + byNo2;

            Console.WriteLine("Total is = {0}" , intResult);
        }
        public void fourChar()
        {
            char charFlag;
            Console.WriteLine("*******************");

            Console.WriteLine("Please Enter Char = ");
            charFlag = Convert.ToChar(Console.ReadLine());

            if(charFlag == 'A')
            {
                Console.WriteLine("Oh.. its AA");
            }
            else if(charFlag == 'B')
            {
                Console.WriteLine("Oh.. its BB");
            }
            else
            {
                Console.WriteLine("I don't know");
            }
        }
        public void fiveDecimal()
        {   
            decimal decNo1, decNo2, decResult;

            Console.WriteLine("*******************");

            Console.WriteLine("Please Enter First Number: ");
            decNo1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Please Enter Second Number: ");
            decNo2 = Convert.ToDecimal(Console.ReadLine());

            decResult = decNo1 + decNo2;

            Console.WriteLine("Total is = {0}" , decResult);

        }
        public void sixFloat()
        {
            float fltNo1, fltNo2, fltResult;

            Console.WriteLine("*******************");

            Console.WriteLine("Please Enter First Number: ");
            fltNo1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Please Enter Second Number: ");
            fltNo2 = float.Parse(Console.ReadLine());

            fltResult = fltNo1 + fltNo2;

            Console.WriteLine("Total is = {0}" , fltResult);
        }
        public void sevenLong()
        {
            long lgNo1, lgNo2, lgResult;

            Console.WriteLine("*******************");

            Console.WriteLine("Please Enter First Number: ");
            lgNo1 = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Please Enter Second Number: ");
            lgNo2 = Convert.ToInt64(Console.ReadLine());

            lgResult = lgNo1 + lgNo2;

            Console.WriteLine("Total is = {0}", lgResult);
        }
        public void eightSbyte()
        {
            SByte sbNo1, sbNo2, sbResult;

            Console.WriteLine("*******************");

            Console.WriteLine("Please Enter First Number: ");
            sbNo1 = Convert.ToSByte(Console.ReadLine());

            Console.WriteLine("Please Enter Second Number: ");
            sbNo2 = Convert.ToSByte(Console.ReadLine());

            sbResult = (sbyte)(sbNo1 + sbNo2);

            Console.WriteLine("Total is: {0}" , sbResult);
        }
        public void nineShort()
        {
            short shNo1, shNo2;

            Console.WriteLine("*******************");

            Console.WriteLine("Please Enter First Number: ");
            shNo1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Please Enter Second Number: ");
            shNo2 = Convert.ToInt16(Console.ReadLine());

            long lgResult = shNo1 + shNo2;

            Console.WriteLine("Total is = {0}", lgResult);
        }

        public void tenConst()
        {
            const double pi = 3.14;

            double dblNo1 = 3456.377;

            //pi = dblNo1;

            Console.WriteLine("pi is = {0} and dblNo1 is = {1}", pi,dblNo1);
        }
    }
}
    