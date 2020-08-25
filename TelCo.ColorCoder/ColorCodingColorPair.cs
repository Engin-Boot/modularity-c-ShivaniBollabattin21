using System;
using static TelCo.ColorCoder.ColourSpace;
using System.Drawing;

namespace TelCo.ColorCoder
{
    class ColorCodingColorPair
    {
       
        public static int GetPairNumberFromColor(ColorPair pair)
        {
            int majorIndex = -1;
            for (int i = 0; i < ColourSpace.getColorMapMajor().Length; i++)
            {
                if ((Color)ColourSpace.getColorMapMajor().GetValue(i) == pair.majorColor)
                {
                    majorIndex = i;
                    break;
                }
            }

            int minorIndex = -1;
            for (int i = 0; i < ColourSpace.getColorMapMinor().Length; i++)
            {
                if ((Color)ColourSpace.getColorMapMinor().GetValue(i) == pair.minorColor)
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

            
            return (majorIndex * ColourSpace.getColorMapMinor().Length) + (minorIndex + 1);
        }
    }
}
