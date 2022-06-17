using WinFormsApp1.Shapes;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Line line;
        Ellipse ellipse;
        Triangle triangle;
        RectangleDraw rectangle;
        public Form1()
        {
            InitializeComponent();
            line = new Line(panel1.CreateGraphics());
            ellipse = new Ellipse(panel1.CreateGraphics());
            triangle = new Triangle(panel1.CreateGraphics());   
            rectangle = new RectangleDraw(panel1.CreateGraphics());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            line.SetColorAndWidth("red", 20);
            line.Draw();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ellipse.SetColorAndWidth("sdsd", 7);
            ellipse.Draw(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            triangle.SetColorAndWidth("green", 8);
            triangle.Draw();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            rectangle.SetColorAndWidth("sdd", 9);
            rectangle.Draw();   
        }
    }
}