using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Basic
{
    struct bookStructure3
    {

        private int _id;
        private string _fName;
        private string _lName;

        public int Id
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

        public bookStructure3(int id , string fName , string lName)
        {
            this._id = id;
            this._fName = fName;
            this._lName = lName;
        }

        public void printDetail()
        {
            Console.WriteLine("ID = {0} , FirstName = {1} , LastName = {2}",this._id,this._fName,this._lName);
        }
    }
}
