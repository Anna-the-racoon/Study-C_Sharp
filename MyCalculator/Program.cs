using Logic;
using System;

namespace MyCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();
            var result = calculator.PerformOperation("+",1,2);
            Console.WriteLine(result);
            
            Console.ReadLine();
        }
    }
}
