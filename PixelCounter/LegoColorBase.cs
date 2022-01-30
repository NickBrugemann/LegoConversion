using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelCounter
{
    static class LegoColorBase
    {
        static LegoColorBase()
        {
            //AllColors.Add(new LegoColor("name", "colorfamily", "hex", Color.FromArgb(,,)));
            AllColors = new List<LegoColor>();
            #region Black
            AllColors.Add(new LegoColor("Black", "Black", "151515", Color.FromArgb(19, 19, 19)));
            AllColors.Add(new LegoColor("Titanium Metallic", "Black", "42423E", Color.FromArgb(66,66,62)));
            #endregion

            #region Grey
            AllColors.Add(new LegoColor("Dark Stone Grey", "Grey", "646765", Color.FromArgb(100,103,101)));
            AllColors.Add(new LegoColor("Medium Stone Grey", "Grey", "A0A19F", Color.FromArgb(160, 161, 159)));
            #endregion

            #region Lilac
            AllColors.Add(new LegoColor("Medium Lavender", "Lilac", "9675B4", Color.FromArgb(150, 117, 180)));
            AllColors.Add(new LegoColor("Lavender", "Lilac", "BCA6D0", Color.FromArgb(188, 166, 208)));
            AllColors.Add(new LegoColor("Medium Lilac", "Lilac", "4C2F92", Color.FromArgb(76, 47, 146)));
            AllColors.Add(new LegoColor("Transparent Bright Violet", "Lilac", "7672B5", Color.FromArgb(118, 114, 181)));
            #endregion

            #region Blue
            AllColors.Add(new LegoColor("Earth Blue", "Blue", "00395E", Color.FromArgb(0,57,94)));
            AllColors.Add(new LegoColor("Bright Blue", "Blue", "006CB7", Color.FromArgb(0,108,183)));
            AllColors.Add(new LegoColor("Light Royal Blue", "Blue", "78BFEA", Color.FromArgb(120,191,234)));
            AllColors.Add(new LegoColor("Transparent Blue", "Blue", "0099D4", Color.FromArgb(0,153,212)));
            AllColors.Add(new LegoColor("Medium Blue", "Blue", "489ECE", Color.FromArgb(72,158,206)));
            AllColors.Add(new LegoColor("Transparent Fluorescent Blue", "Blue", "84C8E2", Color.FromArgb(132,200,226)));
            AllColors.Add(new LegoColor("Sand Blue", "Blue", "678297", Color.FromArgb(103,130,151)));
            AllColors.Add(new LegoColor("Dark Azur", "Blue", "00A3DA", Color.FromArgb(0,163,218)));
            AllColors.Add(new LegoColor("Medium Azur", "Blue", "00BED3", Color.FromArgb(0,190,211)));
            AllColors.Add(new LegoColor("Bright Bluish Green", "Blue", "189E9F", Color.FromArgb(24,158,159)));
            AllColors.Add(new LegoColor("Transparent Light Blue", "Blue", "5BC1BF", Color.FromArgb(91,193,191)));
            AllColors.Add(new LegoColor("Aqua", "Blue", "C1E4DA", Color.FromArgb(193,228,218)));
            #endregion

            #region Dark Green
            AllColors.Add(new LegoColor("Sand Green", "Dark Green", "6F947A", Color.FromArgb(111,148,122)));
            AllColors.Add(new LegoColor("Earth Green", "Dark Green", "004A2D", Color.FromArgb(0,74,45)));
            AllColors.Add(new LegoColor("Dark Green", "Dark Green", "009247", Color.FromArgb(0,146,71)));
            AllColors.Add(new LegoColor("Bright Green", "Dark Green", "00AF4D", Color.FromArgb(0,175,77)));
            AllColors.Add(new LegoColor("Bright Yellowish Green", "Dark Green", "9ACA3A", Color.FromArgb(154,202,60)));
            AllColors.Add(new LegoColor("Spring Yellowish Green", "Dark Green", "CCE197", Color.FromArgb(204,225,151)));
            AllColors.Add(new LegoColor("Olive Green", "Dark Green", "828353", Color.FromArgb(130,131,83)));
            #endregion

            #region Green
            AllColors.Add(new LegoColor("Transparent Green", "Green", "00A8AF", Color.FromArgb(0,168,79)));
            AllColors.Add(new LegoColor("Transparent Bright Green", "Green", "96C753", Color.FromArgb(150,199,83)));
            AllColors.Add(new LegoColor("Transparent Fluorescent Green", "Green", "E3E029", Color.FromArgb(227, 224, 41)));
            #endregion

            #region Yellow
            AllColors.Add(new LegoColor("Flame Yellow Orange", "Yellow", "FBAB18", Color.FromArgb(251,171,24)));
            AllColors.Add(new LegoColor("Bright Yellow", "Yellow", "FFCD03", Color.FromArgb(255,205,3)));
            AllColors.Add(new LegoColor("Transparent Yellow", "Yellow", "F7D112", Color.FromArgb(247,209,18)));
            AllColors.Add(new LegoColor("Cool Yellow", "Yellow", "FFF579", Color.FromArgb(255,245,121)));
            #endregion

            #region Bright Orange
            AllColors.Add(new LegoColor("Vibrant Coral", "Bright Orange", "F96C62", Color.FromArgb(249,108,98)));
            AllColors.Add(new LegoColor("Transparent Fluorescent Reddish Orange", "Bright Orange", "F05729", Color.FromArgb(240,87,41)));
            AllColors.Add(new LegoColor("Bright Orange", "Bright Orange", "F57D20", Color.FromArgb(245,125,48)));
            AllColors.Add(new LegoColor("Transparent Bright Orange", "Bright Orange", "F58830", Color.FromArgb(245,136,48)));
            #endregion

            #region Reddish Brown
            AllColors.Add(new LegoColor("Dark Brown", "Reddish Brown", "3B180D", Color.FromArgb(59,24,13)));
            AllColors.Add(new LegoColor("Reddish Brown", "Reddish Brown", "692E14", Color.FromArgb(105,46,20)));
            AllColors.Add(new LegoColor("Dark Orange", "Reddish Brown", "A65322", Color.FromArgb(166,83,34)));
            AllColors.Add(new LegoColor("Medium Nougat", "Reddish Brown", "AF7446", Color.FromArgb(175,116,70)));
            AllColors.Add(new LegoColor("Nougat", "Reddish Brown", "DE8B5F", Color.FromArgb(222,139,95)));
            AllColors.Add(new LegoColor("Light Nougat", "Reddish Brown", "FCC39E", Color.FromArgb(252,195,158)));
            AllColors.Add(new LegoColor("Sand Yellow", "Reddish Brown", "947E5F", Color.FromArgb(148,126,95)));
            AllColors.Add(new LegoColor("Transparent Brown", "Reddish Brown", "97896C", Color.FromArgb(151,137,108)));
            AllColors.Add(new LegoColor("Brick Yellow", "Reddish Brown", "DDC48E", Color.FromArgb(221,196,142)));
            #endregion

            #region Red
            AllColors.Add(new LegoColor("New Dark Red", "Red", "7F131B", Color.FromArgb(127,19,27)));
            AllColors.Add(new LegoColor("Bright Red", "Red", "DD1A21", Color.FromArgb(221,16,33)));
            AllColors.Add(new LegoColor("Transparent Red", "Red", "E51E26", Color.FromArgb(229,30,38)));
            #endregion

            #region Purple
            AllColors.Add(new LegoColor("Bright Reddish Violet", "Purple", "B51C7D", Color.FromArgb(181,28,125)));
            AllColors.Add(new LegoColor("Transparent Medium Reddish Violet", "Purple", "E8509C", Color.FromArgb(232,80,156)));
            AllColors.Add(new LegoColor("Bright Purple", "Purple", "E95DA2", Color.FromArgb(233,93,162)));
            AllColors.Add(new LegoColor("Light Purple", "Purple", "F6ADCD", Color.FromArgb(246,173,205)));
            #endregion

            #region White
            AllColors.Add(new LegoColor("White", "White", "F4F4F4", Color.FromArgb(244, 244, 244)));
            #endregion

            #region Silver

            #endregion

            #region Gold

            #endregion
        }
        private static List<LegoColor> AllColors;

        public static List<LegoColor> GetAllColors()
        {
            return AllColors;
        }

        public static IOrderedEnumerable<KeyValuePair<LegoColor, double>> CalculateSimilarColors(Color similarToThisColor)
        {
            Dictionary<LegoColor, double> results = new Dictionary<LegoColor, double>();

            foreach (LegoColor legoColor in LegoColorBase.GetAllColors())
            {
                double[] colorRgb = { legoColor.ColorValue.R, legoColor.ColorValue.G, legoColor.ColorValue.B };
                double _deltaE = ColorHelper.deltaE(similarToThisColor, legoColor.ColorValue);

                results.Add(legoColor, _deltaE);
            }

            return results.OrderBy(d => d.Value);
        }
    }
}
