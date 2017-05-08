using System;

namespace Fract
{
    class Program
    {
        public static void Main(string[] args)
        {
            var fr1 = new Fraction(625, 15);
            var fr2 = new Fraction(1.35);
            Console.WriteLine("{0}, NOD={1}, NOK={2}", fr1, fr1.NOD(), fr1.NOK());
            Console.WriteLine("Reduce: {0}, NOD={1}, NOK={2}", fr1.Reduce(), fr1.NOD(), fr1.NOK());
            Console.WriteLine("fr2 = Fraction(1.35) = {0}, NOD={1}, NOK={2}", fr2, fr2.NOD(), fr2.NOK());
            Console.WriteLine("(double)fr2 = {0}", (double)fr2);
            Console.WriteLine("{0} * {1} = {2} = {3}", fr1, fr2, fr1 * fr2, (fr1 * fr2).Reduce());
            Console.WriteLine("{0} / {1} = {2}", fr1, fr2, fr1 / fr2);
            Console.WriteLine("{0} + {1} = {2}", fr1, fr2, fr1 + fr2);
            Console.WriteLine("{0} - {1} = {2}", fr1, fr2, fr1 - fr2);
            Console.WriteLine("{0} == {1} = {2}", fr1, fr2, fr1 == fr2);
            Console.WriteLine("{0} == {1} = {2}", fr1, fr1, fr1 == fr1);
            Console.WriteLine("{0} > {1} = {2}", fr1, fr2, fr1 > fr2);
            Console.WriteLine("{0} < {1} = {2}", fr1, fr2, fr1 < fr2);
            Fraction f = new Fraction(3, 4);
            int a = 10;
            Fraction f1 = f * a;
            Console.WriteLine("{0} * {1} = {2}", f, a, f1);
            Fraction f2 = a * f;
            Console.WriteLine("{0} * {1} = {2}", a, f, f2);
            double d = 1.5;
            Fraction f3 = f + d;
            Console.WriteLine("{0} + {1} = {2}", f, d, f3);
            if (f) Console.WriteLine("{0} = true", f);
            else Console.WriteLine("{0} = false", f);
            if (fr1) Console.WriteLine("{0} = true", fr1);
            else Console.WriteLine("{0} = false", fr1);
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
