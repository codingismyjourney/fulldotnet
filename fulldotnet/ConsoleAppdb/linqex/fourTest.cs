    using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleAppdb.linqex
{
    class fourTest
    {
        public void oneTest()
        {
            fourPlant[] plants = new fourPlant[] {
                new fourCarnivorousPlant{ Name="Test New" , trapType="Snap Trap"},
                new fourCarnivorousPlant{ Name="Samir" , trapType="Pitfall Trap"},
                new fourCarnivorousPlant{ Name="Ajay" , trapType="Pitfall Trap"},
                new fourCarnivorousPlant{ Name="Kishan" , trapType="Snap Trap"}
            };

            var query = from fourCarnivorousPlant cPlant in plants
                        where cPlant.trapType == "Snap Trap"
                        select cPlant;

            foreach (var dlist in query)
            {
                Console.WriteLine("Name: {0} , TrapType: {1}", dlist.Name, dlist.trapType);
            }
        }

        

    }
}
