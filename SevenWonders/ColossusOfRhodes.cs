using System;

namespace SevenWonders
{
    public sealed class ColossusOfRhodes : Wonder
    {
        public ColossusOfRhodes()
        {
            name = "Colossus of Rhodes";
            location = "Rhodes, Greece (36°27′04″N 28°13′40″E)";
            builders = "Greeks";
            Description = "The Colossus of Rhodes was a statue of the Greek titan-god " +
                "of the sun Helios, erected in the city of Rhodes, on the Greek island " +
                "of the same name, by Chares of Lindos in 280 BC. One of the Seven Wonders " +
                "of the Ancient World, it was constructed to celebrate Rhodes' victory over " +
                "the ruler of Cyprus, Antigonus I Monophthalmus, whose son unsuccessfully " +
                "besieged Rhodes in 305 BC. According to most contemporary descriptions, " +
                "the Colossus stood approximately 70 cubits, or 33 metres (108 feet) high—the " +
                "approximate height of the modern Statue of Liberty from feet to crown—making " +
                "it the tallest statue of the ancient world.[2] It was destroyed during the " +
                "earthquake of 226 BC, and never rebuilt.";
        }

        public override void Show()
        {
            Console.WriteLine(@" ___           _                                               ___");
            Console.WriteLine(@"(  _`\        (_ )                                           /'___)");
            Console.WriteLine(@"| ( (_)   _    | |    _     ___   ___  _   _   ___       _   | (__");
            Console.WriteLine(@"| |  _  /'_`\  | |  /'_`\ /',__)/',__)( ) ( )/',__)    /'_`\ | ,__)");
            Console.WriteLine(@"| (_( )( (_) ) | | ( (_) )\__, \\__, \| (_) |\__, \   ( (_) )| |");
            Console.WriteLine(@"(____/'`\___/'(___)`\___/'(____/(____/`\___/'(____/   `\___/'(_)  ");
            Console.WriteLine(@" ___    _                 _");
            Console.WriteLine(@"|  _`\ ( )               ( )");
            Console.WriteLine(@"| (_) )| |__     _      _| |   __    ___");
            Console.WriteLine(@"| ,  / |  _ `\ /'_`\  /'_` | /'__`\/',__)");
            Console.WriteLine(@"| |\ \ | | | |( (_) )( (_| |(  ___/\__, \");
            Console.WriteLine(@"(_) (_)(_) (_)`\___/'`\__,_)`\____)(____/");
        }
    }
}
