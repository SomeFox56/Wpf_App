using WinFormsApp1.Shapes;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Line line;      
        public Form1()
        {
            InitializeComponent();
            line = new Line(panel1.CreateGraphics());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            line.SetColorAndWidth("red", 20);
            line.Draw();
        }
    }
}