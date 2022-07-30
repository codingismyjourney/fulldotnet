using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace ConsoleApp.Basic3
{
    class fiveReflection
    {
        public void oneReflectionTest()
        {
            Type type_ConsoleApp2Test = Type.GetType("ConsoleApp.Basic3.oneStudent");

            PropertyInfo[] propertiesofOneStudents = type_ConsoleApp2Test.GetProperties();

            foreach(PropertyInfo pro in propertiesofOneStudents)
            {
                Console.WriteLine(pro);
            }
        }

        public void twoReflectionTest()
        {
            Type type_ConsoleApp2Test = Type.GetType("ConsoleApp.Basic3.oneStudent");

            MethodInfo[] methodsofOneStudents = type_ConsoleApp2Test.GetMethods();

            foreach (MethodInfo proMethod in methodsofOneStudents)
            {
                Console.WriteLine(proMethod);
            }
        }
    }
}
