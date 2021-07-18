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
    class Indicies
    {
        static public Tuple<int, int> index1DTo2D(int index, int width)
        {
            return Tuple.Create(
                index % width,
                (int)Math.Floor((double)index / (double)width)
            );
        }

        static public int index2DTo1D(int x, int y, int width)
        {
            return x + y * width;
        }
    }
}
