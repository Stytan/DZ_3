using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenWonders
{
    public sealed class StatueOfZeusAtOlympia : Wonder
    {
        public StatueOfZeusAtOlympia()
        {
            name = "Statue of Zeus at Olympia";
            location = "Olympia, Greece (37°38′16.3″N 21°37′48″E)";
            builders = "Greeks";
            Description = "The Statue of Zeus at Olympia was a giant seated figure, " +
                "about 13 m (43 ft) tall,[1] made by the Greek sculptor Phidias around " +
                "435 BC at the sanctuary of Olympia, Greece, and erected in the Temple " +
                "of Zeus there. A sculpture of ivory plates and gold panels over a wooden " +
                "framework, it represented the god Zeus sitting on an elaborate cedar wood " +
                "throne ornamented with ebony, ivory, gold and precious stones. One of the " +
                "Seven Wonders of the Ancient World,[2] it was lost and destroyed during the " +
                "5th century AD with no copy ever being found, and details of its form are " +
                "known only from ancient Greek descriptions and representations on coins.";
        }

        public override void Show()
        {
            Console.WriteLine(@" ________");
            Console.WriteLine(@"/\_____  \");
            Console.WriteLine(@"\/____//'/'     __   __  __    ____  ");
            Console.WriteLine(@"     //'/'    /'__`\/\ \/\ \  /',__\ ");
            Console.WriteLine(@"    //'/'___ /\  __/\ \ \_\ \/\__, `\");
            Console.WriteLine(@"    /\_______\ \____\\ \____/\/\____/");
            Console.WriteLine(@"    \/_______/\/____/ \/___/  \/___/ ");
        }
    }
}
