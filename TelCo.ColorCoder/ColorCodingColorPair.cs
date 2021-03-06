using System;
using static TelCo.ColorCoder.ColourSpace;
using System.Drawing;

namespace TelCo.ColorCoder
{
    class ColorCodingColorPair
    {

        public static int CheckColorandReturnIndex(Color[] colorArray, Color _color)
        {
            int index = -1;
            for (int i = 0; i < colorArray.Length; i++)
            {
                if ((Color)colorArray.GetValue(i) == _color)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        public static int GetPairNumberFromColor(ColorPair pair)
        {
            int majorIndex = -1;
            majorIndex = CheckColorandReturnIndex(ColourSpace.getColorMapMajor(), pair.majorColor);
            int minorIndex = -1;
            minorIndex = CheckColorandReturnIndex(ColourSpace.getColorMapMinor(), pair.minorColor);
            if (majorIndex == -1 || minorIndex == -1)
            {
                throw new ArgumentException(
                    string.Format("Unknown Colors: {0}", pair.ToString()));
            }
            return (majorIndex * ColourSpace.getColorMapMinor().Length) + (minorIndex + 1);
        }


    }
}
