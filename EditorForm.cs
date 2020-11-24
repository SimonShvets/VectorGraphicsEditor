using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VectorGraphicsEditor
{
    public partial class EditorForm : Form
    {
        Bitmap mainBitmap;
        Graphics graphics;
        Pen pen;
        Image image;
        Point point;
        bool mouseDown;


        public EditorForm()
        {
            InitializeComponent();
        }

        private void EditorForm_Load(object sender, EventArgs e)
        {
            mainBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(mainBitmap);
            pen = new Pen(Color.Black, 10);
            pictureBox1.Image = mainBitmap;
            point = new Point(0, 0);
            mouseDown = false;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            point = e.Location;
            mouseDown = true;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                graphics.DrawLine(pen, point, e.Location);
                pictureBox1.Image = mainBitmap;
                point = e.Location;
            }

        }
        private void pictureBox1_MouseMove1(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                graphics.DrawLine(pen, point, e.Location);
                pictureBox1.Image = mainBitmap;
                point = e.Location;
            }

        }
        private void pictureBox1_MouseMove2(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                graphics.DrawLine(pen, point, e.Location);
                pictureBox1.Image = mainBitmap;
                point = e.Location;
            }

        }


        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void createLine_Click(object sender, EventArgs e)
        {
            pictureBox1.Cursor = Cursors.Cross;
        }
    }
}
