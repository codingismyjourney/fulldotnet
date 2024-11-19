using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleAppdb.linqex
{
    class twoCompany
    {
        public static void oneSelectEmpandDept()
        {
            List<twoDepartmentClass> departments = new List<twoDepartmentClass>();

            //Add some Departments.

            departments.Add(new twoDepartmentClass { DepartmentId = 1, Name = "Account" });
            departments.Add(new twoDepartmentClass { DepartmentId = 2, Name = "Sales" });
            departments.Add(new twoDepartmentClass { DepartmentId = 3, Name = "Marketing" });
              
            List<twoEmployeeClass> employees = new List<twoEmployeeClass>();

            //Add some emp.

            employees.Add(new twoEmployeeClass { EmployeeId = 1, EmployeeName = "Samir", DepartmentId = 3 });
            employees.Add(new twoEmployeeClass { EmployeeId = 2, EmployeeName = "Ajay", DepartmentId = 2 });
            employees.Add(new twoEmployeeClass { EmployeeId = 3, EmployeeName = "Apurv", DepartmentId = 1 });
            employees.Add(new twoEmployeeClass { EmployeeId = 4, EmployeeName = "Jaydeep", DepartmentId = 3 });
            employees.Add(new twoEmployeeClass { EmployeeId = 5, EmployeeName = "Chintan", DepartmentId = 3 });
            employees.Add(new twoEmployeeClass { EmployeeId = 6, EmployeeName = "Mihir", DepartmentId = 2 });
            employees.Add(new twoEmployeeClass { EmployeeId = 7, EmployeeName = "Ruchita", DepartmentId = 4 });

            ////////////Join Query...


            var emplist = (from emp in employees join dpt in departments on
                           emp.EmployeeId equals dpt.DepartmentId
                           select new
                           {
                               EmployeeName = emp.EmployeeName,
                               DepartmentName = dpt.Name
                           });

            foreach(var emp in emplist)
            {
                Console.WriteLine("Employee Name = {0} , Department Name = {1}", emp.EmployeeName, emp.DepartmentName);
            }
        }
    }
}
