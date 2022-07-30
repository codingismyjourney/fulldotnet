using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Basic
{
    class twelveStructure
    {
        public void oneTestStructure()
        {
            bookStructure2 Book1 = new bookStructure2();
            bookStructure2 Book2 = new bookStructure2();

            Book1.getValues("C programming" , "Nuha Ali" , "C programing Tutorial" , 5456498);

            Book2.getValues("JAVA", "Xyz" , "JAVA Tutorial" , 9536216);

            Book1.display();    

            Book2.display();
        }
    }
}
