using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Shapes
{
    internal class RectangleDraw : Line
    {
        public RectangleDraw(Graphics graphics) : base(graphics)
        {
        }

        public override void Draw()
        {
            gr.DrawRectangle(pencil, x1, y1, x2, y2);
        }
    }
}
