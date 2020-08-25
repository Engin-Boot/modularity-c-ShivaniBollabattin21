﻿using System;
using static TelCo.ColorCoder.ColourSpace;
using System.Drawing;

namespace TelCo.ColorCoder
{
    class ColorCodingColorPair
    {
        private static ColourSpace space;
        public ColorCodingColorPair()
        {
            space = new ColourSpace();
        }

        public int GetPairNumberFromColor(ColorPair pair)
        {
            int majorIndex = -1;
            for (int i = 0; i < space.getColorMapMajor().Length; i++)
            {
                if ((Color)space.getColorMapMajor().GetValue(i) == pair.majorColor)
                {
                    majorIndex = i;
                    break;
                }
            }

            int minorIndex = -1;
            for (int i = 0; i < space.getColorMapMinor().Length; i++)
            {
                if ((Color)space.getColorMapMinor().GetValue(i) == pair.minorColor)
                {
                    minorIndex = i;
                    break;
                }
            }
            if (majorIndex == -1 || minorIndex == -1)
            {
                throw new ArgumentException(
                    string.Format("Unknown Colors: {0}", pair.ToString()));
            }

            
            return (majorIndex * space.getColorMapMinor().Length) + (minorIndex + 1);
        }
    }
}
