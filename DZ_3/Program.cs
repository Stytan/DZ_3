using System;

namespace Equation
{
    class Program
    {
        public static void Main(string[] args)
        {
            LinearEqK LineEq1 = LinearEqK.Parse("12 10 -8");
            LinearEqK LineEq2 = LinearEqK.Parse("66 18 1");
            LinearEqK.WriteSolution(LineEq1, LineEq2);
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
