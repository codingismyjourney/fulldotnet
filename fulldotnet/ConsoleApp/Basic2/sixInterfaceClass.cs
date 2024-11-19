using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Basic2
{
    class sixInterfaceClass : sixInterfaceClassInterface
    {
        public int oneTotal(int no1, int no2)
        {
            int result = no1 + no2;
            return result;
        }
    }
}
