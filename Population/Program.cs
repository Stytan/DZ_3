using System;

namespace Population
{
    class Program
    {
        static void Main(string[] args)
        {
			City cityLakhti = new Finland.Lahti();
			City cityZaporizhzhya = new Ukraine.Zaporizhzhya();
			City cityBirmingham = new UnitedKingdom.Birmingham();
			Console.WriteLine(cityLakhti);
			Console.WriteLine(cityZaporizhzhya);
			Console.WriteLine(cityBirmingham);
			Console.WriteLine("{0} < {1} = {2}", cityLakhti.Name, cityZaporizhzhya.Name, cityLakhti < cityZaporizhzhya);
			Console.WriteLine("{0} > {1} = {2}", cityLakhti.Name, cityZaporizhzhya.Name, cityLakhti > cityZaporizhzhya);
			Console.WriteLine("{0} < {1} = {2}", cityBirmingham.Name, cityZaporizhzhya.Name, cityBirmingham < cityZaporizhzhya);
			Console.WriteLine("{0} > {1} = {2}", cityBirmingham.Name, cityZaporizhzhya.Name, cityBirmingham > cityZaporizhzhya);
			Console.WriteLine("{0} == {1} = {2}", cityLakhti.Name, cityZaporizhzhya.Name, cityLakhti == cityZaporizhzhya);
			Console.WriteLine("{0} != {1} = {2}", cityZaporizhzhya.Name, cityZaporizhzhya.Name, !cityZaporizhzhya.Equals(cityZaporizhzhya));
			Console.WriteLine("{0} == {1} = {2}", cityZaporizhzhya.Name, cityZaporizhzhya.Name, cityZaporizhzhya == cityZaporizhzhya);
        	Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
        }
    }
}
