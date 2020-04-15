﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel;

namespace WindowsFormsApp1
{
    abstract class Filters
    {
        protected abstract Color calculateNewPixelColor(Bitmap sourceImage, int x, int y);
        
        public Bitmap processImage(Bitmap sourceImage, BackgroundWorker worker) // BackgroundWorker worker
        {
            Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);
            for (int i = 0; i < sourceImage.Width; i++)
            {
                for (int j = 0; j < sourceImage.Height; j++)
                {
                    resultImage.SetPixel(i, j, calculateNewPixelColor(sourceImage, i, j));
                }
               worker.ReportProgress((int)((float)i / resultImage.Width * 100));
                if (worker.CancellationPending)
                    return null;             
            }
            return resultImage;
           
        }

        

        public int  Clamp(int value, int min, int max)
        {
            if (value < min)
               return min;

            if (value > max)
               return max;
            return value;
    
        }

        internal Bitmap processImage(Bitmap image)
        {
            return null;
        }
    }

        

}
