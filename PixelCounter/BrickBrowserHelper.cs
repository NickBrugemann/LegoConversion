using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelCounter
{
    internal class BrickBrowserHelper
    {
        private static String BrowserPath = "firefox.exe";

        public class BrickSize
        {
            public const string
            _2x4 = "Brick%202%20x%204%20-%203001",
            _2x2 = "Brick%202%20x%202%20-%203003";
        }
        public static void BrowseUrl(LegoColor color, String brickSize)
        {
            String Url = "https://brickscout.com/nl/product-search?itemType=Part&name=";
            System.Diagnostics.Process.Start(BrowserPath, Url + UrlBrickSize(brickSize) + "&color=" + UrlColor(color));
        }

        private static String UrlColor(LegoColor color)
        {
            return color.Name.Replace(" ", "%20");
        }

        private static String UrlBrickSize(String brickSize)
        {
            switch (brickSize)
            {
                case "1x4":
                    return "Brick%202%20x%202%20-%203003";
                case "2x4":
                    return "Brick%202%20x%204%20-%203001";
                default:
                    return "Tile%201%20x%201%20with%20Groove%20-%203070b";
            }
        }
    }
}
