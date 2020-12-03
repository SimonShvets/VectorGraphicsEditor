using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using VectorGraphicsEditor.Painter;
using VectorGraphicsEditor.MarkUp;

namespace VectorGraphicsEditor
{
    public partial class EditorForm : Form
    {
        private string _selectedTool;
        Pen pen;
        bool mouseDown;
        bool mouseUp;
        //PolygonFigure tmp;
        IPainter painter;
        Canvas canvas;
        IMarkUp markup;

        public EditorForm()
        {
            InitializeComponent();

            canvas = new Canvas(pictureBox.Width, pictureBox.Height);
            pictureBox.Image = canvas.MainBitmap;
            pen = new Pen(Color.Red, (int)numericUpDown1.Value);            
            pen.StartCap = LineCap.Round;
            pen.EndCap = LineCap.Round;
            painter = new BrushPainter();
            markup = new BrushMarkUp();
        }
        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            painter.MouseDownHandle(e, pen, markup, canvas);
            pictureBox.Image = canvas.TmpBitmap;
            //if ((_selectedTool == "Curve" || _selectedTool == "WrongPolygon"))
            //{
            //    pointListN.AddPoint(e.Location);
            //    if (pointListN.Length != 1)
            //    {
            //        tmpBitmap = (Bitmap)mainBitmap.Clone();
            //        graphics = Graphics.FromImage(tmpBitmap);
            //        figure.DrawFigure(pen, graphics, pointListN);
            //        pictureBox.Image = tmpBitmap;
            //        GC.Collect();
            //    }
            //    mainBitmap = tmpBitmap;
            //}
            //else if (_selectedTool == "Triangle")
            //{
            //    pointListN.AddPoint(e.Location);
            //    if (pointListN.Length == 2)
            //    {
            //        tmpBitmap = (Bitmap)mainBitmap.Clone();
            //        graphics = Graphics.FromImage(tmpBitmap);
            //        figure.DrawFigure(pen, graphics, pointListN);
            //        pictureBox.Image = tmpBitmap;
            //        GC.Collect();
            //    }
            //    else if (pointListN.Length == 3)
            //    {
            //        graphics.DrawLine(pen, pointListN.ConvertToPointF()[0], pointListN.ConvertToPointF()[2]);
            //        pictureBox.Image = tmpBitmap;
            //        GC.Collect();
            //        pointListN = new PointList();
            //    }
            //    mainBitmap = tmpBitmap;
            //}
            //canvas.Paint(sender, e, pen, markup, painter);
            //pictureBox.Image = canvas.TmpBitmap;
            //canvas.TmpBitmap = (Bitmap)canvas.MainBitmap.Clone();
            //tmpBitmap = (Bitmap)mainBitmap.Clone();
            //graphics = Graphics.FromImage(tmpBitmap);
            //else
            //{
            //    pointList = new PointList(e.Location);
            //}
            //mouseDown = true;
            //mouseUp = false;
        }
        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            painter.MouseMoveHandle(e, pen, markup, canvas);
            pictureBox.Image = canvas.TmpBitmap;
            //canvas.Paint(sender, e, pen, markup, painter);
            //pictureBox.Image = canvas.TmpBitmap;
            //GC.Collect();
            //if (mouseUp && _selectedTool == "Triangle" && pointListN.Length > 0)
            //{
            //    tmpBitmap = (Bitmap)mainBitmap.Clone();
            //    graphics = Graphics.FromImage(tmpBitmap);
            //    graphics.DrawLine(pen, pointListN.ConvertToPointF()[pointListN.Length - 1], e.Location);
            //    pictureBox.Image = tmpBitmap;
            //    GC.Collect();
            //}
            //if (mouseUp && (_selectedTool == "Curve" || _selectedTool == "WrongPolygon"))
            //{
            //    tmpBitmap = (Bitmap)mainBitmap.Clone();
            //    graphics = Graphics.FromImage(tmpBitmap);
            //    graphics.DrawLine(pen, pointListN.ConvertToPointF()[pointListN.Length - 1], e.Location);
            //    pictureBox.Image = tmpBitmap;
            //    GC.Collect();
            //}
            //if (mouseDown && _selectedTool != "Curve" && _selectedTool != "WrongPolygon" && _selectedTool != "" && _selectedTool != "Brush" && _selectedTool != "Hand" && _selectedTool != "Triangle")
            //{
            //    pointList[1] = e.Location;
            //    tmpBitmap = (Bitmap)mainBitmap.Clone();
            //    graphics = Graphics.FromImage(tmpBitmap);
            //    figure.DrawFigure(pen, graphics, pointList);
            //    pictureBox.Image = tmpBitmap;
            //    GC.Collect();
            //}
        }
        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            painter.MouseUpHandle(e, pen, markup, canvas);
        }
        private void pictureBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //if (_selectedTool == "Curve")
            //{
            //mouseDown = false;
            //mouseUp = false;
            //_selectedTool = "";
            //}
            //if (_selectedTool == "WrongPolygon")
            //{
            //tmpBitmap = (Bitmap)mainBitmap.Clone();
            //graphics = Graphics.FromImage(tmpBitmap);
            //graphics.DrawLine(pen, pointListN.ConvertToPointF()[0], pointListN.ConvertToPointF()[pointListN.Length - 1]);
            //pictureBox.Image = tmpBitmap;
            //GC.Collect();
            //mainBitmap = tmpBitmap;
            //mouseDown = false;
            //mouseUp = false;
            //_selectedTool = "";
            //}
        }
        private void Hand_Click(object sender, EventArgs e)
        {
            _selectedTool = "Hand";
        }
        private void Brush_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            numericUpDown.Visible = false;
            painter = new BrushPainter();
            markup = new BrushMarkUp();

        }
        private void Curve_Click(object sender, EventArgs e)
        {
            //figure = new CurveFigure();
            textBox1.Visible = false;
            numericUpDown.Visible = false;
            _selectedTool = "Curve";
            mouseDown = false;
            mouseUp = false;
        }   
        private void Cycle_Click(object sender, EventArgs e)
        {
            //figure = new CycleFigure();
            textBox1.Visible = false;
            numericUpDown.Visible = false;
            _selectedTool = "Cycle";
        }
        private void Elipse_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            numericUpDown.Visible = false;
            //figure = new ElipseFigure();
            _selectedTool = "Elipse";
        }
        private void Triangle_Click(object sender, EventArgs e)
        {
            //figure = new TriangleFigure();
            _selectedTool = "Triangle";
            textBox1.Visible = false;
            numericUpDown.Visible = false;
            mouseDown = false;
            mouseUp = false;
        }
        private void StraightTriangle_Click(object sender, EventArgs e)
        {
            //figure = new StraightTriangleFigure();
            _selectedTool = "StraightTriangle";
        }
        private void IsoscelesTriangle_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            numericUpDown.Visible = false;
            //figure = new IsoscelesTriangleFigure();
            _selectedTool = "IsoscelesTriangle";
        }
        private void WrongPolygon_Click(object sender, EventArgs e)
        {
            //figure = new WrongPolygonFigure();
            //graphics = Graphics.FromImage(mainBitmap);
            //pictureBox.Image = mainBitmap;
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
            //tmp = new PolygonFigure((int)numericUpDown.Value);
            //figure = tmp;
            _selectedTool = "Polygon";
        }
        private void numericUpDown_TextChanged(object sender, EventArgs e)
        {
            //tmp.N = (int)numericUpDown.Value;
            ////figure = tmp;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            pen.Width = (int)numericUpDown1.Value;
        }
        private void Rectangle_Click(object sender, EventArgs e)
        {
            //figure = new RectangleFigure();
            textBox1.Visible = false;
            numericUpDown.Visible = false;
            _selectedTool = "Rectangle";

        }

        private void square_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            numericUpDown.Visible = false;
            //figure = new SquareFigure();            
            _selectedTool = "Square";            
        }

        private void EditorForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.NumPad0)
            {
                square.PerformClick();
            }
        }

        private void ChColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            SolidBrush solidBrush = new SolidBrush(Color.Red);
            ColorDialog colors = new ColorDialog();
            solidBrush.Color = colors.Color;
        }
    }
}
