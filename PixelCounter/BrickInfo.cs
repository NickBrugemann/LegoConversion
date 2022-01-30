using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelCounter
{
    public class BrickInfo
    {
        public Color color;
        public int row;
        public int length;

        public BrickInfo(Color color, int row, int length)
        {
            this.color = color;
            this.row = row;
            this.length = length;
        }
    }
}
