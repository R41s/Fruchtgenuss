using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Fruchtgenuss
{
    class Box : Button
    {
       
        public Box(int left, int top)
        {
            this.Height = 55;
            this.Width = 55;
            this.Left = left;
            this.Top = top;
          
        }

        
    }
}
