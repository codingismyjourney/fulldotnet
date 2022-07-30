using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Basic2
{
    class threeEncapsulationClass
    {
        private int _id;
        private string _fName;
        private string _lName;

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string fName
        {
            get { return _fName; }
            set { _fName = value; }
        }

        public string lName
        {
            get { return _lName; }
            set { _lName = value; }
        }

        public void printDetail()
        {
            Console.WriteLine("Id = {0} , FirstName = {1} , LastName = {2}",_id,_fName,_lName);
        }
    }
}
