using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using VectorGraphicsEditor.Painter;
using VectorGraphicsEditor.MarkUp;
using VectorGraphicsEditor.Fictory;
using System.Collections.Generic;

namespace VectorGraphicsEditor
{
    public partial class EditorForm : Form
    {

        Pen pen;
        IPainter painter;
        Canvas canvas;
        IMarkUp markup;
        IFictory fictory;
        List<IPainter> painters;
        IMarkUp currentMarkUp;

        public EditorForm()
        {
            InitializeComponent();
            canvas = new Canvas(pictureBox.Width, pictureBox.Height);
            canvas.TmpBitmap = (Bitmap)canvas.MainBitmap.Clone();
            canvas.Graphics = Graphics.FromImage(canvas.TmpBitmap);
            pictureBox.Image = canvas.MainBitmap;
            pen = new Pen(Color.Black, (int)numericUpDown1.Value);            
            pen.StartCap = LineCap.Round;
            pen.EndCap = LineCap.Round;
            painter = new BrushPainter();
            markup = new BrushMarkUp();
            fictory = new BrushFictory();
            painters = new List<IPainter>();
        }
        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if(markup.Length == 0)
            {
            markup = fictory.CreateMarkUp();
            painter = fictory.CreatePainter();
            }
            if (markup is PolygonMarkUp)
            {
                PolygonMarkUp tmp = (PolygonMarkUp)markup;
                tmp.N = (int)numericUpDown.Value;
                markup = tmp;
            }
            painter.MouseDownHandle(e.Location, pen, markup, canvas);
            pictureBox.Image = canvas.TmpBitmap;

        }
        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            painter.MouseMoveHandle(e.Location, pen, markup, canvas);

            pictureBox.Image = canvas.TmpBitmap;     

        }
        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            painter.MouseUpHandle(e.Location, pen, markup, canvas);
            pictureBox.Image = canvas.TmpBitmap;
            painters.Add(painter);
        }
        private void pictureBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            painter.MouseDoubleHandle(e.Location, pen, markup, canvas);
            pictureBox.Image = canvas.TmpBitmap;

            painter.MouseUpHandle(e.Location, pen, markup, canvas);
            painters.Add(painter);

        }
        private void Hand_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            numericUpDown.Visible = false;
            fictory = new HandFictory();
        }

        private void Brush_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            numericUpDown.Visible = false;
            fictory = new BrushFictory();
        }

        private void Curve_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            numericUpDown.Visible = false;
            fictory = new CurveFictory();
        }   

        private void Circle_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            numericUpDown.Visible = false;
            fictory = new CircleFictory();
        }

        private void Ellipse_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            numericUpDown.Visible = false;
            fictory = new ElipseFictory();
        }

        private void Triangle_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            numericUpDown.Visible = false;
            fictory = new TriangleFictory();
        }

        private void IsoscelesTriangle_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            numericUpDown.Visible = false;
            fictory = new IsoscelesTriangleFictory();
        }

        private void IrregularPolygon_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            numericUpDown.Visible = false;
            fictory = new IrregularPolygonFictory();
        }

        private void Polygon_Click(object sender, EventArgs e)
        {   
            textBox1.Visible = true;
            numericUpDown.Visible = true;
            fictory = new PolygonFictory();

        }
        private void numericUpDown_TextChanged(object sender, EventArgs e)
        {
            PolygonMarkUp tmp = (PolygonMarkUp)markup;
            tmp.N = (int)numericUpDown.Value;
            markup = tmp;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            pen.Width = (int)numericUpDown1.Value;
        }

        private void Rectangle_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            numericUpDown.Visible = false;
            fictory = new RectangleFictory();
        }

        private void square_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            numericUpDown.Visible = false;
            fictory = new SquareFictory();
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

        private void RightTriangle_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            numericUpDown.Visible = false;
            fictory = new RightTriangleFictory();
        }
        private void clear_Click(object sender, EventArgs e)
        {
            canvas.Graphics.Clear(Color.White);
        }

        private void pipette_Click(object sender, EventArgs e, MouseEventArgs eM)
        {
            int x = eM.X;
            int y = eM.Y;
            PointF point;            
            Color color;
            ((Bitmap)pictureBox.Image).GetPixel(x, y);

        }
    }
}