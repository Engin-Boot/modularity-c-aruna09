﻿using System.Drawing;

namespace TelCo.ColorCoder
{
    /// <summary>
    /// The 25-pair color code, originally known as even-count color code, 
    /// is a color code used to identify individual conductors in twisted-pair 
    /// wiring for telecommunications.
    /// This class provides the color coding and 
    /// mapping of pair number to color and color to pair number.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Array of Major colors
        /// </summary>
        private static Color[] colorMapMajor;
        /// <summary>
        /// Array of minor colors
        /// </summary>
        private static Color[] colorMapMinor;
        public static Color[] ReturnColorMapMajor()
        {
            return colorMapMajor;
        }
        public static Color[] ReturnColorMapMinor()
        {
            return colorMapMinor;
        }
        public static void SetColorMapMajor(Color[] colorMap)
        {
            Program.colorMapMinor = colorMap;
        }
        public static void SetColorMapMinor(Color[] colorMap)
        {
            Program.colorMapMinor = colorMap;
        }
        static Program()
        {
            colorMapMajor = new Color[] { Color.White, Color.Red, Color.Black, Color.Yellow, Color.Violet };
            colorMapMinor = new Color[] { Color.Blue, Color.Orange, Color.Green, Color.Brown, Color.SlateGray };
        }
      
    }
}
