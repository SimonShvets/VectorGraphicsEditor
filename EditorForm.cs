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
        Image image;
        Point point;
        bool mouseDown;
        bool needClear;
        int chooseButton;


        public EditorForm()
        {
            InitializeComponent();
        }

        private void EditorForm_Load(object sender, EventArgs e)
        {
            mainBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(mainBitmap);
            pen = new Pen(Color.Black, 10);
            pictureBox1.Image = mainBitmap;
            point = new Point(0, 0);
            mouseDown = false;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            
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
                        if (needClear)
                        {
                            graphics.Clear(Color.White);
                        }
                        graphics.DrawLine(pen, point, e.Location);
                        pictureBox1.Image = mainBitmap;
                        //needClear = true;
                        break;
                    case (3):
                        if (needClear)
                        {
                            graphics.Clear(Color.White);
                        }
                        PointF[] points = new PointF[4] { point, new Point(point.X, e.Y), e.Location, new Point(e.X, point.Y) };
                        graphics.DrawPolygon(pen, points);
                        pictureBox1.Image = mainBitmap;
                        needClear = true;
                        break;
                }

            }

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            needClear = false;
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
            chooseButton = 10;
        }
    }
}
