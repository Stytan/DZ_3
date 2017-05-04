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
            Description = "The Great Pyramid of Giza (also known as the Pyramid of Khufu or the Pyramid of Cheops) is the oldest and largest of the three pyramids in the Giza pyramid complex bordering what is now El Giza, Egypt. It is the oldest of the Seven Wonders of the Ancient World, and the only one to remain largely intact.";
        }

        #region implemented abstract members of Wonder

        public override void Show()
        {
            throw new NotImplementedException();
        }

        #endregion

        public override string ToString()
        {
            return base.ToString();
        }
    }
}