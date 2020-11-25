using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VectorGraphicsEditor.figurs;

namespace VectorGraphicsEditor
{
    public partial class EditorForm : Form
    {
        Bitmap mainBitmap;
        Bitmap tmpBitmap;
        Graphics graphics;
        Pen pen;
        Point point;
        bool mouseDown;
        bool clean = true;
        PointF[] points;
        IFigure figure;


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
            if (!clean)
            {
                graphics.Clear(Color.White);
                pictureBox1.Image = tmpBitmap;
                clean = true;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown && clean)
            {
                tmpBitmap = (Bitmap)mainBitmap.Clone();
                graphics = Graphics.FromImage(tmpBitmap);

                points = new PointF[] {point, e.Location};

                pictureBox1.Image = figure.DrawFigure(graphics, tmpBitmap, points, pen);
                GC.Collect();
            }


        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
            mainBitmap = tmpBitmap;
        }

        private void Hand_Click(object sender, EventArgs e)
        {
            clean = false;
            figure = new HandFigure();
            //chooseButton = 0;
        }

        private void Brush_Click(object sender, EventArgs e)
        {
            figure = new BrushFigire();
        }

        private void CreateLine_Click(object sender, EventArgs e)
        {
            figure = new CreateLineFigure();
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
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            figure = new PolygonFigure(Convert.ToInt32(textBox2.Text));
        }
    }
}
