using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Basic3
{
    class sevenIndexers
    {
        private string[] nameList = new string[size];
        static public int size = 10;

        public sevenIndexers()
        {
            for (int i = 0; i < size; i++)
            {
                nameList[i] = "N.A";
            }
        }

        public string this[int index]
        {
            get
            {
                string tmp;

                if (index >= 0 && index <= size - 1)
                {
                    tmp = nameList[index];
                }
                else
                {
                    tmp = "";
                }
                return (tmp);
            }
            set
            {
                if (index >= 0 && index <= size - 1)
                {
                    nameList[index] = value;
                }
            }
        }
    }
}
