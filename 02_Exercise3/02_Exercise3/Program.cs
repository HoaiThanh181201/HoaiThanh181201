using System;
using System.IO;

namespace ListAllFileInDocument
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            ListAllFileInYourMyDocuments(@"D:\HOÀI_THANH\Exercise 3\ex3\02_Exercise3\02_Exercise3");
            Console.WriteLine("Press Enter to continute:");
            Console.ReadLine();
        }
        static void ListAllFileInYourMyDocuments(string WorkingMyDocuments)
        {
            string[] filePaths = Directory.GetFiles(WorkingMyDocuments);

            foreach (string filePath in filePaths)
            {
                Console.WriteLine(filePath);
            }
        }
    }
}