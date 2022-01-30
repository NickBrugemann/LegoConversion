using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelCounter
{
    public static class ImageHelper
    {
        /*
         * per rij (y)
         * comboPixel = null;
         * combo = 1
         * -----
         * loop over iedere pixel
         * voor iedere currentPixel, check of gelijk is aan combopixel. als leeg comboPixel = currentPixel, continue
         * zo ja, combo++
         * zo nee, als comboPixel niet leeg was, brickinfo met comboPixel en combo aantal. comboPixel = currentPixel. combo = 1
         * als laatste pixel van rij: brickinfo met comboPixel en combo aantal
         */

        public static ImageInfo GetColors(Bitmap image)
        {
            /*
             * per rij (y)
             * comboPixel = null;
             * combo = 1
             * -----
             * loop over iedere pixel
             * voor iedere currentPixel, check of gelijk is aan combopixel. als leeg comboPixel = currentPixel, continue
             * zo ja, combo++
             * zo nee, als comboPixel niet leeg was, brickinfo met comboPixel en combo aantal. comboPixel = currentPixel. combo = 1
             * als laatste pixel van rij: brickinfo met comboPixel en combo aantal
             */
            Dictionary<Color, int> colors = new Dictionary<Color, int>();
            List<BrickInfo> bricks = new List<BrickInfo>();
            for (int y = 0; y < image.Height; y++)
            {
                Color comboPixel = Color.Lime;
                int combo = 1;
                for (int x = 0; x < image.Width+1; x++)
                {                   
                    if (x == image.Width)
                    {
                        BrickInfo b = new BrickInfo(comboPixel, y, combo);
                        bricks.Add(b);
                        continue;
                    }

                    Color currentPixel = image.GetPixel(x, y);
                    //if (currentPixel.A == 0) { continue; }

                    int _temp;
                    #region counting 1x1 colors
                    if (colors.TryGetValue(currentPixel, out _temp)){
                        colors[currentPixel]++;
                    }
                    else
                    {
                        colors.Add(currentPixel, 1);
                    }
                    #endregion
                    if (comboPixel == Color.Lime) { comboPixel = currentPixel; continue; }
                    if (currentPixel == comboPixel)
                    {
                        combo++;
                    }
                    else
                    {
                        BrickInfo bi = new BrickInfo(comboPixel, y, combo);
                        bricks.Add(bi);
                        comboPixel = currentPixel;
                        combo = 1;
                    }
                }
            }

            return new ImageInfo(colors, BrickHelper.CalculateBricks(bricks));
        }
    }
}
