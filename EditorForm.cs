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
        bool pip = false;
        Size StartSize;
       // double zoom = 1.25;
        bool lupaCh = false;


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
            painter = new BrushPainter();
            markup = new BrushMarkUp();
            fictory = new BrushFictory();
            painters = new List<IPainter>();
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
            {
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
            if (markup is PolygonMarkUp)
            {
                PolygonMarkUp tmp = (PolygonMarkUp)markup;
                tmp.N = (int)numericUpDown.Value;
                markup = tmp;
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
    }
}