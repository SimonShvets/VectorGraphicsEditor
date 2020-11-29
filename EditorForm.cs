using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using VectorGraphicsEditor.Figures;

namespace VectorGraphicsEditor
{
    public partial class EditorForm : Form
    {
        private string _selectedTool;
        Bitmap mainBitmap;
        Bitmap tmpBitmap;
        Graphics graphics;
        Pen pen;
        PointList pointList;
        PointList pointListN;
        bool mouseDown;
        bool mouseUp;
        PolygonFigure tmp;
        IFigure figure;

        public EditorForm()
        {
            InitializeComponent();

            figure = new HandFigure();
            mainBitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            tmpBitmap = (Bitmap)mainBitmap.Clone();
            pictureBox.Image = mainBitmap;
            pen = new Pen(Color.Black, (int)numericUpDown1.Value);

            pointListN = new PointList();
            pen.StartCap = LineCap.Round;
            pen.EndCap = LineCap.Round;
            mouseDown = false;
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if ((_selectedTool == "Curve" || _selectedTool == "WrongPolygon"))
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
            if (mouseUp && (_selectedTool == "Curve" || _selectedTool == "WrongPolygon"))
            {
                tmpBitmap = (Bitmap)mainBitmap.Clone();
                graphics = Graphics.FromImage(tmpBitmap);
                graphics.DrawLine(pen, pointListN.ConvertToPointF()[pointListN.Length - 1], e.Location);
                pictureBox.Image = tmpBitmap;
                GC.Collect();
            }
            if (mouseDown && _selectedTool != "Curve" && _selectedTool != "WrongPolygon" && _selectedTool != "")
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
            if (_selectedTool != "Curve")
            {
                
                mainBitmap = tmpBitmap;
            }
            if (_selectedTool != "WrongPolygon")
            {

                mainBitmap = tmpBitmap;
            }
            pointList = new PointList();
            mouseDown = false;
            mouseUp = true;
        }
        private void pictureBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (_selectedTool == "Curve")
            {
            mouseDown = false;
            mouseUp = false;
            _selectedTool = "";
            }
            if (_selectedTool == "WrongPolygon")
            {
            tmpBitmap = (Bitmap)mainBitmap.Clone();
            graphics = Graphics.FromImage(tmpBitmap);
            graphics.DrawLine(pen, pointListN.ConvertToPointF()[0], pointListN.ConvertToPointF()[pointListN.Length - 1]);
            pictureBox.Image = tmpBitmap;
            GC.Collect();
            mainBitmap = tmpBitmap;
            mouseDown = false;
            mouseUp = false;
            _selectedTool = "";
            }
        }


        //private void Hand_Click(object sender, EventArgs e)
        //{
        //    //chooseButton = 0;
        //}

        private void Curve_Click(object sender, EventArgs e)
        {
            pictureBox.Cursor = Cursors.Cross;
            figure = new CurveFigure();
            pointListN = new PointList();
            textBox1.Visible = false;
            numericUpDown.Visible = false;
            _selectedTool = "Curve";
            mouseDown = false;
            mouseUp = false;
        }

        private void Rectangle_Click(object sender, EventArgs e)
        {
            figure = new RectangleFigure();
            textBox1.Visible = false;
            numericUpDown.Visible = false;
            _selectedTool = "Rectangle";
        }

        private void Cycle_Click(object sender, EventArgs e)
        {
            figure = new CycleFigure();
            textBox1.Visible = false;
            numericUpDown.Visible = false;
            _selectedTool = "Cycle";
        }

        private void Elipse_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            numericUpDown.Visible = false;
            figure = new ElipseFigure();
            _selectedTool = "Elipse";
        }

        private void Triangle_Click(object sender, EventArgs e)
        {
            //figure = new TriangleFigure();
            _selectedTool = "Triangle";
        }

        private void StraightTriangle_Click(object sender, EventArgs e)
        {
            //figure = new StraightTriangleFigure();
            _selectedTool = "StraightTriangle";
        }

        private void IsoscelesTriangle_Click(object sender, EventArgs e)
        {
            //figure = new IsoscelesTriangleFigure();
            _selectedTool = "IsoscelesTriangle";
        }

        private void WrongPolygon_Click(object sender, EventArgs e)
        {
            pictureBox.Cursor = Cursors.Cross;
            figure = new WrongPolygonFigure();
            pointListN = new PointList();
            textBox1.Visible = false;
            numericUpDown.Visible = false;
            _selectedTool = "WrongPolygon";
            mouseDown = false;
            mouseUp = false;
        }

        private void Polygon_Click(object sender, EventArgs e)
        {   
            textBox1.Visible = true;
            numericUpDown.Visible = true;
            tmp = new PolygonFigure((int)numericUpDown.Value);
            figure = tmp;
            _selectedTool = "Polygon";
        }

        private void numericUpDown_TextChanged(object sender, EventArgs e)
        {
            tmp.N = (int)numericUpDown.Value;
            figure = tmp;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            pen.Width = (int)numericUpDown1.Value;
        }
    }
}
