using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleAppdb.linqex
{
    class fiveTest
    {
        public static void oneTest()
        {
            fivePet[] Cats = getCats();
            fivePet[] dogs = getDogs();

            IEnumerable<string> query = Cats.Select(cat => cat.strName).Concat(dogs.Select(dog => dog.strName));

            foreach (string stringName in query)
            {
                Console.WriteLine(stringName);
            }
        }



        public static fivePet[] getCats()
        {
            fivePet[] Cats = new fivePet[]
            {
                new fivePet{ intAge = 4 , strName = "Cat Name"},
                new fivePet{ intAge = 5 , strName = "Two Cat Name"},
                new fivePet{ intAge = 5 , strName = "Number three Cat Name"}
            };

            return Cats;
        }


        public static fivePet[] getDogs()
        {
            fivePet[] dogs = new fivePet[]
            {
                new fivePet{ intAge = 4 , strName = "Dog Name"},
                new fivePet{ intAge = 5 , strName = "Two Dog Name"},
                new fivePet{ intAge = 5 , strName = "Number three Dog Name"}
            };

            return dogs;
        }
    }
}
    