using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Shapes
{
    internal class Triangle : Line
    {
        public Triangle(Graphics graphics) : base(graphics)
        {
        }

        public override void Draw()
        {
            Point[] points = new Point[4]
            {
                new Point(60, 300),
                new Point(400, 400),
                new Point(300, 60),
                new Point(60,300)
            };
            gr.DrawLines(pencil, points);
        }
    }
}
