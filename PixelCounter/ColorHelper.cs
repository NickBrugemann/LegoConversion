using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelCounter
{
    /// <summary>
    /// Class that contains methods regarding colors.
    /// </summary>
    class ColorHelper
    {
        /// <summary>
        /// Calculates the delta E (1994 version) between two colors.
        /// The the closer to 100, the more opposite the two colors are (to the human eye).
        /// </summary>
        /// <param name="rgbA"></param>
        /// <param name="rgbB"></param>
        /// <returns></returns>
        public static double deltaE(double[] rgbA, double[] rgbB)
        {
            var labA = rgb2lab(rgbA);
            var labB = rgb2lab(rgbB);
            var deltaL = labA[0] - labB[0];
            var deltaA = labA[1] - labB[1];
            var deltaB = labA[2] - labB[2];
            var c1 = Math.Sqrt(labA[1] * labA[1] + labA[2] * labA[2]);
            var c2 = Math.Sqrt(labB[1] * labB[1] + labB[2] * labB[2]);
            var deltaC = c1 - c2;
            var deltaH = deltaA * deltaA + deltaB * deltaB - deltaC * deltaC;
            deltaH = deltaH < 0 ? 0 : Math.Sqrt(deltaH);
            var sc = 1.0 + 0.045 * c1;
            var sh = 1.0 + 0.015 * c1;
            var deltaLKlsl = deltaL / (1.0);
            var deltaCkcsc = deltaC / (sc);
            var deltaHkhsh = deltaH / (sh);
            var i = deltaLKlsl * deltaLKlsl + deltaCkcsc * deltaCkcsc + deltaHkhsh * deltaHkhsh;
            return i < 0 ? 0 : Math.Sqrt(i);
        }

        /// <summary>
        /// Calculates the delta E (1994 version) between two colors.
        /// The the closer to 100, the more opposite the two colors are (to the human eye).
        /// </summary>
        /// <param name="rgbA"></param>
        /// <param name="rgbB"></param>
        /// <returns></returns>
        public static double deltaE(Color colorA, Color colorB)
        {
            double[] rgbA = { colorA.R, colorA.G, colorA.B };
            double[] rgbB = { colorB.R, colorB.G, colorB.B };
            return deltaE(rgbA, rgbB);
        }

        private static double[] rgb2lab(double[] rgb)
        {
            double r = rgb[0] / 255, g = rgb[1] / 255, b = rgb[2] / 255, x, y, z;
            r = (r > 0.04045) ? Math.Pow((r + 0.055) / 1.055, 2.4) : r / 12.92;
            g = (g > 0.04045) ? Math.Pow((g + 0.055) / 1.055, 2.4) : g / 12.92;
            b = (b > 0.04045) ? Math.Pow((b + 0.055) / 1.055, 2.4) : b / 12.92;
            x = (r * 0.4124 + g * 0.3576 + b * 0.1805) / 0.95047;
            y = (r * 0.2126 + g * 0.7152 + b * 0.0722) / 1.00000;
            z = (r * 0.0193 + g * 0.1192 + b * 0.9505) / 1.08883;
            x = (x > 0.008856) ? Math.Pow(x, 1.0 / 3.0) : (7.787 * x) + 16.0 / 116.0;
            y = (y > 0.008856) ? Math.Pow(y, 1.0 / 3.0) : (7.787 * y) + 16.0 / 116.0;
            z = (z > 0.008856) ? Math.Pow(z, 1.0 / 3.0) : (7.787 * z) + 16.0 / 116.0;
            double[] values = { (116.0 * y) - 16.0, 500.0 * (x - y), 200.0 * (y - z) };
            return values;
        }
    }
}
