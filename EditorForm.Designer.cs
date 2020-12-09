
namespace VectorGraphicsEditor
{
    partial class EditorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditorForm));
            this.createLine = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.Rectangle = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Cycle = new System.Windows.Forms.Button();
            this.Elipse = new System.Windows.Forms.Button();
            this.Triangle = new System.Windows.Forms.Button();
            this.RightTriangle = new System.Windows.Forms.Button();
            this.IsoscelesTriangle = new System.Windows.Forms.Button();
            this.WrongPolygon = new System.Windows.Forms.Button();
            this.Polygon = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.square = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.ChColor = new System.Windows.Forms.Button();
            this.Mover = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // createLine
            // 
            this.createLine.Cursor = System.Windows.Forms.Cursors.Default;
            this.createLine.Location = new System.Drawing.Point(12, 168);
            this.createLine.Name = "createLine";
            this.createLine.Size = new System.Drawing.Size(73, 46);
            this.createLine.TabIndex = 1;
            this.createLine.Text = "прямая по N точкам";
            this.createLine.UseVisualStyleBackColor = true;
            this.createLine.Click += new System.EventHandler(this.Curve_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 116);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(73, 46);
            this.button3.TabIndex = 2;
            this.button3.Text = "кисть";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Brush_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Ivory;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1164, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "toolStripButton4";
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox.Location = new System.Drawing.Point(91, 53);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1034, 597);
            this.pictureBox.TabIndex = 4;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDoubleClick);
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // Rectangle
            // 
            this.Rectangle.Location = new System.Drawing.Point(12, 220);
            this.Rectangle.Name = "Rectangle";
            this.Rectangle.Size = new System.Drawing.Size(73, 46);
            this.Rectangle.TabIndex = 5;
            this.Rectangle.Text = "Прямоугольник по двум точкам";
            this.Rectangle.UseVisualStyleBackColor = true;
            this.Rectangle.Click += new System.EventHandler(this.Rectangle_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 64);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 46);
            this.button2.TabIndex = 6;
            this.button2.Text = "Hand";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Hand_Click);
            // 
            // Cycle
            // 
            this.Cycle.Location = new System.Drawing.Point(12, 272);
            this.Cycle.Name = "Cycle";
            this.Cycle.Size = new System.Drawing.Size(73, 46);
            this.Cycle.TabIndex = 7;
            this.Cycle.Text = "Окружность по двум точкам";
            this.Cycle.UseVisualStyleBackColor = true;
            this.Cycle.Click += new System.EventHandler(this.Circle_Click);
            // 
            // Elipse
            // 
            this.Elipse.Location = new System.Drawing.Point(12, 324);
            this.Elipse.Name = "Elipse";
            this.Elipse.Size = new System.Drawing.Size(73, 46);
            this.Elipse.TabIndex = 8;
            this.Elipse.Text = "Эллипс по двум точкам";
            this.Elipse.UseVisualStyleBackColor = true;
            this.Elipse.Click += new System.EventHandler(this.Ellipse_Click);
            // 
            // Triangle
            // 
            this.Triangle.Location = new System.Drawing.Point(12, 376);
            this.Triangle.Name = "Triangle";
            this.Triangle.Size = new System.Drawing.Size(73, 46);
            this.Triangle.TabIndex = 9;
            this.Triangle.Text = "Треугольник по трем точкам";
            this.Triangle.UseVisualStyleBackColor = true;
            this.Triangle.Click += new System.EventHandler(this.Triangle_Click);
            // 
            // RightTriangle
            // 
            this.RightTriangle.Location = new System.Drawing.Point(12, 428);
            this.RightTriangle.Name = "RightTriangle";
            this.RightTriangle.Size = new System.Drawing.Size(73, 64);
            this.RightTriangle.TabIndex = 10;
            this.RightTriangle.Text = "Прямоугольный треугольник по двум точкам";
            this.RightTriangle.UseVisualStyleBackColor = true;
            this.RightTriangle.Click += new System.EventHandler(this.RightTriangle_Click);
            // 
            // IsoscelesTriangle
            // 
            this.IsoscelesTriangle.Location = new System.Drawing.Point(12, 498);
            this.IsoscelesTriangle.Name = "IsoscelesTriangle";
            this.IsoscelesTriangle.Size = new System.Drawing.Size(73, 46);
            this.IsoscelesTriangle.TabIndex = 11;
            this.IsoscelesTriangle.Text = "Равнобедренный (не равносторонний) треугольник по двум точкам";
            this.IsoscelesTriangle.UseVisualStyleBackColor = true;
            this.IsoscelesTriangle.Click += new System.EventHandler(this.IsoscelesTriangle_Click);
            // 
            // WrongPolygon
            // 
            this.WrongPolygon.Location = new System.Drawing.Point(12, 550);
            this.WrongPolygon.Name = "WrongPolygon";
            this.WrongPolygon.Size = new System.Drawing.Size(73, 46);
            this.WrongPolygon.TabIndex = 12;
            this.WrongPolygon.Text = "N угольник по N точкам";
            this.WrongPolygon.UseVisualStyleBackColor = true;
            this.WrongPolygon.Click += new System.EventHandler(this.IrregularPolygon_Click);
            // 
            // Polygon
            // 
            this.Polygon.Location = new System.Drawing.Point(12, 602);
            this.Polygon.Name = "Polygon";
            this.Polygon.Size = new System.Drawing.Size(73, 46);
            this.Polygon.TabIndex = 13;
            this.Polygon.Text = "Правильный N угольник по числу граней и двум точкам";
            this.Polygon.UseVisualStyleBackColor = true;
            this.Polygon.Click += new System.EventHandler(this.Polygon_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(546, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(143, 20);
            this.textBox1.TabIndex = 14;
            this.textBox1.Text = "Введите количество углов";
            this.textBox1.Visible = false;
            // 
            // numericUpDown
            // 
            this.numericUpDown.Location = new System.Drawing.Point(576, 77);
            this.numericUpDown.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(85, 20);
            this.numericUpDown.TabIndex = 16;
            this.numericUpDown.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown.Visible = false;
            this.numericUpDown.ValueChanged += new System.EventHandler(this.numericUpDown_TextChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(1077, 28);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(46, 20);
            this.numericUpDown1.TabIndex = 17;
            this.numericUpDown1.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(983, 27);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(90, 20);
            this.textBox2.TabIndex = 18;
            this.textBox2.Text = "Толщина кисти";
            // 
            // square
            // 
            this.square.Location = new System.Drawing.Point(12, 28);
            this.square.Name = "square";
            this.square.Size = new System.Drawing.Size(46, 31);
            this.square.TabIndex = 19;
            this.square.Text = "квадрат";
            this.square.UseVisualStyleBackColor = true;
            this.square.Click += new System.EventHandler(this.square_Click);
            // 
            // ChColor
            // 
            this.ChColor.Location = new System.Drawing.Point(793, 28);
            this.ChColor.Name = "ChColor";
            this.ChColor.Size = new System.Drawing.Size(124, 20);
            this.ChColor.TabIndex = 20;
            this.ChColor.Text = "Цвет";
            this.ChColor.UseVisualStyleBackColor = true;
            this.ChColor.Click += new System.EventHandler(this.ChColor_Click);
            // 
            // Mover
            // 
            this.Mover.Location = new System.Drawing.Point(159, 27);
            this.Mover.Name = "Mover";
            this.Mover.Size = new System.Drawing.Size(75, 23);
            this.Mover.TabIndex = 21;
            this.Mover.Text = "Mover";
            this.Mover.UseVisualStyleBackColor = true;
            this.Mover.Click += new System.EventHandler(this.Mover_Click);
            // 
            // EditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1164, 687);
            this.Controls.Add(this.Mover);
            this.Controls.Add(this.ChColor);
            this.Controls.Add(this.square);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Polygon);
            this.Controls.Add(this.WrongPolygon);
            this.Controls.Add(this.IsoscelesTriangle);
            this.Controls.Add(this.RightTriangle);
            this.Controls.Add(this.Triangle);
            this.Controls.Add(this.Elipse);
            this.Controls.Add(this.Cycle);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Rectangle);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.createLine);
            this.KeyPreview = true;
            this.Name = "EditorForm";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EditorForm_KeyDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createLine;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button Rectangle;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Cycle;
        private System.Windows.Forms.Button Elipse;
        private System.Windows.Forms.Button Triangle;
        private System.Windows.Forms.Button RightTriangle;
        private System.Windows.Forms.Button IsoscelesTriangle;
        private System.Windows.Forms.Button WrongPolygon;
        private System.Windows.Forms.Button Polygon;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button square;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.Button ChColor;
        private System.Windows.Forms.Button Mover;
    }
}

