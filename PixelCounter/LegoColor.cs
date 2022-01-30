using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelCounter
{
    class LegoColor
    {
        public string Name;
        public string ColorFamily;
        public string Hex;
        public Color ColorValue;

        public LegoColor(string name, string colorFamily, string hex, Color colorValue)
        {
            this.Name = name;
            this.ColorFamily = colorFamily;
            this.Hex = hex;
            this.ColorValue = colorValue;
        }
    }
}
