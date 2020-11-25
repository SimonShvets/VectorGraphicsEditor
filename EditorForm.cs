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

                //switch (chooseButton)
                //{
                //    case (0):
                //        break;
                //    case (1):
                //        graphics.DrawLine(pen, point, e.Location);
                //        pictureBox1.Image = mainBitmap;
                //        point = e.Location;
                //        break;
                //    case (2):
                //        break;
                //    case (3):
                //        graphics.Clear(Color.White);
                //        PointF[] points = new PointF[4] { point, new Point(point.X, e.Y), e.Location, new Point(e.X, point.Y) };
                //        graphics.DrawPolygon(pen, points);
                //        pictureBox1.Image = mainBitmap;
                //        break;
                //    case (5):
                //        graphics.Clear(Color.White);
                //        Rectangle rect = new Rectangle(x, y, e.X-x, e.Y-y);
                //        graphics.DrawEllipse(pen, rect);
                ////        pictureBox1.Image = mainBitmap;
                ////        break;
                //}
                tmpBitmap = new Bitmap(mainBitmap);
                graphics = Graphics.FromImage(tmpBitmap);
                pictureBox1.Image = figure.DrawFigure(tmpBitmap, g);
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void hand_Click(object sender, EventArgs e)
        {
            chooseButton = 0;
        }
        private void brush_Click(object sender, EventArgs e)
        {
            chooseButton = 1;
        }
        private void createLine_Click(object sender, EventArgs e)
        {
            pictureBox1.Cursor = Cursors.Cross;
            figure = new CurveFigure();
            chooseButton = 2;
        }

        private void rectangle_Click(object sender, EventArgs e)
        {
            
            chooseButton = 3;
        }

        private void cycle_Click(object sender, EventArgs e)
        {
            chooseButton = 4;
        }

        private void elipse_Click(object sender, EventArgs e)
        {
            chooseButton = 5;
        }

        private void triangle_Click(object sender, EventArgs e)
        {
            chooseButton = 6;
        }

        private void straightTriangle_Click(object sender, EventArgs e)
        {
            chooseButton = 7;
        }

        private void isoscelesTriangle_Click(object sender, EventArgs e)
        {
            chooseButton = 8;
        }

        private void wrongPolygon_Click(object sender, EventArgs e)
        {
            chooseButton = 9;
        }

        private void Polygon_Click(object sender, EventArgs e)
        {
            chooseButton = 10;
        }


    }
}
