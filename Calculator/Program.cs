using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter y: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"sum {x} + {y} = {Calculator.BinarySum(x, y)}");
        }
    }
}
