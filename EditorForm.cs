using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
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
        Size StartSize;      
        Point lastPoint;      
        Container container;
        AbstractFigure figure;
        AbstractTool tool;
        IToolController toolController;
        IFigureFactory figureFactory;
        IToolFactory toolFactory;
        bool PaintMode;
        Metafile metafile;
        public EditorForm()
        {
            InitializeComponent();
            SizeLabel.Text = Convert.ToString($"{pictureBox.Width} X {pictureBox.Height}");
            canvas = new Canvas(pictureBox.Width, pictureBox.Height);
            canvas.PictureBox = pictureBox;
            canvas.TmpBitmap = (Bitmap)canvas.MainBitmap.Clone();
            canvas.Graphics = Graphics.FromImage(canvas.TmpBitmap);
            pictureBox.Image = canvas.MainBitmap;
            pen = new Pen(Color.Black, (int)numericUpDown1.Value);            
            pen.StartCap = LineCap.Round;
            pen.EndCap = LineCap.Round;
            figure = new BrushFigure(new BrushController());
            toolController = new HandController();
            figureFactory = new BrushFactory();
            tool = new HandTool(new HandSelector());            
            container = new Container();     
            
        }
        public void SetImage(string path)
        {
            Bitmap b1 = new Bitmap(path);
            Bitmap b2 = new Bitmap(b1, new Size(pictureBox.Width, pictureBox.Height));
            pictureBox.Image = (Image)new Bitmap(b2);
        }

        private void Editor_SizeChanged(object sender, EventArgs e)
        {
            if (pictureBox.Image != null)
            {
                Bitmap b1 = new Bitmap(pictureBox.Image);
                Bitmap b2 = new Bitmap(b1, new Size(pictureBox.Width, pictureBox.Height));
                pictureBox.Image = (Image)new Bitmap(b2);
            }
        }

        private Metafile MakeMetafile(float width, float height, string filename)
        {
            using (Bitmap bm = new Bitmap(16, 16))
            {
                using (Graphics gr = Graphics.FromImage(bm))
                {
                    RectangleF bounds = new RectangleF(0, 0, width, height);
                    Metafile mf;
                    if(filename != null && filename.Length > 0)
                    {
                        mf = new Metafile(filename, gr.GetHdc(), bounds, MetafileFrameUnit.Pixel);
                    }
                    else
                        mf = new Metafile(gr.GetHdc(), bounds,
                   MetafileFrameUnit.Pixel);

                    gr.ReleaseHdc();
                    return mf;
                }
            }
        }

        private void DrawOnMetafile(Metafile mf)
        {

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
            pictureBox.Image = canvas.TmpBitmap;
            
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
            Button Btn = sender as Button;
            if (Btn != null)
            {
                setColor(this, Btn);
            }
            toolFactory = new HandFactory();
            tool = toolFactory.CreateTool(tool.Selector);
            PaintMode = false;
        }
        private void pipette_Click_1(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            numericUpDown.Visible = false;
            Button Btn = sender as Button;
            if (Btn != null)
            {
                setColor(this, Btn);
            }
            toolController = new PipetteController();            
            tool = new Pipette(new PipetteSelector());
            toolFactory = new PipetteFactory();            
            tool = toolFactory.CreateTool(tool.Selector);            
            PaintMode = false;
        }

        private void lupa_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            numericUpDown.Visible = false;
            Button Btn = sender as Button;
            if (Btn != null)
            {
                setColor(this, Btn);
            }
            toolController = new LensController();
            tool = new Lens(new LensSelector());
            toolFactory = new LensFactory();
            tool = toolFactory.CreateTool(tool.Selector);
            PaintMode = false;
        }
        private void minusLupa_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            numericUpDown.Visible = false;
            Button Btn = sender as Button;
            if (Btn != null)
            {
                setColor(this, Btn);
            }
            toolController = new MinusLensController();
            tool = new MinusLens(new MinusLensSelector());
            toolFactory = new MinusLensFactory();
            tool = toolFactory.CreateTool(tool.Selector);
            PaintMode = false;
        }
        private void clear_Click(object sender, EventArgs e)
        {
            canvas.CreateLayer();
            canvas.SaveLayer();
            canvas.Graphics.Clear(Color.White);
            container.Clear();
        }
        private void Fill_Click(object sender, EventArgs e)
        {
            Button Btn = sender as Button;
            if (Btn != null)
            {
                setColor(this, Btn);
            }
        }

        private void Brush_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            numericUpDown.Visible = false;
            figureFactory = new BrushFactory();
            figure = figureFactory.CreateFigure(figure.FigureController);            
            PaintMode = true;
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
            figureFactory = new CurveFactory();
            figure = figureFactory.CreateFigure(figure.FigureController);
            PaintMode = true;
            Button Btn = sender as Button;
            if (Btn != null)
            {
                setColor(this, Btn);
            }
        }   
            
        

        private void Circle_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            numericUpDown.Visible = false;            
            Button Btn = sender as Button;
            if (Btn != null)
            {
                setColor(this, Btn);                
            }
            
            figureFactory = new CircleFactory();
            figure = figureFactory.CreateFigure(figure.FigureController);
            PaintMode = true;
        }

        private void Ellipse_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            numericUpDown.Visible = false;          
            Button Btn = sender as Button;
            if(Btn != null)
            {
                setColor(this, Btn);
                
            }
            

            figureFactory = new ElipseFactory();
            figure = figureFactory.CreateFigure(figure.FigureController);
            PaintMode = true;
        }

        private void Triangle_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            numericUpDown.Visible = false;            
            Button Btn = sender as Button;
            if (Btn != null)
            {
                setColor(this, Btn);
            }
            figureFactory = new TriangleFactory();
            figure = figureFactory.CreateFigure(figure.FigureController);
            PaintMode = true;
        }

        private void IsoscelesTriangle_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            numericUpDown.Visible = false;           
            Button Btn = sender as Button;
            if (Btn != null)
            {
                setColor(this, Btn);
            }
            figureFactory = new IsoscelesTriangleFactory();
            figure = figureFactory.CreateFigure(figure.FigureController);
            PaintMode = true;
        }

        private void IrregularPolygon_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            numericUpDown.Visible = false;           
            Button Btn = sender as Button;
            if (Btn != null)
            {
                setColor(this, Btn);
            }
            figureFactory = new IrregularPolygonFactory();
            figure = figureFactory.CreateFigure(figure.FigureController);
            PaintMode = true;
        }

        private void Polygon_Click(object sender, EventArgs e)
        {   
            textBox1.Visible = true;
            numericUpDown.Visible = true;          
            Button Btn = sender as Button;
            if (Btn != null)
            {
                setColor(this, Btn);
            }
            figureFactory = new PolygonFactory();
            figure = figureFactory.CreateFigure(figure.FigureController);
            PaintMode = true;

        }
        private void numericUpDown_TextChanged(object sender, EventArgs e)
        {
            PolygonFigure tmp = (PolygonFigure)figure;
            tmp.N = (int)numericUpDown.Value;            
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
            Button Btn = sender as Button;
            if (Btn != null)
            {
                setColor(this, Btn);
            }
            figureFactory = new RectangleFactory();
            figure = figureFactory.CreateFigure(figure.FigureController);
            PaintMode = true;
            PaintMode = true;
        }

        private void square_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            numericUpDown.Visible = false;           
            Button Btn = sender as Button;
            if (Btn != null)
            {
                setColor(this, Btn);
            }
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
            Button Btn = sender as Button;
            if (Btn != null)
            {
                setColor(this, Btn);
            }
            figureFactory = new RightTriangleFactory();
            figure = figureFactory.CreateFigure(figure.FigureController);
            PaintMode = true;
        }
        private void Width_TextChanged(object sender, EventArgs e)
        {
            if (Width.Text.Length < 1)
            {
                Width.Text = Convert.ToString(100);
            }            
            pictureBox.Width = Convert.ToInt32(Width.Text);
            SizeLabel.Text = Convert.ToString($"{pictureBox.Width} X {pictureBox.Height}");

        }
        private void Width_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void Height_TextChanged(object sender, EventArgs e)
        {            
            if (Height.Text.Length < 1)
            {
                Height.Text = Convert.ToString(100);
            }
            pictureBox.Height = Convert.ToInt32(Height.Text);
            SizeLabel.Text = Convert.ToString($"{pictureBox.Width} X {pictureBox.Height}");
            
        }
        private void Height_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
            
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

        private void Max_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowButton.Visible = true;
                this.WindowButton.Enabled = true;
            }

        }

        private void WindowButton_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowButton.Visible = false;
                this.WindowButton.Enabled = false;
            }           
            this.WindowState = FormWindowState.Normal;
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(pictureBox.Image != null)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "сохранить как";
                sfd.OverwritePrompt = true;
                sfd.CheckPathExists = true;
                sfd.Filter = "Image Files(*.BMP)|*.BMP | Image Files(*.JPG)|*.JPG| Image Files(*.PNG)|*.PNG| Image Files(*.ico)|*.ico";
                sfd.ShowHelp = true;

                if(sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        pictureBox.Image.Save(sfd.FileName);
                    }
                    catch
                    {
                        MessageBox.Show("Невозможно сохранить", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.BMP)|*.BMP | Image Files(*.JPG)|*.JPG| Image Files(*.PNG)|*.PNG| Image Files(*.ico)|*.ico";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    canvas.TmpBitmap = new Bitmap(ofd.FileName);
                }
                catch
                {
                    MessageBox.Show("Невозможно открыть", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        
    }
}