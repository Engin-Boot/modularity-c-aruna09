using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace TelCo.ColorCoder
{
    class PairFromColor
    {
        public static Color[] CopyOfColorMapMajor = Program.ReturnColorMapMajor();
        public static Color[] CopyOfColorMapMinor = Program.ReturnColorMapMinor();
        public static int GetPairNumberFromColor(ColorPair pair)
        {
            // Find the major color in the array and get the index
            int majorIndex = -1;
            for (int i = 0; i < CopyOfColorMapMajor.Length; i++)
            {
                if (CopyOfColorMapMajor[i] == pair.majorColor)
                {
                    majorIndex = i;
                    break;
                }
            }

            // Find the minor color in the array and get the index
            int minorIndex = -1;
            for (int i = 0; i < CopyOfColorMapMinor.Length; i++)
            {
                if (CopyOfColorMapMinor[i] == pair.minorColor)
                {
                    minorIndex = i;
                    break;
                }
            }
            // If colors can not be found throw an exception
            if (majorIndex == -1 || minorIndex == -1)
            {
                throw new ArgumentException(
                    string.Format("Unknown Colors: {0}", pair.ToString()));
            }

            // Compute pair number and Return  
            // (Note: +1 in compute is because pair number is 1 based, not zero)
            Program.SetColorMapMajor(CopyOfColorMapMajor);
            Program.SetColorMapMinor(CopyOfColorMapMinor);
            return (majorIndex * CopyOfColorMapMinor.Length) + (minorIndex + 1);
        }
    }
}
