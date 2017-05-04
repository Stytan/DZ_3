using System;

namespace SevenWonders
{
    public sealed class MausoleumAtHalicarnassus : Wonder
    {
        public MausoleumAtHalicarnassus()
        {
            name = "Mausoleum at Halicarnassus";
            location = "Bodrum, Turkey (37.0379°N 27.4241°E)";
            builders = "Greeks, Persians, Carians";
            Description = "The Mausoleum at Halicarnassus or Tomb of Mausolus[a] " +
                "(Ancient Greek: Μαυσωλεῖον τῆς Ἁλικαρνασσοῦ; Turkish: Halikarnas Mozolesi) " +
                "was a tomb built between 353 and 350 BC at Halicarnassus (present Bodrum, Turkey) " +
                "for Mausolus, a satrap in the Persian Empire, and his sister-wife Artemisia " +
                "II of Caria. The structure was designed by the Greek architects Satyros and " +
                "Pythius of Priene.";
        }

        public override void Show()
        {
            Console.WriteLine(@"                              _                              _");
            Console.WriteLine(@"  /\/\   __ _ _   _ ___  ___ | | ___ _   _ _ __ ___     __ _| |_");
            Console.WriteLine(@" /    \ / _` | | | / __|/ _ \| |/ _ \ | | | '_ ` _ \   / _` | __|");
            Console.WriteLine(@"/ /\/\ \ (_| | |_| \__ \ (_) | |  __/ |_| | | | | | | | (_| | |_");
            Console.WriteLine(@"\/    \/\__,_|\__,_|___/\___/|_|\___|\__,_|_| |_| |_|  \__,_|\__|");
            Console.WriteLine(@"             _ _");
            Console.WriteLine(@"  /\  /\__ _| (_) ___ __ _ _ __ _ __   __ _ ___ ___ _   _ ___");
            Console.WriteLine(@" / /_/ / _` | | |/ __/ _` | '__| '_ \ / _` / __/ __| | | / __|");
            Console.WriteLine(@"/ __  / (_| | | | (_| (_| | |  | | | | (_| \__ \__ \ |_| \__ \");
            Console.WriteLine(@"\/ /_/ \__,_|_|_|\___\__,_|_|  |_| |_|\__,_|___/___/\__,_|___/");
        }
    }
}
