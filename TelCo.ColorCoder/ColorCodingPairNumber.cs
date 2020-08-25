using System;
using System.Collections.Generic;
using static TelCo.ColorCoder.ColourSpace;
using System.Text;
using System.Drawing;

namespace TelCo.ColorCoder
{
    class ColorCodingPairNumber
    {
        private static ColourSpace space;
        public ColorCodingPairNumber()
        {
            space = new ColourSpace();
        }

        public  ColorPair GetColorFromPairNumber(int pairNumber)
        {
            int minorSize = space.getColorMapMinor().Length;
            int majorSize = space.getColorMapMajor().Length;
            if (pairNumber < 1 || pairNumber > minorSize * majorSize)
            {
                throw new ArgumentOutOfRangeException(
                    string.Format("Argument PairNumber:{0} is outside the allowed range", pairNumber));
            }

            int zeroBasedPairNumber = pairNumber - 1;
            int majorIndex = zeroBasedPairNumber / minorSize;
            int minorIndex = zeroBasedPairNumber % minorSize;
            ColorPair pair = new ColorPair()
            {
                majorColor = (Color)space.getColorMapMajor().GetValue(majorIndex),
                minorColor = (Color)space.getColorMapMajor().GetValue(majorIndex)
            };

            return pair;
        }

    }
}
