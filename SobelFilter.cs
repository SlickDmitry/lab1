using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel;

namespace WindowsFormsApp1
{
    class SobelFilter : MatrixFilter
    {
        public SobelFilter()
        {

            kernel = new float[3, 3];
            kernel[0, 0] = -1.0f; kernel[0, 1] = 0.0f; kernel[0, 2] = 1.0f;
            kernel[1, 0] = -2.0f; kernel[1, 1] = 0.0f; kernel[1, 2] = 2.0f;
            kernel[2, 0] = -1.0f; kernel[2, 1] = 0.0f; kernel[2, 2] = 1.0f;

            kernel = new float[3, 3];
            kernel[0, 0] = -1.0f; kernel[0, 1] = -2.0f; kernel[0, 2] = -1.0f;
            kernel[1, 0] = 0.0f; kernel[1, 1] = 0.0f; kernel[1, 2] = 0.0f;
            kernel[2, 0] = 1.0f; kernel[2, 1] = 2.0f; kernel[2, 2] = 1.0f; 
        }
    }
}