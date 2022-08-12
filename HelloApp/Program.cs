using System;
using MyCalc;

namespace HelloApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Calc calc = new Calc();
            Console.WriteLine($"Addition = {calc.Add(2, 5)}");
            Console.WriteLine($"Multiplication = {calc.Multiply(2, 5)}");
        }
    }
}
