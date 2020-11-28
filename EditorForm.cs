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
        Point point;
        bool mouseDown;
        IFigure figure;
        public EditorForm()
        {
            InitializeComponent();
            mainBitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            tmpBitmap = (Bitmap)mainBitmap.Clone();
            pen = new Pen(Color.Black, 10);
            pictureBox.Image = mainBitmap;
            mouseDown = false;
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            pointList = new PointList();
            point = e.Location;
            pointList.AddPoint(point);
            pointList.AddPoint(e.Location);
            mouseDown = true;
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                pointList[1] = e.Location;
                tmpBitmap = (Bitmap)mainBitmap.Clone();
                graphics = Graphics.FromImage(tmpBitmap);
                figure.DrawFigure(pen, graphics, pointList);
                pictureBox.Image = tmpBitmap;
                GC.Collect();
            }
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            pointList = new PointList();
            mainBitmap = tmpBitmap;
            mouseDown = false;

        }

        //private void Hand_Click(object sender, EventArgs e)
        //{
        //    //chooseButton = 0;
        //}

        //private void Brush_Click(object sender, EventArgs e)
        //{
        //    //figure = new BrushFigure();
        //}

        //private void CreateLine_Click(object sender, EventArgs e)
        //{
        //    pictureBox.Cursor = Cursors.Cross;
        //    figure = new CurveFigure();
        //    pointList = new PointList();
        //}

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
            
            textBox1.Visible = true;
            textBox2.Visible = true;
            figure = new PolygonFigure(Convert.ToInt32(textBox2.Text));
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
