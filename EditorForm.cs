using System;
using System.Drawing;
using System.Drawing.Drawing2D;
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
        bool mouseUp;
        IFigure figure;
        public EditorForm()
        {
            InitializeComponent();
            mainBitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            tmpBitmap = (Bitmap)mainBitmap.Clone();
            pictureBox.Image = mainBitmap;
            pointList = new PointList();
            pen = new Pen(Color.Black,10);
            pen.StartCap = LineCap.Round;
            pen.EndCap = LineCap.Round;
            mouseDown = false;
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            pointList.AddPoint(e.Location);
            if (pointList.Length != 1)
            {
                tmpBitmap = (Bitmap)mainBitmap.Clone();
                graphics = Graphics.FromImage(tmpBitmap);
                figure.DrawFigure(pen, graphics, pointList);
                pictureBox.Image = tmpBitmap;
                GC.Collect();
            }
            mainBitmap = tmpBitmap;
            mouseDown = true;
        }
        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseUp)
            {
                tmpBitmap = (Bitmap)mainBitmap.Clone();
                graphics = Graphics.FromImage(tmpBitmap);
                graphics.DrawLine(pen, pointList.ConvertToPointF()[pointList.Length - 1], e.Location);
                pictureBox.Image = tmpBitmap;
                GC.Collect();
            }
            
        }
        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
            mouseUp = true;
        }
        private void Hand_Click(object sender, EventArgs e)
        {

        }

        private void Brush_Click(object sender, EventArgs e)
        {
            //figure = new BrushFigure();
        }

        private void Curve_Click(object sender, EventArgs e)
        {
            pictureBox.Cursor = Cursors.Cross;
            figure = new CurveFigure();
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
