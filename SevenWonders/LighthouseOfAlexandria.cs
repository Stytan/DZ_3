using System;

namespace SevenWonders
{
	/// <summary>
	/// Александрийский маяк
	/// </summary>
	public sealed class LighthouseOfAlexandria : Wonder
	{
		public LighthouseOfAlexandria()
		{
			name = "Lighthouse of Alexandria";
			location = "Alexandria, Egypt (31°12′50″N 29°53′08″E)";
			builders = "Greeks, Ptolemaic Egyptians";
			Description = "The lighthouse was constructed in the 3rd century BC. " +
			"After Alexander the Great died of a fever at age 32, the first " +
			"Ptolemy (Ptolemy I Soter) announced himself king in 305 BC, and " +
			"commissioned its construction shortly thereafter.";
		}

		public override void Show()
		{
			Console.WriteLine(@"               .n.                     |");
			Console.WriteLine(@"              / ___\          _.---.  \ _ /");
			Console.WriteLine(@"              [|||]         (_._ ) )--;_) =-");
			Console.WriteLine(@"              [___]           '---'.__,' \");
			Console.WriteLine(@"              }-=-{                    |");
			Console.WriteLine("              |-\" | ");
			Console.WriteLine("              |.-\"|                p");
			Console.WriteLine(@"       ~^=~^~-|_.-|~^-~^~ ~^~ -^~^~|\ ~^-~^~-");
			Console.WriteLine(@"       ^   .=.| _.|__  ^       ~  /| \");
			Console.WriteLine("        ~ /:. \\\" _|_/\\    ~      /_|__\\  ^ ");
			Console.WriteLine("       .-/::.  |   |\"\"|-._    ^   ~~~~");
			Console.WriteLine("         `===-'-----'\"\"`  '-.              ~");
			Console.WriteLine(@"                        __.-'      ^");
		}
	}
}
