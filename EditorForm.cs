using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using VectorGraphicsEditor.Painter;
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
        IMarkUp markup;
        IFictory fictory;       
        List<IPainter> painters;
        IMarkUp currentMarkUp;
        bool pip = false;
        Size StartSize;
        //double zoom = 1.25;
        bool lupaCh = false;
        Point lastPoint;       


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
            this.pictureBox.MouseWheel += PictureBox_MouseWheel;
            //this.pictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            SizeLabel.Text = Convert.ToString($"{pictureBox.Width} X {pictureBox.Height}");
            canvas = new Canvas(pictureBox.Width, pictureBox.Height);
            canvas.TmpBitmap = (Bitmap)canvas.MainBitmap.Clone();
            canvas.Graphics = Graphics.FromImage(canvas.TmpBitmap);
            pictureBox.Image = canvas.MainBitmap;
            pen = new Pen(Color.Black, (int)numericUpDown1.Value);            
            pen.StartCap = LineCap.Round;
            pen.EndCap = LineCap.Round;
            figure = new BrushFigure(new BrushPainter(), new BrushController());
            toolController = new MoveController();
            figureFactory = new BrushFactory();
            tool = new HandTool(new HandSelector());
            container = new Container();
        }


        private void PictureBox_MouseWheel(object sender, MouseEventArgs e)
        {
            ////double ntX = e.X;
            ////double ntY = e.Y;
            ////double dtX = ntX - e.X;
            ////double dtY = ntY - e.Y;
             
            //if (pictureBox.Image != null)
            //{
            //    if (e.Delta < 0)
            //    {
            //        double ntX = e.X * zoom;
            //        double ntY = e.Y * zoom;
            //        double dtX = ntX - e.X;
            //        double dtY = ntY - e.Y;
            //        zoom = zoom * 1.05;
            //        //pictureBox.Location = e.Location;
            //        //pictureBox.Height = (int)(pictureBox.Image.Height * zoom);
            //        //pictureBox.Location = new Point((int)(pictureBox.Location.X - dtX), (int)(pictureBox.Location.Y - dtY));
            //    }
            //    else
            //    {
            //        if (zoom != 1.0)
            //        {
            //            //double ntX = e.X / zoom;
            //            //double ntY = e.Y / zoom;                        
            //            //double dtX = ntX - e.X;
            //            //double dtY = ntY - e.Y;
            //            //pictureBox.Height = (int)(pictureBox.Image.Height / zoom);
            //            //pictureBox.Width = pictureBox.Image.Height + pictureBox.Image.Height / 3;
            //            zoom = zoom / 1.05;
            //            //pictureBox.Location = e.Location;
            //            //pictureBox.Location = new Point((int)(pictureBox.Location.X - dtX), (int)(pictureBox.Location.Y - dtY));
            //        }
            //    }

            //    pictureBox.Width = (int)Math.Round(pictureBox.Image.Width * zoom);
            //    pictureBox.Height = (int)Math.Round(pictureBox.Image.Height * zoom);
            //}
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (lupaCh == true)
            if (PaintMode)
            {
            if (figure is TriangleFigure)
            {
                if (figure.Length % 3 == 0)
                {
                    figure = figureFactory.CreateFigure(figure.Painter, figure.FigureController);
                }
                if (e.Button == MouseButtons.Left)
                {
                    const double eps = 1.25;
                    double ntX = e.X * eps;
                    double ntY = e.Y * eps;
                    double dtX = ntX - e.X;
                    double dtY = ntY - e.Y;
                    pictureBox.Height = (int)(pictureBox.Height * eps);
                    pictureBox.Width = pictureBox.Height + pictureBox.Height / 3;
                    pictureBox.Location = new Point((int)(pictureBox.Location.X - dtX), (int)(pictureBox.Location.Y - dtY));
                }
                if (e.Button == MouseButtons.Right)
                {
                    const double eps = 1.25;
                    double ntX = e.X / eps;
                    double ntY = e.Y / eps;
                    double dtX = ntX - e.X;
                    double dtY = ntY - e.Y;
                    pictureBox.Height = (int)(pictureBox.Height / eps);
                    pictureBox.Width = pictureBox.Height + pictureBox.Height / 3;
                    pictureBox.Location = new Point((int)(pictureBox.Location.X - dtX), (int)(pictureBox.Location.Y - dtY));
                }
            }
            if (markup.Length == 0)
            {
            markup = fictory.CreateMarkUp();
            painter = fictory.CreatePainter();
            }
            if (!(figure is CurveFigure
                || figure is IrregularPolygonFigure
                || figure is TriangleFigure))
            {
                figure = figureFactory.CreateFigure(figure.Painter, figure.FigureController);
            }
            if (figure is PolygonFigure)
            {
                PolygonFigure tmp = (PolygonFigure)figure;
                tmp.N = (int)numericUpDown.Value;
                figure = tmp;
            }
            painter.MouseDownHandle(e.Location, pen, markup, canvas);
            pictureBox.Image = canvas.TmpBitmap;
            if (pip == true)
            {
                Color pipette = canvas.MainBitmap.GetPixel(e.Location.X, e.Location.Y);
                pen.Color = pipette;
            }
            pip = false;
            lupaCh = false;
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
                    if (figure.Length % 3 == 0)
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
                    figure = figureFactory.CreateFigure(figure.Painter, figure.FigureController);
                    pictureBox.Image = canvas.MainBitmap;
                }
            }
            if (PaintMode == false)
            {
                toolController.MouseDoubleHandle(e.Location, pen, figure, canvas, container, tool);
                pictureBox.Image = canvas.MainBitmap;
            }
        }

        private static void setColor(Control Container, Button btnFocus)
        {
            btnFocus.BackColor = Color.FromArgb(27, 28, 37);
            foreach (Control Btn in Container.Controls)
            {
                if(Btn is Button)
                {
                    if(btnFocus != Btn)
                    {
                        Btn.BackColor = Color.FromArgb(41, 42, 49);
                    }
                }
            }
        }

        private void Hand_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            numericUpDown.Visible = false;
            fictory = new HandFictory();
            Button Btn = sender as Button;
            if (Btn != null)
            {
                setColor(this, Btn);
            }
            toolFactory = new HandFactory();
            tool = toolFactory.CreateTool(tool.Selector);
            PaintMode = false;
        }
        private void Brush_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            numericUpDown.Visible = false;
            figureFactory = new BrushFactory();
            figure = figureFactory.CreateFigure(figure.Painter, figure.FigureController);
            PaintMode = true;
            fictory = new BrushFictory();
            Button Btn = sender as Button;
            if (Btn != null)
            {
                setColor(this, Btn);
            }
        }
        private void Curve_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            numericUpDown.Visible = false;
            fictory = new CurveFictory();
            Button Btn = sender as Button;
            if (Btn != null)
            {
                setColor(this, Btn);
            }
        }   
            figureFactory = new CurveFactory();
            figure = figureFactory.CreateFigure(figure.Painter, figure.FigureController);
            PaintMode = true;
        }

        private void Circle_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            numericUpDown.Visible = false;
            fictory = new CircleFictory();
            Button Btn = sender as Button;
            if (Btn != null)
            {
                setColor(this, Btn);                
            }
            
            figureFactory = new CircleFactory();
            figure = figureFactory.CreateFigure(figure.Painter, figure.FigureController);
            PaintMode = true;
        }

        private void Ellipse_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            numericUpDown.Visible = false;
            fictory = new ElipseFictory();
            Button Btn = sender as Button;
            if(Btn != null)
            {
                setColor(this, Btn);
                
            }
            

            figureFactory = new ElipseFactory();
            figure = figureFactory.CreateFigure(figure.Painter, figure.FigureController);
            PaintMode = true;
        }

        private void Triangle_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            numericUpDown.Visible = false;
            fictory = new TriangleFictory();
            Button Btn = sender as Button;
            if (Btn != null)
            {
                setColor(this, Btn);
            }
            figureFactory = new TriangleFactory();
            figure = figureFactory.CreateFigure(figure.Painter, figure.FigureController);
            PaintMode = true;
        }

        private void IsoscelesTriangle_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            numericUpDown.Visible = false;
            fictory = new IsoscelesTriangleFictory();
            Button Btn = sender as Button;
            if (Btn != null)
            {
                setColor(this, Btn);
            }
            figureFactory = new IsoscelesTriangleFactory();
            figure = figureFactory.CreateFigure(figure.Painter, figure.FigureController);
            PaintMode = true;
        }

        private void IrregularPolygon_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            numericUpDown.Visible = false;
            fictory = new IrregularPolygonFictory();
            Button Btn = sender as Button;
            if (Btn != null)
            {
                setColor(this, Btn);
            }
            figureFactory = new IrregularPolygonFactory();
            figure = figureFactory.CreateFigure(figure.Painter, figure.FigureController);
            PaintMode = true;
        }

        private void Polygon_Click(object sender, EventArgs e)
        {   
            textBox1.Visible = true;
            numericUpDown.Visible = true;
            fictory = new PolygonFictory();
            Button Btn = sender as Button;
            if (Btn != null)
            {
                setColor(this, Btn);
            }
            figureFactory = new PolygonFactory();
            figure = figureFactory.CreateFigure(figure.Painter, figure.FigureController);
            PaintMode = true;

        }
        private void numericUpDown_TextChanged(object sender, EventArgs e)
        {
            PolygonFigure tmp = (PolygonFigure)figure;
            tmp.N = (int)numericUpDown.Value;
            markup = tmp;
            Button Btn = sender as Button;
            if (Btn != null)
            {
                setColor(this, Btn);
            }
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
            fictory = new RectangleFictory();
            Button Btn = sender as Button;
            if (Btn != null)
            {
                setColor(this, Btn);
            }
            figureFactory = new RectangleFactory();
            figure = figureFactory.CreateFigure(figure.Painter, figure.FigureController);
            PaintMode = true;
            PaintMode = true;
        }

        private void square_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            numericUpDown.Visible = false;
            fictory = new SquareFictory();
            Button Btn = sender as Button;
            if (Btn != null)
            {
                setColor(this, Btn);
            }
            figureFactory = new SquareFactory();
            figure = figureFactory.CreateFigure(figure.Painter, figure.FigureController);
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
            fictory = new RightTriangleFictory();
            Button Btn = sender as Button;
            if (Btn != null)
            {
                setColor(this, Btn);
            }
            figureFactory = new RightTriangleFactory();
            figure = figureFactory.CreateFigure(figure.Painter, figure.FigureController);
            PaintMode = true;
        }

        private void Mover_Click(object sender, EventArgs e)
        {
            toolController = new MoveController();
        }
        private void clear_Click(object sender, EventArgs e)
        {
            canvas.Graphics.Clear(Color.White);           
        }     
          
        private void Width_TextChanged(object sender, EventArgs e)
        {
            pictureBox.Width = Convert.ToInt32(Width.Text);
            SizeLabel.Text = Convert.ToString($"{pictureBox.Width} X {pictureBox.Height}");
        }

        private void Height_TextChanged(object sender, EventArgs e)
        {
            pictureBox.Height = Convert.ToInt32(Height.Text);
            SizeLabel.Text = Convert.ToString($"{pictureBox.Width} X {pictureBox.Height}");
        }

        private void pipette_Click_1(object sender, EventArgs e)
        {
            pip = true;
        }

        private void lupa_Click(object sender, EventArgs e)
        {
             lupaCh = true;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();            
        }

        private void EditorForm_MouseMove(object sender, MouseEventArgs e)
        {            
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void EditorForm_MouseDown(object sender, MouseEventArgs e)
        {            
            lastPoint = new Point(e.X, e.Y);
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}