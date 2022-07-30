using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleAppdb.linqex
{
    class oneLinQ
    {

        //In LINQ query , use Var type when you want to make a 'custom' type on the fly.

        //In LINQ query, use IEnumerable when you already know the type of query result.


        public void oneTest()
        {
            string[] array_CountyNames = { "India", "Japan", "USA", "New Zealand" };

            //Get only sort words (3 Char or less)

            var sortNameCountries = from Country in array_CountyNames
                                    where
                                    Country.Length <= 3
                                    select Country;

            foreach (var sortNameCountry in sortNameCountries)
            {
                Console.WriteLine(sortNameCountry);
            }
        }

        public void twoTest()
        {
            string[] array_CountyNames = { "India", "Japan", "USA", "New Zealand", "UK" };

            //Get only sort words (3 Char or less)

            /*
            var sortNameCountries = from Country in array_CountyNames
                                    where
                                    Country.Length <= 3
                                    select Country;
            */

            var sortNameCountries = array_CountyNames.Where(Country => Country.Length <= 3);

            foreach (var sortNameCountry in sortNameCountries)
            {
                Console.WriteLine(sortNameCountry);
            }
        }
        public void thirdTest()
        {
            // Specify the data Source

            int[] marks = { 35, 40, 12, 7, 17, 15, 49 };

            //Define the Query Expression.

            IEnumerable<int> passStudents = from mark in marks
                                            where mark >= 18
                                            select mark;

            foreach (int mark in passStudents)
            {
                Console.WriteLine(mark);
            }
        }
        public void fourTest()
        {
            // Specify the data Source

            int[] marks = { 35, 40, 12, 7, 17, 15, 49 };

            //Define the Query Expression.

            /*
            IEnumerable<int> passStudents = from mark in marks
                                            where mark >= 18
                                            select mark;
            */

            var passStudents = marks.Where(mark => mark >= 18);

            foreach (int mark in passStudents)
            {
                Console.WriteLine(mark);
            }
        }
    }
}
