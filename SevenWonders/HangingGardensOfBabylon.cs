using System;

namespace SevenWonders
{
    public sealed class HangingGardensOfBabylon : Wonder
    {
        public HangingGardensOfBabylon()
        {
            name = "Hanging Gardens of Babylon";
            location = "Hillah or Nineveh, Iraq (32.5355°N 44.4275°E)";
            builders = "Babylonians or Assyrians";
            Description = "The Hanging Gardens were described as a remarkable " + 
                "feat of engineering: an ascending series of tiered gardens containing " +
                "all manner of trees, shrubs, and vines. The gardens were said to have " +
                "looked like a large green mountain constructed of mud bricks.";
        }
        public override void Show()
        {
            Console.WriteLine(@"  /\  /\__ _ _ __   __ _(_)_ __   __ _    / _ \__ _ _ __ __| | ___ _ __  ___ ");
            Console.WriteLine(@" / /_/ / _` | '_ \ / _` | | '_ \ / _` |  / /_\/ _` | '__/ _` |/ _ \ '_ \/ __|");
            Console.WriteLine(@"/ __  / (_| | | | | (_| | | | | | (_| | / /_\\ (_| | | | (_| |  __/ | | \__ \");
            Console.WriteLine(@"\/ /_/ \__,_|_| |_|\__, |_|_| |_|\__, | \____/\__,_|_|  \__,_|\___|_| |_|___/");
            Console.WriteLine(@"                   |___/         |___/ ");
            Console.WriteLine(@"        __     ___       _           _ ");
            Console.WriteLine(@"  ___  / _|   / __\ __ _| |__  _   _| | ___  _ __  ");
            Console.WriteLine(@" / _ \| |_   /__\/// _` | '_ \| | | | |/ _ \| '_ \ ");
            Console.WriteLine(@"| (_) |  _| / \/  \ (_| | |_) | |_| | | (_) | | | |");
            Console.WriteLine(@"\___ /|_|   \_____/\__,_|_.__/ \__, |_|\___/|_| |_|");
            Console.WriteLine(@"                               |___/");
        }
    }
}
