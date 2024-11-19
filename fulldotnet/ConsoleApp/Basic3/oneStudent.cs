using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Basic3
{
    class oneStudent
    {
		private int _Id;
		private string _FirstName;
		private string _LastName;

		public int id	
		{
			get { return _Id; }
			set { _Id = value; }
		}

		

		public string firstName
		{
			get { return _FirstName; }
			set { _FirstName = value; }
		}

		

		public string lastName
		{
			get { return _LastName; }
			set { _LastName = value; }
		}

		public oneStudent(int ID, string myFirstName, string myLastName)
		{
			this.id = ID;
			this.firstName = myFirstName;
			this.lastName = myLastName;
		}

		public oneStudent()
		{
			this.id = -1;
			this.firstName = string.Empty;
			this.lastName = string.Empty;
		}

		public void oneFullName()
		{
			string fullName = firstName + " " + lastName;
			Console.WriteLine("Full Name = {0}", fullName);
		}

	}
}
