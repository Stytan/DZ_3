using System;

namespace SevenWonders
{
	/// <summary>
	/// Храм Артемиды в Эфесе
	/// </summary>
	public sealed class TempleOfArtemisAtEphesus : Wonder
	{
		public TempleOfArtemisAtEphesus()
		{
			name = "Temple of Artemis at Ephesus";
			location = "Near Selçuk, Turkey (37°56′59″N 27°21′50″E)";
			builders = "Greeks, Lydians";
			Description = "The Temple of Artemis or Artemision, also known " +
			"less precisely as the Temple of Diana, was a Greek temple " +
			"dedicated to the goddess Artemis. It was located in Ephesus " +
			"(near the modern town of Selçuk in present-day Turkey). " +
			"One of the Seven Wonders of the Ancient World, it was completely " +
			"rebuilt three times before its final destruction in 401 AD. " +
			"Only foundations and sculptural fragments of the latest of the " +
			"temples at the site remain.";
		}
		public override void Show()
		{

			Console.WriteLine("░░░░░░░░░░░░░░▄▄██▄▄░░░░░░░░░░░░░░");
			Console.WriteLine("░░░░░░░░░░░▄██████████▄░░░░░░░░░░░");
			Console.WriteLine("░░░░░░░▄▄████████████████▄▄░░░░░░░");
			Console.WriteLine("░░░▄▄████████████████████████▄▄░░░");
			Console.WriteLine("░░▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀░░");
			Console.WriteLine("░░░▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀░░░");
			Console.WriteLine("░░░░██░░░░░░██░░░░░░██░░░░░░██░░░░");
			Console.WriteLine("░░░░██░░░░░░██░░░░░░██░░░░░░██░░░░");
			Console.WriteLine("░░░░██░░░░░░██░░░░░░██░░░░░░██░░░░");
			Console.WriteLine("░░░░██░░░░░░██░░░░░░██░░░░░░██░░░░");
			Console.WriteLine("░░░░██░░░░░░██░░░░░░██░░░░░░██░░░░");
			Console.WriteLine("░░░░██░░░░░░██░░░░░░██░░░░░░██░░░░");
			Console.WriteLine("░░░░██░░░░░░██░░░░░░██░░░░░░██░░░░");
			Console.WriteLine("░░░░██░░░░░░██░░░░░░██░░░░░░██░░░░");
			Console.WriteLine("░░░░▀▀░░░░░░▀▀░░░░░░▀▀░░░░░░▀▀░░░░");
			Console.WriteLine("░░░████████████████████████████░░░");
		}
	}
}
