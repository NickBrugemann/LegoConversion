using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixelCounter
{
    public partial class MainForm : Form
    {
        private void ClearControls()
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            pbImage.Image = null;
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ClearControls();
                int counter = -1;
                int margin = 64;
                int showAmount = 20;
                Bitmap bmp = new Bitmap(ofd.FileName);
                pbImage.Image = bmp;
                lblWidth.Text = bmp.Width.ToString();
                lblHeight.Text = bmp.Height.ToString();
                //ImageInfo imageInfo = ImageHelper.GetColors(bmp, rbSkipTransparentPixels.Checked);
                ImageInfo imageInfo = ImageHelper.GetColors(bmp);

                foreach (KeyValuePair<Color, int> kvp in imageInfo.colors)
                {
                    counter++;

                    PictureBox pb = new PictureBox();
                    pb.BorderStyle = BorderStyle.FixedSingle;
                    pb.BackColor = kvp.Key;
                    pb.Width = 32;
                    pb.Height = 32;
                    pb.Location = new Point(20 + (counter * margin), 20);
                    panel1.Controls.Add(pb);

                    Label l = new Label();
                    l.Text = kvp.Value.ToString();
                    l.AutoSize = true;
                    l.Location = new Point(20 + (counter * margin), 55);
                    panel1.Controls.Add(l);

                    l = new Label();
                    l.Text = "2x2:"+"NaN";
                    l.AutoSize = true;
                    l.Location = new Point(20 + (counter * margin), 85);
                    panel1.Controls.Add(l);
                }

                int counter2 = -1;
                foreach (KeyValuePair<string, int> kvp in imageInfo.bricks)
                {
                    counter2++;
                    Color color = Color.FromArgb(Int32.Parse(kvp.Key.Substring(0, kvp.Key.Length - 4)));
                    PictureBox pb = new PictureBox();
                    pb.BorderStyle = BorderStyle.FixedSingle;
                    pb.BackColor = color;
                    pb.Width = 32;
                    pb.Height = 32;
                    pb.Location = new Point(20, 20 + (counter2 * margin));
                    panel2.Controls.Add(pb);

                    Label l = new Label();
                    l.Font = new Font(FontFamily.GenericSansSerif, 16);
                    string brickInformation = kvp.Key.Substring(kvp.Key.Length - 3);
                    l.Text = kvp.Value.ToString();// + " - " + brickInformation;
                    //l.Text = "Length:" + brickInformation + ", Row:" + bi.row;
                    l.AutoSize = true;
                    l.Location = new Point(60, 30 + (counter2 * margin));
                    panel2.Controls.Add(l);

                    pb = new PictureBox();
                    Bitmap img = brickInformation == "1x4" ? PixelCounter.Properties.Resources._1x4 : PixelCounter.Properties.Resources._2x4;
                    pb.Image = img;
                    pb.Size = img.Size;
                    pb.Location = new Point(130, 28 + (counter2 * margin));
                    panel2.Controls.Add(pb);

                    var sortedMatches = LegoColorBase.CalculateSimilarColors(color);
                    int c = -1;
                    foreach (KeyValuePair<LegoColor, double> match in sortedMatches)
                    {
                        if (c == showAmount-1)
                        {
                            break;
                        }

                        c++;
                        PictureBox pbMatch = new PictureBox();
                        pbMatch.MouseHover += delegate {
                            ToolTip tt = new ToolTip();
                            tt.SetToolTip(pbMatch, match.Key.Name);
                        };
                        pbMatch.BorderStyle = BorderStyle.FixedSingle;
                        pbMatch.BackColor = match.Key.ColorValue;
                        pbMatch.Width = 32;
                        pbMatch.Height = 32;
                        pbMatch.Location = new Point(180 + (c* 32), 20 + (counter2 * margin));
                        panel2.Controls.Add(pbMatch);
                        pbMatch.Click += delegate
                        {
                            BrickBrowserHelper.BrowseUrl(match.Key, brickInformation);
                        };


                        Label lMatch = new Label();
                        lMatch.Text = Math.Round(100 - match.Value, 2) + "%";
                        lMatch.Font = new Font(lMatch.Font.Name, 7F);
                        lMatch.AutoSize = true;
                        lMatch.Location = new Point(180 + (c * 32), 50 + (counter2 * margin));
                        panel2.Controls.Add(lMatch);
                    }
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
