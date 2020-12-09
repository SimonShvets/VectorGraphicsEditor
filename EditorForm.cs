using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using VectorGraphicsEditor.Painter;
using VectorGraphicsEditor.Factory;
using VectorGraphicsEditor.Controllers;
using VectorGraphicsEditor.Controllers.ToolsControllers;
using VectorGraphicsEditor.Figure;

namespace VectorGraphicsEditor
{
    public partial class EditorForm : Form
    {
        Pen pen;
        Canvas canvas;
        Container container;
        AbstractFigure figure;
        IToolController toolController;
        IFactory factory;

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
            figure = new BrushFigure(new BrushPainter(), new BrushController());
            toolController = new MoverController();
            factory = new BrushFactory();
            container = new Container();
        }
        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (figure is TriangleFigure)
            {
                if (figure.Length % 3 == 0)
                {
                    figure = factory.CreateFigure(figure.Painter, figure.FigureController);
                }
            }
            if (!(figure is CurveFigure
                || figure is IrregularPolygonFigure
                || figure is TriangleFigure))
            {
                figure = factory.CreateFigure(figure.Painter, figure.FigureController);
            }
            if (figure is PolygonFigure)
            {
                PolygonFigure tmp = (PolygonFigure)figure;
                tmp.N = (int)numericUpDown.Value;
                figure = tmp;
            }
            figure.FigureController.MouseDownHandle(e.Location, pen, figure, canvas);
            toolController.MouseDownHandle(e.Location, pen, figure, canvas, container);
            pictureBox.Image = canvas.TmpBitmap;

        }
        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            figure.FigureController.MouseMoveHandle(e.Location, pen, figure, canvas);
            toolController.MouseDownHandle(e.Location, pen, figure, canvas, container);
            pictureBox.Image = canvas.TmpBitmap;     

        }
        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            figure.FigureController.MouseUpHandle(e.Location, pen, figure, canvas);
            if  (!(figure is BrushFigure 
                || figure is CurveFigure
                || figure is TriangleFigure
                || figure is IrregularPolygonFigure))
            {
                container.Add(figure);
            }
            else if (figure is TriangleFigure)
            {
                if (figure.Length % 3 == 0)
                {
                    container.Add(figure);
                }
            }
            if (figure is BrushFigure)
            {
                container.Add(figure);
            }
            toolController.MouseDownHandle(e.Location, pen, figure, canvas, container);
            pictureBox.Image = canvas.TmpBitmap;
        }
        private void pictureBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            figure.FigureController.MouseDoubleHandle(e.Location, pen, figure, canvas);
            container.Add(figure);
            if (figure is CurveFigure
                || figure is IrregularPolygonFigure)
            {
                figure = factory.CreateFigure(figure.Painter, figure.FigureController);
            }
            toolController.MouseDownHandle(e.Location, pen, figure, canvas, container);
            pictureBox.Image = canvas.TmpBitmap;
        }
        private void Hand_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            numericUpDown.Visible = false;
            factory = new HandFactory();
            figure = factory.CreateFigure(figure.Painter, figure.FigureController);
        }
        private void Brush_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            numericUpDown.Visible = false;
            factory = new BrushFactory();
            figure = factory.CreateFigure(figure.Painter, figure.FigureController);
        }
        private void Curve_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            numericUpDown.Visible = false;
            factory = new CurveFactory();
            figure = factory.CreateFigure(figure.Painter, figure.FigureController);
        }   

        private void Circle_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            numericUpDown.Visible = false;
            factory = new CircleFactory();
            figure = factory.CreateFigure(figure.Painter, figure.FigureController);
        }

        private void Ellipse_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            numericUpDown.Visible = false;
            factory = new ElipseFactory();
            figure = factory.CreateFigure(figure.Painter, figure.FigureController);
        }

        private void Triangle_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            numericUpDown.Visible = false;
            factory = new TriangleFactory();
            figure = factory.CreateFigure(figure.Painter, figure.FigureController);
        }

        private void IsoscelesTriangle_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            numericUpDown.Visible = false;
            factory = new IsoscelesTriangleFactory();
            figure = factory.CreateFigure(figure.Painter, figure.FigureController);
        }

        private void IrregularPolygon_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            numericUpDown.Visible = false;
            factory = new IrregularPolygonFactory();
            figure = factory.CreateFigure(figure.Painter, figure.FigureController);
        }

        private void Polygon_Click(object sender, EventArgs e)
        {   
            textBox1.Visible = true;
            numericUpDown.Visible = true;
            factory = new PolygonFactory();
            figure = factory.CreateFigure(figure.Painter, figure.FigureController);

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
            factory = new RectangleFactory();
            figure = factory.CreateFigure(figure.Painter, figure.FigureController);
        }

        private void square_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            numericUpDown.Visible = false;
            factory = new SquareFactory();
            figure = factory.CreateFigure(figure.Painter, figure.FigureController);
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
            factory = new RightTriangleFactory();
            figure = factory.CreateFigure(figure.Painter, figure.FigureController);
        }

        private void Mover_Click(object sender, EventArgs e)
        {
            toolController = new MoverController();
        }
    }
}