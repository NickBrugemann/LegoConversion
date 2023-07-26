using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
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

        public LegoColor(String name, String colorFamily, string hex)
        {
            this.Name = name;
            this.ColorFamily = colorFamily;
            this.Hex = hex;
            this.ColorValue = HexToColor(hex);
        }

        private Color HexToColor(String hex)
        {
            int red = 0;
            int green = 0;
            int blue = 0;

            if (hex.Length == 6)
            {
                //#RRGGBB
                red = int.Parse(hex.Substring(0, 2), NumberStyles.AllowHexSpecifier);
                green = int.Parse(hex.Substring(2, 2), NumberStyles.AllowHexSpecifier);
                blue = int.Parse(hex.Substring(4, 2), NumberStyles.AllowHexSpecifier);
            }
            else if (hex.Length == 3)
            {
                //#RGB
                red = int.Parse(hex[0].ToString() + hex[0].ToString(), NumberStyles.AllowHexSpecifier);
                green = int.Parse(hex[1].ToString() + hex[1].ToString(), NumberStyles.AllowHexSpecifier);
                blue = int.Parse(hex[2].ToString() + hex[2].ToString(), NumberStyles.AllowHexSpecifier);
            }

            return Color.FromArgb(red, green, blue);
        }
    }
}
