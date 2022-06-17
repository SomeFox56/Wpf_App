using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Shapes
{
    internal class Ellipse : Line //круг
    {
        public Ellipse(Graphics graphics) : base(graphics)
        {
        }

        public override void Draw()
        {
            gr.DrawEllipse(pencil, x1, y1, x2, y2);
        }
    }
}
