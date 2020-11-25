using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        List<Point> listOfPoints = new List<Point>();
        Bitmap tmpBitmap;
        Point point;
        bool mouseDown;
        int chooseButton;
        int x;
        int y;
        IFigures figure;
        Point[] g = new Point[2];

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
            figure = new CurveFigure();
            mouseDown = false;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            point = e.Location;
            listOfPoints.Add(point);
            Point[] g = new Point[listOfPoints.Count];
            int k = 0;
            foreach (Point i in listOfPoints)
            {
                g[k] = i;
                k++;
            }
            if (chooseButton == 2)
            {
                pictureBox1.Image = figure.DrawFigure(tmpBitmap, g);
            }
            mouseDown = true;

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                tmpBitmap = (Bitmap)mainBitmap.Clone();
                graphics = Graphics.FromImage(tmpBitmap);

                points = new PointF[] {point, e.Location};

                pictureBox1.Image = figure.DrawFigure(tmpBitmap, points);
                GC.Collect();

                //switch (chooseButton)
                //{
                //    //case (0):
                //    //    break;
                //    //case (1):
                //    //    graphics.DrawLine(pen, point, e.Location);
                //    //    pictureBox1.Image = mainBitmap;
                //    //    point = e.Location;
                //    //    break;
                //    //case (2):
                //    //    graphics.Clear(Color.White);
                //    //    graphics.DrawLine(pen, point, e.Location);
                //    //    pictureBox1.Image = mainBitmap;
                //    //    break;
                //    //case (3):
                //    //    graphics.Clear(Color.White);
                //    //    points = new PointF[4] { point, new Point(point.X, e.Y), e.Location, new Point(e.X, point.Y) };
                //    //    graphics.DrawPolygon(pen, points);
                //    //    pictureBox1.Image = mainBitmap;
                //    //    break;
                //    //case (5):
                //    //    graphics.Clear(Color.White);
                //    //    Rectangle rect = new Rectangle(x, y, e.X-x, e.Y-y);
                //    //    graphics.DrawEllipse(pen, rect);
                //    //    pictureBox1.Image = mainBitmap;
                //    //    break;
                //    //case (10):
                //    //    graphics.Clear(Color.White);
                //    //    int n = Convert.ToInt32(textBox2.Text);
                //    //    if ( n > 2)
                //    //    {
                //    //        points = new PointF[n];
                //    //        points[0] = new Point(x, e.Y);
                //    //        int a = 360 / n;
                //    //        int t;
                //    //        for (int i = 1; i < n; i++)
                //    //        {
                //    //            t = a * i;
                //    //            double rad = 3.14 / 180 * t;
                //    //            int x1 = (int)((x - (points[0].Y - y) * Math.Sin(rad)));
                //    //            int y1 = (int)((y + (points[0].Y - y) * Math.Cos(rad)));
                //    //            points[i] = new Point(x1, y1); 
                //    //        }
                //    //    }

                //        graphics.DrawPolygon(pen, points);
                //        pictureBox1.Image = mainBitmap;
                //        break;
                //}

            }

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void Hand_Click(object sender, EventArgs e)
        {
            chooseButton = 0;
        }

        private void Brush_Click(object sender, EventArgs e)
        {
            figure = new BrushFigire();
        }

        private void CreateLine_Click(object sender, EventArgs e)
        {
            pictureBox1.Cursor = Cursors.Cross;
            figure = new CurveFigure();
            chooseButton = 2;
        }

        private void Rectangle_Click(object sender, EventArgs e)
        {
            figure = new RectangleFigure();
        }

        private void Cycle_Click(object sender, EventArgs e)
        {
            figure = new CycleFigure();
        }

        private void Elipse_Click(object sender, EventArgs e)
        {
            figure = new ElipseFigure();
        }

        private void Triangle_Click(object sender, EventArgs e)
        {
            figure = new TriangleFigure();
        }

        private void StraightTriangle_Click(object sender, EventArgs e)
        {
            figure = new StraightTriangleFigure();
        }

        private void IsoscelesTriangle_Click(object sender, EventArgs e)
        {
            figure = new IsoscelesTriangleFigure();
        }

        private void WrongPolygon_Click(object sender, EventArgs e)
        {
            figure = new WrongPolygonFigure();
        }

        private void Polygon_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox2.Visible = true;
            figure = new PolygonFigure();
        }
    }
}
