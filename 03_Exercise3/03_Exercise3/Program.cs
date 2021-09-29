using System;
using System.IO;

namespace ReadTextFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input Something to file: ");
            string userName = Console.ReadLine();

            string[] lines = { userName };
            File.WriteAllLines(@"D:\HOÀI_THANH\exercise\03_Exercise3\03_Exercise3\bin\Debug\net5.0\03_Exercise3.exe", lines);
            foreach (string line in lines)
            {
                Console.WriteLine("\t" + line);
            }
            Console.WriteLine("the contents of the file: ");
            string[] readText = File.ReadAllLines(@"D:\HOÀI_THANH\exercise\03_Exercise3\03_Exercise3\bin\Debug\net5.0\03_Exercise3.exe");
            foreach (string s in readText)
            {
                Console.WriteLine("\t" + s);
            }
            Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }
    }
}
