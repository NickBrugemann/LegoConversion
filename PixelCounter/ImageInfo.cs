using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelCounter
{
    public class ImageInfo
    {
        public Dictionary<Color, int> colors;
        public Dictionary<string, int> bricks;

        public ImageInfo(Dictionary<Color, int> colors, Dictionary<string, int> bricks)
        {
            this.colors = colors;
            this.bricks = bricks;
        }
    }
}
