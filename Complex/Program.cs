using System;

namespace Complex
{
    class Program
    {
        static void Main(string[] args)
        {
			cmplx z = new cmplx(1, 1);
			cmplx z1;
			z1 = z - (z * z * z - 1) / (3 * z * z);
			Console.WriteLine("z1 = {0}", z1);
			Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
