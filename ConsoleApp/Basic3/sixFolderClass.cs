using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ConsoleApp.Basic3
{
    class sixFolderClass
    {
        string rootPathDetail = @"C:\Users\DELL\source\repos\fulldotnet\ConsoleApp\Basic3\mydatafiles\myFiles\";
        string subFolderName, subFolderFullDetail, subFileDetail;
        
        private void createFolder()
        {
            Console.WriteLine("Please Enter Folder Name = ");
            subFolderName = Console.ReadLine();

            subFolderName = subFolderName.Replace(" ", string.Empty);

            subFolderFullDetail = rootPathDetail + subFolderName;

            if(!Directory.Exists(subFolderFullDetail))
            {
                Directory.CreateDirectory(subFolderFullDetail);
            }
        }

        private void createFiles()
        {
            Console.WriteLine("Please Enter File Name to Create a Text File = ");
            string fileName = Console.ReadLine();

            subFileDetail = rootPathDetail + fileName + ".txt";

            if(File.Exists(subFileDetail))
            {
                File.Delete(subFileDetail);
            }
            else
            {
                using (StreamWriter sw = File.CreateText(subFileDetail))
                {
                    Console.WriteLine("Please Enter First Name = ");
                    string firstName = Console.ReadLine();
                    Console.WriteLine("Please Enter Last Name = ");
                    string lastName = Console.ReadLine();
                    Console.WriteLine("Please Enter Surname = ");
                    string surName = Console.ReadLine();

                    sw.WriteLine(firstName);
                    sw.WriteLine(lastName);
                    sw.WriteLine(surName);

                }
                File.Exists(subFileDetail);
            }
        }

        public void oneIOTest()
        {
            //createFolder();
            createFiles();
        }
    }
}
