using System;
using System.Drawing;
using System.Windows.Forms;
using VectorGraphicsEditor.Figures;

namespace VectorGraphicsEditor
{
    public partial class EditorForm : Form
    {
        Bitmap mainBitmap;
        Bitmap tmpBitmap;
        Graphics graphics;
        Pen pen;
        PointList pointList;
        bool mouseDown;
        IFigures figure;
        public EditorForm()
        {
            InitializeComponent();
            mainBitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            tmpBitmap = (Bitmap)mainBitmap.Clone();
            graphics = Graphics.FromImage(mainBitmap);
            pen = new Pen(Color.Black,10);
            pictureBox.Image = mainBitmap;
            mouseDown = false;
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            pointList.AddPoint(e.Location);
            mouseDown = true;
        }
        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            mainBitmap = tmpBitmap;
            mouseDown = false;
        }
        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                if(pointList.Lenght != 1) 
                { 
                tmpBitmap = (Bitmap)mainBitmap.Clone();
                graphics = Graphics.FromImage(tmpBitmap);
                figure.DrawFigure(pen, graphics, tmpBitmap, pointList);
                pictureBox.Image = tmpBitmap;
                GC.Collect();
                }
            }
        }
        private void Hand_Click(object sender, EventArgs e)
        {

        }

        private void Brush_Click(object sender, EventArgs e)
        {
            //figure = new BrushFigure();
        }

        private void CreateLine_Click(object sender, EventArgs e)
        {
            pictureBox.Cursor = Cursors.Cross;
            figure = new CurveFigure();
            pointList = new PointList();
        }

        private void Rectangle_Click(object sender, EventArgs e)
        {
            //figure = new RectangleFigure();
        }

        private void Cycle_Click(object sender, EventArgs e)
        {
            //figure = new CycleFigure();
        }

        private void Elipse_Click(object sender, EventArgs e)
        {
            //figure = new ElipseFigure();
        }

        private void Triangle_Click(object sender, EventArgs e)
        {
            //figure = new TriangleFigure();
        }

        private void StraightTriangle_Click(object sender, EventArgs e)
        {
            //figure = new StraightTriangleFigure();
        }

        private void IsoscelesTriangle_Click(object sender, EventArgs e)
        {
            //figure = new IsoscelesTriangleFigure();
        }

        private void WrongPolygon_Click(object sender, EventArgs e)
        {
            //figure = new WrongPolygonFigure();
        }

        private void Polygon_Click(object sender, EventArgs e)
        {
            //textBox1.Visible = true;
            //textBox2.Visible = true;
            //figure = new PolygonFigure();
        }

   
    }
}
