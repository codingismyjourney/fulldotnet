using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Basic  
{
    class oneHelloWorld
    {
        public void printMyMessage()
        {
            Console.WriteLine("I am Ajay Jethava");
        }
        public void printMyVar()
        {
            int firstNumber = 4;
            Console.WriteLine("First Number: {0}", firstNumber);
        }
        public void printSum()
        {
            int firstNumber = 10;
            int secondNumber = 20;

            int total = firstNumber + secondNumber;

            Console.WriteLine("Total of FirstNumber {0} and Second Number {1} is total = {2}",firstNumber,secondNumber,total);
        }
        public void printFloatNumbers()
        {
            float firstNumber = 50.5f;
            float secondNumber = 100.5f ;

            float total = firstNumber + secondNumber;

            Console.WriteLine("Total of FirstNumber {0} and Second Number {1} is Total = {2}", firstNumber, secondNumber, total);
        }
        public void printDecimalNumbers()
        {
            decimal firstNumber = 5.45689M;
            decimal secondNumber = 6.123486M;

            decimal total = firstNumber + secondNumber;

            Console.WriteLine("Total of firstNumber {0} and Second Number {1} is total = {2}",firstNumber,secondNumber,total);
        }   
        public void getNumbersfromUsers()
        {
            Console.WriteLine("Please Enter First Number:");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter Second Number:");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            int total = firstNumber + secondNumber;

            Console.WriteLine("total of firstnumber {0} and Seond NUmber {1} is total = {2}", firstNumber, secondNumber, total);
        }
        public void getNumbersfromUsersDec()
        {
            Console.WriteLine("Please Enter First Number:");
            decimal firstNumber = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Please Enter Second Number:");
            decimal secondNumber = Convert.ToDecimal(Console.ReadLine());

            decimal total = firstNumber + secondNumber;

            Console.WriteLine("total of firstnumber {0} and Seond NUmber {1} is total = {2}", firstNumber, secondNumber, total);
        }
    }
}