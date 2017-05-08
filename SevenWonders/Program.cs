using System;
using SevenWonders;

namespace DZ_3
{
	class Program
	{
		static void Main(string[] args)
		{
			Wonder[] Wonders = { new GreatPyramidOfGiza(),
				new HangingGardensOfBabylon(),
				new TempleOfArtemisAtEphesus(),
				new StatueOfZeusAtOlympia(),
				new MausoleumAtHalicarnassus(),
				new ColossusOfRhodes(),
				new LighthouseOfAlexandria()
			};
			foreach (Wonder w in Wonders) {
				Console.WriteLine("\n\n" + w);
				w.Show();
			}
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
