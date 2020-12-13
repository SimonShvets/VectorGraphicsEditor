using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using VectorGraphicsEditor.Factory.ToolFactory;
using VectorGraphicsEditor.Factory.FigureFactory;
using VectorGraphicsEditor.Controllers;
using VectorGraphicsEditor.Controllers.ToolsControllers;
using VectorGraphicsEditor.Selector;
using VectorGraphicsEditor.Figure;
using VectorGraphicsEditor.Tools;

namespace VectorGraphicsEditor
{
    public partial class EditorForm : Form
    {
        Pen pen;
        Canvas canvas;
        Container container;
        AbstractFigure figure;
        AbstractTool tool;
        IToolController toolController;
        IFigureFactory figureFactory;
        IToolFactory toolFactory;
        bool PaintMode;
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
            figure = new BrushFigure(new BrushController());
            toolController = new MoveController();
            figureFactory = new BrushFactory();
            tool = new HandTool(new HandSelector());
            container = new Container();
        }
        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (PaintMode)
            {
            if (figure is TriangleFigure)
            {
                if (figure.Points.Count % 3 == 0)
                {
                    figure = figureFactory.CreateFigure(figure.FigureController);
                }
            }
            if (!(figure is CurveFigure
                || figure is IrregularPolygonFigure
                || figure is TriangleFigure))
            {
                figure = figureFactory.CreateFigure(figure.FigureController);
            }
            if (figure is PolygonFigure)
            {
                PolygonFigure tmp = (PolygonFigure)figure;
                tmp.N = (int)numericUpDown.Value;
                figure = tmp;
            }
            figure.FigureController.MouseDownHandle(e.Location, pen, figure, canvas);
                pictureBox.Image = canvas.MainBitmap;
            }
            if (PaintMode == false)
            {
            toolController.MouseDownHandle(e.Location, pen, figure, canvas, container, tool);
            pictureBox.Image = canvas.MainBitmap;
            }

        }
        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (PaintMode)
            {
                figure.FigureController.MouseMoveHandle(e.Location, pen, figure, canvas);
                pictureBox.Image = canvas.TmpBitmap;
            }
            if (PaintMode == false)
            {
                toolController.MouseMoveHandle(e.Location, pen, figure, canvas, container, tool);
                pictureBox.Image = canvas.TmpBitmap;
            }

        }
        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (PaintMode)
            {
                figure.FigureController.MouseUpHandle(e.Location, pen, figure, canvas);
                pictureBox.Image = canvas.MainBitmap;
                if (!(figure is BrushFigure
                    || figure is CurveFigure
                    || figure is TriangleFigure
                    || figure is IrregularPolygonFigure))
                {
                    container.Add(figure);
                }
                else if (figure is TriangleFigure)
                {
                    if (figure.Points.Count % 3 == 0)
                    {
                        container.Add(figure);
                    }
                }
                if (figure is BrushFigure)
                {
                    container.Add(figure);
                }
                    
            }
            if (PaintMode == false)
            {
                toolController.MouseUpHandle(e.Location, pen, figure, canvas, container, tool);
                pictureBox.Image = canvas.MainBitmap;
            }
            }
        private void pictureBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (PaintMode)
            {
                figure.FigureController.MouseDoubleHandle(e.Location, pen, figure, canvas);
                container.Add(figure);
                if (figure is CurveFigure
                    || figure is IrregularPolygonFigure)
                {
                    figure = figureFactory.CreateFigure(figure.FigureController);
                    pictureBox.Image = canvas.MainBitmap;
                }
            }
            if (PaintMode == false)
            {
                toolController.MouseDoubleHandle(e.Location, pen, figure, canvas, container, tool);
                pictureBox.Image = canvas.MainBitmap;
            }
        }
        private void Hand_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            numericUpDown.Visible = false;
            toolFactory = new HandFactory();
            tool = toolFactory.CreateTool(tool.Selector);
            PaintMode = false;
        }
        private void Brush_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            numericUpDown.Visible = false;
            figureFactory = new BrushFactory();
            figure = figureFactory.CreateFigure(figure.FigureController);
            PaintMode = true;
        }
        private void Curve_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            numericUpDown.Visible = false;
            figureFactory = new CurveFactory();
            figure = figureFactory.CreateFigure(figure.FigureController);
            PaintMode = true;
        }

        private void Circle_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            numericUpDown.Visible = false;
            figureFactory = new CircleFactory();
            figure = figureFactory.CreateFigure(figure.FigureController);
            PaintMode = true;
        }

        private void Ellipse_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            numericUpDown.Visible = false;
            figureFactory = new ElipseFactory();
            figure = figureFactory.CreateFigure(figure.FigureController);
            PaintMode = true;
        }

        private void Triangle_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            numericUpDown.Visible = false;
            figureFactory = new TriangleFactory();
            figure = figureFactory.CreateFigure(figure.FigureController);
            PaintMode = true;
        }

        private void IsoscelesTriangle_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            numericUpDown.Visible = false;
            figureFactory = new IsoscelesTriangleFactory();
            figure = figureFactory.CreateFigure(figure.FigureController);
            PaintMode = true;
        }

        private void IrregularPolygon_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            numericUpDown.Visible = false;
            figureFactory = new IrregularPolygonFactory();
            figure = figureFactory.CreateFigure(figure.FigureController);
            PaintMode = true;
        }

        private void Polygon_Click(object sender, EventArgs e)
        {   
            textBox1.Visible = true;
            numericUpDown.Visible = true;
            figureFactory = new PolygonFactory();
            figure = figureFactory.CreateFigure(figure.FigureController);
            PaintMode = true;

        }
        private void numericUpDown_TextChanged(object sender, EventArgs e)
        {
            PolygonFigure tmp = (PolygonFigure)figure;
            tmp.N = (int)numericUpDown.Value;
            figure = tmp;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            pen.Width = (int)numericUpDown1.Value;
        }

        private void Rectangle_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            numericUpDown.Visible = false;
            figureFactory = new RectangleFactory();
            figure = figureFactory.CreateFigure(figure.FigureController);
            PaintMode = true;
            PaintMode = true;
        }

        private void square_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            numericUpDown.Visible = false;
            figureFactory = new SquareFactory();
            figure = figureFactory.CreateFigure(figure.FigureController);
            PaintMode = true;
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
            figureFactory = new RightTriangleFactory();
            figure = figureFactory.CreateFigure(figure.FigureController);
            PaintMode = true;
        }

        private void Mover_Click(object sender, EventArgs e)
        {
            toolController = new MoveController();
        }
    }
}