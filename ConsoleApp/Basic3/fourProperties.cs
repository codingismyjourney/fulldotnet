using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Basic3
{
    class fourProperties
    {
		private int _ID;
		private int _MobileNo;
		private string _FirstName;
		private string _LastName;

		public int ID
		{
			get { return _ID; }
			set { _ID = value; }
		}

		

		public int MobileNo
		{
			get { return _MobileNo; }
			set { _MobileNo = value; }
		}

		

		public string FirstName
		{
			get { return _FirstName; }
			set { _FirstName = value; }
		}

		

		public  string LastName
		{
			get { return _LastName; }
			set { _LastName = value; }
		}


		public override string ToString()
		{
			return "ID = " + ID + " Mobile_No. = " + MobileNo + " FirstName = " + FirstName + " LastName = " + LastName;
		}

	}
}
