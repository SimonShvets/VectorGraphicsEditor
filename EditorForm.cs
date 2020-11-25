using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VectorGraphicsEditor
{
    public partial class EditorForm : Form
    {
        Bitmap mainBitmap;
        Graphics graphics;
        Pen pen;
        Pen pen1;
        Point point;
        bool mouseDown;
        int chooseButton;
        int x;
        int y;
        PointF[] points;


        public EditorForm()
        {
            InitializeComponent();
        }

        private void EditorForm_Load(object sender, EventArgs e)
        {
            mainBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(mainBitmap);
            pen = new Pen(Color.Black, 10);
            pen1 = new Pen(Color.Red, 5);
            pictureBox1.Image = mainBitmap;
            point = new Point(0, 0);
            mouseDown = false;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
            point = e.Location;
            mouseDown = true;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                switch (chooseButton)
                {
                    case (0):
                        break;
                    case (1):
                        graphics.DrawLine(pen, point, e.Location);
                        pictureBox1.Image = mainBitmap;
                        point = e.Location;
                        break;
                    case (2):
                        graphics.Clear(Color.White);
                        graphics.DrawLine(pen, point, e.Location);
                        pictureBox1.Image = mainBitmap;
                        break;
                    case (3):
                        graphics.Clear(Color.White);
                        points = new PointF[4] { point, new Point(point.X, e.Y), e.Location, new Point(e.X, point.Y) };
                        graphics.DrawPolygon(pen, points);
                        pictureBox1.Image = mainBitmap;
                        break;
                    case (5):
                        graphics.Clear(Color.White);
                        Rectangle rect = new Rectangle(x, y, e.X-x, e.Y-y);
                        graphics.DrawEllipse(pen, rect);
                        pictureBox1.Image = mainBitmap;
                        break;
                    case (10):
                        graphics.Clear(Color.White);
                        int n = Convert.ToInt32(textBox2.Text);
                        if ( n > 2)
                        {
                            points = new PointF[n];
                            points[0] = new Point(x, e.Y);
                            int a = 360 / n;
                            int t;
                            for (int i = 1; i < n; i++)
                            {
                                t = a * i;
                                double rad = 3.14 / 180 * t;
                                int x1 = (int)((x - (points[0].Y - y) * Math.Sin(rad)));
                                int y1 = (int)((y + (points[0].Y - y) * Math.Cos(rad)));
                                points[i] = new Point(x1, y1); 
                            }
                        }

                        graphics.DrawPolygon(pen, points);
                        pictureBox1.Image = mainBitmap;
                        break;
                }

            }

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
            textBox1.Visible = true;
            textBox2.Visible = true;
            chooseButton = 10;
        }
    }
}
