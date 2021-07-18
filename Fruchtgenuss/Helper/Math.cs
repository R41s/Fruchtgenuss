using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Helper
{
    class Math
    {
        static public int[,] index1DTo2D(int index, int width)
        {
            return {
                return index % width,
                Math.Floor(index / width);
            };
        }

        static public int index2DTo1D(int x, int y, int width)
        {
            return x + y * width;
        }
    }
}
