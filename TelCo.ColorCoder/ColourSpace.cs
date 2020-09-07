using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Diagnostics;

namespace TelCo.ColorCoder
{
    class ColourSpace
    {
        protected static Color[] colorMapMajor;

        protected  static Color[] colorMapMinor;

        internal class ColorPair
        {
            internal Color majorColor;
            internal Color minorColor;
            public override string ToString()
            {
                return string.Format("MajorColor:{0}, MinorColor:{1}", majorColor.Name, minorColor.Name);
            }
        }

        static ColourSpace()
        {
            colorMapMajor = new Color[] { Color.White, Color.Red, Color.Black, Color.Yellow, Color.Violet };
            colorMapMinor = new Color[] { Color.Blue, Color.Orange, Color.Green, Color.Brown, Color.SlateGray };
        }

        public static Color[] getColorMapMajor()
        {
            return colorMapMajor;
        }

        public static Color[] getColorMapMinor()
        {
            return colorMapMinor;
        }

    }
}
