using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelCounter
{
    public static class BrickHelper
    {
        private class Brick
        {

        }

        /// <summary>
        /// Calculates lego bricks from lines of pixels. 5 adjacent red pixels make 2 2 2x4 and 1 1x4 for example.
        /// </summary>
        public static Dictionary<string, int>CalculateBricks(List<BrickInfo> bricks)
        {
            Dictionary<string, int> _temp = new Dictionary<string, int>();
            foreach (BrickInfo brick in bricks)
            {
                int tempLength = brick.length;
                while (tempLength != 0)
                {
                    int x;
                    string colorString = brick.color.ToArgb().ToString();
                    if (tempLength == 1)
                    {
                        tempLength--;
                        // 1x4
                        if (_temp.TryGetValue(colorString+",1x4",out x))
                        {
                            _temp[colorString+",1x4"]++;
                        }
                        else
                        {
                            _temp.Add(colorString + ",1x4", 1);
                        }
                    }
                    else
                    {
                        tempLength -= 2;
                        // 2x4
                        if (_temp.TryGetValue(colorString + ",2x4", out x))
                        {
                            _temp[colorString + ",2x4"]++;
                        }
                        else
                        {
                            _temp.Add(colorString + ",2x4", 1);
                        }
                    }
                }
                //string brickInfo = brick.color + "," +brick.
            }

            return _temp;
        }
    }
}
