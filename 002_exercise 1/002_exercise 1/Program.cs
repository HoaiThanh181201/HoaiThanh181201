using System;

namespace _002_exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 integer numbers: ");
            Console.Write("x = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("y = ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sum = " + (a + b));
            Console.WriteLine("Subtract = " + (a - b));
            Console.WriteLine("Multiply = " + (a * b));
            Console.WriteLine("Divide = " + (a * 1.0 / b));
            Console.ReadKey();
        }
    }
}
