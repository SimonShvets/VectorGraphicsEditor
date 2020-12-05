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
            canvas.TmpBitmap = (Bitmap)canvas.MainBitmap.Clone();
            canvas.Graphics = Graphics.FromImage(canvas.TmpBitmap);
            pictureBox.Image = canvas.MainBitmap;
            pen = new Pen(Color.Red, (int)numericUpDown1.Value);            
            pen.StartCap = LineCap.Round;
            pen.EndCap = LineCap.Round;
            painter = new BrushPainter();
            markup = new BrushMarkUp();
        }
        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            painter.MouseDownHandle(e.Location, pen, markup, canvas);
            pictureBox.Image = canvas.TmpBitmap;

        }
        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            painter.MouseMoveHandle(e.Location, pen, markup, canvas);

            pictureBox.Image = canvas.TmpBitmap;

            pictureBox.Image = canvas.TmpBitmap;            

        }
        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            painter.MouseUpHandle(e.Location, pen, markup, canvas);
            pictureBox.Image = canvas.TmpBitmap;
        }
        private void pictureBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            painter.MouseDoubleHandle(e.Location, pen, markup, canvas);
            pictureBox.Image = canvas.TmpBitmap;

            painter.MouseUpHandle(e.Location, pen, markup, canvas);
            

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
            textBox1.Visible = false;
            numericUpDown.Visible = false;
            painter = new CurvePainter();
            markup = new CurveMarkUp();
        }   
        private void Circle_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            numericUpDown.Visible = false;
            painter = new CirclePainter();
            markup = new CircleMarkUp();
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
            textBox1.Visible = false;
            numericUpDown.Visible = false;
            painter = new TrianglePainter();
            markup = new TriangleMarkUp();
        }
        private void StraightTriangle_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            numericUpDown.Visible = false;
            painter = new RightTrianglePainter();
            markup = new RightTriangleMarkUp();
            _selectedTool = "StraightTriangle";
        }
        private void IsoscelesTriangle_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            numericUpDown.Visible = false;
            painter = new IsoscelesTrianglePainter();
            markup = new IsoscelesTriangleMarkUp();
            //figure = new IsoscelesTriangleFigure();
            _selectedTool = "IsoscelesTriangle";
        }
        private void IrregularPolygon_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            numericUpDown.Visible = false;
            painter = new IrregularPolygonPainter();
            markup = new IrregularPolygonMarkUp();
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
            painter = new SquarePainter();
            markup = new SquareMarkUp();
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
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = false;
            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                pen.Color = MyDialog.Color;
            }
        }


    }
}