using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    class MedianFilter:MatrixFilter
    {

        public MedianFilter(Bitmap sourceImage)
        {
            int rad = 3, Threshold = 30;
            double R, G, B;
            int Red, Green, Blue, count_red, count_green, count_blue;
            int width = sourceImage.Width;
            int height = sourceImage.Height;
            Bitmap res = new Bitmap(sourceImage);

            for (int i = rad; i < width - rad; ++i)
            {
                for (int j = rad; j < height - rad; ++j)
                {
                    Color c = sourceImage.GetPixel(i, j);

                    Red = Green = Blue = 0;
                    count_red = count_green = count_blue = 0;

                    for (int l = i - rad; l <= i + rad; l++)
                    {
                        for (int k = j - rad; k <= j + rad; k++)
                        {
                            Color tmp = sourceImage.GetPixel(l, k);

                            if (Math.Abs(tmp.R - c.R) < Threshold)
                            {
                                Red += tmp.R;
                                count_red++;
                            }

                            if (Math.Abs(tmp.G - c.G) < Threshold)
                            {
                                Green += tmp.G;
                                count_green++;
                            }

                            if (Math.Abs(tmp.B - c.B) < Threshold)
                            {
                                Blue += tmp.B;
                                count_blue++;
                            }
                        }
                    }

                    R = (double)Red / (double)count_red;
                    G = (double)Green / (double)count_green;
                    B = (double)Blue / (double)count_blue;

                    sourceImage.SetPixel(i, j, Color.FromArgb((int)R, (int)G, (int)B));
                }
            }

        }

    }
}
