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
        PointList pointListN;
        bool mouseDown;
        bool mouseUp;
        bool curve;
        PolygonFigure tmp;
        IFigure figure;

        public EditorForm()
        {
            InitializeComponent();
            mainBitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            tmpBitmap = (Bitmap)mainBitmap.Clone();
            pictureBox.Image = mainBitmap;
            pen = new Pen(Color.Black,10);

            pointListN = new PointList();
            pen.StartCap = LineCap.Round;
            pen.EndCap = LineCap.Round;
            mouseDown = false;
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (curve)
            {
                pointListN.AddPoint(e.Location);
                if (pointListN.Length != 1)
                {
                    tmpBitmap = (Bitmap)mainBitmap.Clone();
                    graphics = Graphics.FromImage(tmpBitmap);
                    figure.DrawFigure(pen, graphics, pointListN);
                    pictureBox.Image = tmpBitmap;
                    GC.Collect();
                }
                mainBitmap = tmpBitmap;
            }
            else
            {
                pointList = new PointList(e.Location);
            }
            mouseDown = true;
            mouseUp = false;
        }
        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseUp && curve)
            {
                tmpBitmap = (Bitmap)mainBitmap.Clone();
                graphics = Graphics.FromImage(tmpBitmap);
                graphics.DrawLine(pen, pointListN.ConvertToPointF()[pointListN.Length - 1], e.Location);
                pictureBox.Image = tmpBitmap;
                GC.Collect();
            }
            if (mouseDown && !curve)
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
            if (!curve)
            {
                
                mainBitmap = tmpBitmap;
            }
            pointList = new PointList();
            mouseDown = false;
            mouseUp = true;
        }

        //private void Hand_Click(object sender, EventArgs e)
        //{
        //    //chooseButton = 0;
        //}

        private void Curve_Click(object sender, EventArgs e)
        {
            pictureBox.Cursor = Cursors.Cross;
            figure = new CurveFigure();
            textBox1.Visible = false;
            numericUpDown.Visible = false;
            curve = true;
        }

        //private void CreateLine_Click(object sender, EventArgs e)
        //{
        //    pictureBox.Cursor = Cursors.Cross;
        //    figure = new CurveFigure();
        //    pointList = new PointList();
        //}

        private void Rectangle_Click(object sender, EventArgs e)
        {
            figure = new RectangleFigure();
            textBox1.Visible = false;
            numericUpDown.Visible = false;
            curve = false;
        }

        private void Cycle_Click(object sender, EventArgs e)
        {
            //figure = new CycleFigure();
        }

        private void Elipse_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            numericUpDown.Visible = false;
            figure = new ElipseFigure();
            curve = false;
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
            numericUpDown.Visible = true;
            tmp = new PolygonFigure((int)numericUpDown.Value);
            figure = tmp;
            curve = false;
        }

        private void numericUpDown_TextChanged(object sender, EventArgs e)
        {
            tmp.N = (int)numericUpDown.Value;
            figure = tmp;
        }
    }
}
