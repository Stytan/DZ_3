using System;

namespace SevenWonders
{
    /// <summary>
    /// Description of GreatPyramidOfGiza.
    /// </summary>
    public sealed class GreatPyramidOfGiza : Wonder
    {
        public GreatPyramidOfGiza()
        {
            name = "Great Pyramid of Giza";
            location = "Giza Necropolis, Egypt (29°58′45.03″N 31°08′03.69″E)";
            builders = "Egyptians";
            Description = "The Great Pyramid of Giza (also known as the Pyramid of " +
                "Khufu or the Pyramid of Cheops) is the oldest and largest of the three " +
                "pyramids in the Giza pyramid complex bordering what is now El Giza, Egypt. " +
                "It is the oldest of the Seven Wonders of the Ancient World, and the only " +
                "one to remain largely intact.";
        }

        #region implemented abstract members of Wonder
        public override void Show()
        {
            Console.WriteLine("                                          _L /L");
            Console.WriteLine("                                         _LT/l_L_");
            Console.WriteLine("                                       _LLl/L_T_lL_");
            Console.WriteLine("                   _T/L              _LT|L/_|__L_|_L_");
            Console.WriteLine("                 _Ll/l_L_          _TL|_T/_L_|__T__|_l_");
            Console.WriteLine("               _TLl/T_l|_L_      _LL|_Tl/_|__l___L__L_|L_");
            Console.WriteLine("             _LT_L/L_|_L_l_L_  _'|_|_|T/_L_l__T _ l__|__|L_");
            Console.WriteLine("           _Tl_L|/_|__|_|__T _LlT_|_Ll/_l_ _|__[ ]__|__|_l_L_");
            Console.WriteLine("    jjs_ _LT_l_l/|__|__l_T _T_L|_|_|l/___|__ | _l__|_ |__|_T_L_  __\n");
            Console.WriteLine("                           nn_r   nn_r                 __");
            Console.WriteLine(@"                     __   /l(\   /l)\      nn_r");
            Console.WriteLine(@"               __                         /\(\    __");
        }

        #endregion
    }
}