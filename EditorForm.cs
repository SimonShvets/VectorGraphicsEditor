using System;
using System.Collections.Generic;
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
        PointF point;
        bool mouseDown;
        IFigures figure;
        public EditorForm()
        {
            InitializeComponent();
        }

        private void EditorForm_Load(object sender, EventArgs e)
        {
            mainBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(mainBitmap);
            pen = new Pen(Color.Black, 2);
            pictureBox1.Image = mainBitmap;
            mouseDown = false;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            point = e.Location;
            pointList.AddPoint(e.Location);
            //point = e.Location;
            //listOfPoints.Add(point);
            //points = new Point[listOfPoints.Count];
            //int k = 0;
            //foreach (Point i in listOfPoints)
            //{
            //    points[k] = i;
            //    k++;
            //}
            if (pointList.Lenght != 1)
            {
                tmpBitmap = (Bitmap)mainBitmap.Clone();
                graphics = Graphics.FromImage(tmpBitmap);
                pictureBox1.Image = figure.DrawFigure(pen, graphics, tmpBitmap, pointList.ConvertToPointF());
                GC.Collect();
            }
            mouseDown = true;

        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            //if (mouseDown)
            //{
            //     = e.Location;
            //    listOfPoints.Add(point);
            //    points = new Point[listOfPoints.Count];
            //    int k = 0;
            //    foreach (Point i in listOfPoints)
            //    {
            //        points[k] = i;
            //        k++;
            //    }
            //    if (listOfPoints.Count != 1)
            //    {
            //        tmpBitmap = (Bitmap)mainBitmap.Clone();
            //        graphics = Graphics.FromImage(tmpBitmap);
            //        pictureBox1.Image = figure.DrawFigure(pen, graphics, tmpBitmap, points);
            //        GC.Collect();
            //    }
            //}

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
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
            pictureBox1.Cursor = Cursors.Cross;
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
