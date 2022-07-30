using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Basic
{
    class fourteenEnums
    {
        enum enumDays {Sun , Mon , Tue , Wed , Thu , Fri , Sat};
        
        public void oneEnumTest()
        {
            int startDay = (int)enumDays.Mon;
            int weekEndDay = (int)enumDays.Fri;

            Console.WriteLine("Monday : {0}",startDay);
            Console.WriteLine("Friday : {0}",weekEndDay);
        }
        public void twoEnumTest()
        {
            string[] weekDays = Enum.GetNames(typeof(enumDays));

            foreach(string weekDay in weekDays)
            {
                Console.WriteLine("Week Day : {0} ",weekDay);
            }
        }
    }
}
