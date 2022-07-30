using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ConsoleApp.Basic3
{
    class twoTextFileWork
    {
        string filePathDetail = @"C:\Users\DELL\source\repos\fulldotnet\ConsoleApp\Basic3\mydatafiles\";

        public void oneTextFileCreate()
        {
            string fileNameDetail = "myFirstTextFileDetail.txt";
            string fullFileDetail = filePathDetail + fileNameDetail;

            if(File.Exists(fullFileDetail))
            {
                File.Delete(fullFileDetail);
            }
            else
            {
                using (StreamWriter sw = File.CreateText(fullFileDetail))
                {
                    sw.WriteLine("New File Created : {0}",DateTime.Now.ToString());
                    sw.WriteLine("Author : Samir Vohra");
                    sw.WriteLine("Add one more Line for Data");
                    sw.WriteLine("Add one more line for more data");
                    sw.WriteLine("Done!");
                }
                File.Exists(fullFileDetail);
            }
        }

        public void twoTextFileRead()
        {
            string fileNameDetail = "myFirstTextFileDetail.txt";
            string fullFileDetail = filePathDetail + fileNameDetail;

            if(File.Exists(fullFileDetail))
            {
                using (StreamReader sr = File.OpenText(fullFileDetail))
                {

                    string s = sr.ReadToEnd();

                    while(s != null)
                    {
                        Console.WriteLine(s);
                        s = null;
                    }
                }
            }
            else
            {
                oneTextFileCreate();
            }
        }
    }
}
