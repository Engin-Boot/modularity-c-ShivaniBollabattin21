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
            {using System;
using static TelCo.ColorCoder.ColourSpace;
using System.Drawing;

namespace TelCo.ColorCoder
{
    class ColorCodingColorPair
    {

        public static int _checkColor(Color[] colorArray, Color _color)
        {
            int index = 0;
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
            majorIndex = _checkColor(ColourSpace.getColorMapMajor(), pair.majorColor);
            int minorIndex = -1;
            minorIndex = _checkColor(ColourSpace.getColorMapMinor(), pair.minorColor);
            if (majorIndex == -1 || minorIndex == -1)
            {
                throw new ArgumentException(
                    string.Format("Unknown Colors: {0}", pair.ToString()));
            }
            return (majorIndex * ColourSpace.getColorMapMinor().Length) + (minorIndex + 1);
        }


    }
}

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
