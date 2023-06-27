using System;

namespace Calculadora
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Services.Methods();
            var sum = calculator.Somar(3, 6);
            Console.WriteLine(sum);
        }
    }
}
