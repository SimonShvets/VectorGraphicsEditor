﻿using System;
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
            graphics = Graphics.FromImage(tmpBitmap);
            pictureBox.Image = mainBitmap;
            pen = new Pen(Color.Red, (int)numericUpDown1.Value);            
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
            else if(_selectedTool == "Brush")
            {
                mouseDown = true;
                pointListN.AddPoint(e.Location);
                tmpBitmap = (Bitmap)mainBitmap.Clone();
                graphics = Graphics.FromImage(tmpBitmap);
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
            if (_selectedTool == "Brush")
            {
                if (mouseDown)
                {
                    pointListN.AddPoint(e.Location);
                    figure.DrawFigure(pen, graphics,pointListN);
                    pictureBox.Image = tmpBitmap;
                    GC.Collect();
                }
            }
            if (mouseUp && (_selectedTool == "Curve" || _selectedTool == "WrongPolygon"))
            {
                tmpBitmap = (Bitmap)mainBitmap.Clone();
                graphics = Graphics.FromImage(tmpBitmap);
                graphics.DrawLine(pen, pointListN.ConvertToPointF()[pointListN.Length - 1], e.Location);
                pictureBox.Image = tmpBitmap;
                GC.Collect();
            }
            if (mouseDown && _selectedTool != "Curve" && _selectedTool != "WrongPolygon" && _selectedTool != "" && _selectedTool != "Brush" && _selectedTool != "Hand" )
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
            if (_selectedTool == "Brush")
            {
                if (mouseDown)
                {
                    pointListN = new PointList();
                    mainBitmap = tmpBitmap;
                }
            }
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
        private void Hand_Click(object sender, EventArgs e)
        {
            _selectedTool = "Hand";
        }
        private void Brush_Click(object sender, EventArgs e)
        {
            pictureBox.Cursor = Cursors.Cross;
            textBox1.Visible = false;
            numericUpDown.Visible = false;
            figure = new BrushFigure();
            pointListN = new PointList();
            _selectedTool = "Brush";
        }
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
            textBox1.Visible = false;
            numericUpDown.Visible = false;
            figure = new TriangleFigure();
            _selectedTool = "Triangle";
            
        }
        private void StraightTriangle_Click(object sender, EventArgs e)
        {
            figure = new StraightTriangleFigure();
            _selectedTool = "StraightTriangle";
        }
        private void IsoscelesTriangle_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            numericUpDown.Visible = false;
            figure = new IsoscelesTriangleFigure();
            _selectedTool = "IsoscelesTriangle";
        }
        private void WrongPolygon_Click(object sender, EventArgs e)
        {
            pictureBox.Cursor = Cursors.Cross;
            figure = new WrongPolygonFigure();
            pointListN = new PointList();
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
        private void Rectangle_Click(object sender, EventArgs e)
        {
            figure = new RectangleFigure();
            textBox1.Visible = false;
            numericUpDown.Visible = false;
            _selectedTool = "Rectangle";

        }

        private void square_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            numericUpDown.Visible = false;
            figure = new SquareFigure();            
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
