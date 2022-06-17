using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Shapes
{
    class Line
    {

        public Line(int x1, int x2, int y1, int y2)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.y1 = y1;
            this.y2 = y2;
        }

        public Line(Graphics graphics)
        {
            this.x1 = 5;
            this.x2 = 300;
            this.y1 = 5;
            this.y2 = 300;
            gr = graphics;


        }

        public virtual void SetColorAndWidth(string color, float width)
        {
            switch (color)
            {
                case "red":
                    pencil = new Pen(Color.Red, width);
                    break;
                case "green":
                    pencil = new Pen(Color.Green, width);
                    break;
                case "purple":
                    pencil = new Pen(Color.Purple, width);
                    break;
                default:
                    pencil = new Pen(Color.Black, width);
                    break;
            }
        }

        public Pen pencil { get; set; }
        public int x1 { get; set; }
        public int x2 { get; set; }
        public int y1 { get; set; }
        public int y2 { get; set; }
        public Graphics gr { get; set; }

        public virtual void Draw()
        {
            gr.DrawLine(pencil, x1, y1, x2, y2);
        }
    }
}
