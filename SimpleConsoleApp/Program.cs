using System;
using SimpleMathClassLibrary;

namespace SimpleConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Console Calculator");
            Calculator calc = new Calculator();
            int result = calc.addition(10, 20);
            Console.WriteLine($"Addition of 10 and 20 = {result}");
        }
    }
}
