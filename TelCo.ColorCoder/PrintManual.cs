using System;
using System.Collections.Generic;
using System.Text;
using static TelCo.ColorCoder.ColourSpace;

namespace TelCo.ColorCoder
{
    class PrintManual
    {
        public override string ToString()
        {
            string colorCodes = "";
            for(int i = 1; i < 26; i++)
            {
                ColorPair pair = ColorCodingPairNumber.GetColorFromPairNumber(i);
                colorCodes = colorCodes + "PAIR NUMBER = " + i + " "  + "MAJOR COLOR = " + " " + pair.majorColor + "MINOR COLOR = " +" "+ pair.minorColor + "\n";
            }
            return colorCodes;
        }
    }
}
