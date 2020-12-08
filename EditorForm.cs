using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using VectorGraphicsEditor.Painter;
using VectorGraphicsEditor.MarkUp;
using VectorGraphicsEditor.Fictory;
using VectorGraphicsEditor.Controllers;
using System.Collections.Generic;
using VectorGraphicsEditor.ToolsControllers

namespace VectorGraphicsEditor
{
    public partial class EditorForm : Form
    {
        Pen pen;
        Canvas canvas;
        Conteiner figures;
        IMarkUp markup;
        IPainter painter;
        IFigureController figureController;
        IController toolController;
        IFictory fictory;
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
            figureController = new BrushController();
            fictory = new BrushFictory();
            figures = new Conteiner();
        }
        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if(markup.Length == 0 || painter is BrushPainter)
            {
            markup = fictory.CreateMarkUp();
            painter = fictory.CreatePainter();
            figureController = fictory.CreateController();
            }
            if (markup is PolygonMarkUp)
            {
                PolygonMarkUp tmp = (PolygonMarkUp)markup;
                tmp.N = (int)numericUpDown.Value;
                markup = tmp;
            }
            figureController.MouseDownHandle(e.Location, pen, markup, painter, canvas);
            toolController.MouseDownHandle(e.Location, pen, markup, painter, canvas);
            pictureBox.Image = canvas.TmpBitmap;

        }
        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            figureController.MouseMoveHandle(e.Location, pen, markup, painter, canvas);
            toolController.MouseDownHandle(e.Location, pen, markup, painter, canvas);
            pictureBox.Image = canvas.TmpBitmap;     

        }
        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            figureController.MouseUpHandle(e.Location, pen, markup, painter, canvas);
            pictureBox.Image = canvas.TmpBitmap;
            if  (!(markup is BrushMarkUp 
                || markup is CurveMarkUp
                || markup is TriangleMarkUp
                || markup is IrregularPolygonMarkUp))
            {
                figures.Add(markup);
                markup.PointList.Clear();
            }
            else if (markup is TriangleMarkUp)
            {
                if (markup.Length % 3 == 0)
                {
                    figures.Add(markup);
                    markup.PointList.Clear();
                }
            }
            toolController.MouseDownHandle(e.Location, pen, markup, painter, canvas);
        }
        private void pictureBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            figureController.MouseDoubleHandle(e.Location, pen, markup, painter, canvas);
            pictureBox.Image = canvas.TmpBitmap;
            figures.Add(markup);
            markup.PointList.Clear();
            toolController.MouseDownHandle(e.Location, pen, markup, painter, canvas);
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
    }
}