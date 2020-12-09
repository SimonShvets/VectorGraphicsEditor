
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
            this.createLine = new System.Windows.Forms.Button();
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
            this.clear = new System.Windows.Forms.Button();
            this.pipette = new System.Windows.Forms.Button();
            this.Width = new System.Windows.Forms.TextBox();
            this.Height = new System.Windows.Forms.TextBox();
            this.SizeLabel = new System.Windows.Forms.Label();
            this.lupa = new System.Windows.Forms.Button();
            this.closeWindow = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // createLine
            // 
            this.createLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.createLine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createLine.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.createLine.FlatAppearance.BorderSize = 0;
            this.createLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createLine.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.createLine.Location = new System.Drawing.Point(222, 196);
            this.createLine.Name = "createLine";
            this.createLine.Size = new System.Drawing.Size(38, 51);
            this.createLine.TabIndex = 1;
            this.createLine.Text = "прямая по N точкам";
            this.createLine.UseVisualStyleBackColor = false;
            this.createLine.Click += new System.EventHandler(this.Curve_Click);
            // 
            // Rectangle
            // 
            this.Rectangle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.Rectangle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Rectangle.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Rectangle.FlatAppearance.BorderSize = 0;
            this.Rectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rectangle.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.Rectangle.Location = new System.Drawing.Point(222, 248);
            this.Rectangle.Name = "Rectangle";
            this.Rectangle.Size = new System.Drawing.Size(38, 51);
            this.Rectangle.TabIndex = 5;
            this.Rectangle.Text = "Прямоугольник по двум точкам";
            this.Rectangle.UseVisualStyleBackColor = false;
            this.Rectangle.Click += new System.EventHandler(this.Rectangle_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.button2.Location = new System.Drawing.Point(931, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 46);
            this.button2.TabIndex = 6;
            this.button2.Text = "Hand";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Hand_Click);
            // 
            // Cycle
            // 
            this.Cycle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.Cycle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cycle.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Cycle.FlatAppearance.BorderSize = 0;
            this.Cycle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cycle.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.Cycle.Location = new System.Drawing.Point(222, 300);
            this.Cycle.Name = "Cycle";
            this.Cycle.Size = new System.Drawing.Size(38, 51);
            this.Cycle.TabIndex = 7;
            this.Cycle.Text = "Окружность по двум точкам";
            this.Cycle.UseVisualStyleBackColor = false;
            this.Cycle.Click += new System.EventHandler(this.Circle_Click);
            // 
            // Elipse
            // 
            this.Elipse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.Elipse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Elipse.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Elipse.FlatAppearance.BorderSize = 0;
            this.Elipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Elipse.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.Elipse.Location = new System.Drawing.Point(222, 352);
            this.Elipse.Name = "Elipse";
            this.Elipse.Size = new System.Drawing.Size(38, 51);
            this.Elipse.TabIndex = 8;
            this.Elipse.Text = "Эллипс по двум точкам";
            this.Elipse.UseVisualStyleBackColor = false;
            this.Elipse.Click += new System.EventHandler(this.Ellipse_Click);
            // 
            // Triangle
            // 
            this.Triangle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.Triangle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Triangle.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Triangle.FlatAppearance.BorderSize = 0;
            this.Triangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Triangle.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.Triangle.Location = new System.Drawing.Point(222, 404);
            this.Triangle.Name = "Triangle";
            this.Triangle.Size = new System.Drawing.Size(38, 51);
            this.Triangle.TabIndex = 9;
            this.Triangle.Text = "Треугольник по трем точкам";
            this.Triangle.UseVisualStyleBackColor = false;
            this.Triangle.Click += new System.EventHandler(this.Triangle_Click);
            // 
            // RightTriangle
            // 
            this.RightTriangle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.RightTriangle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RightTriangle.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.RightTriangle.FlatAppearance.BorderSize = 0;
            this.RightTriangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RightTriangle.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.RightTriangle.Location = new System.Drawing.Point(222, 456);
            this.RightTriangle.Name = "RightTriangle";
            this.RightTriangle.Size = new System.Drawing.Size(38, 69);
            this.RightTriangle.TabIndex = 10;
            this.RightTriangle.Text = "Прямоугольный треугольник по двум точкам";
            this.RightTriangle.UseVisualStyleBackColor = false;
            this.RightTriangle.Click += new System.EventHandler(this.RightTriangle_Click);
            // 
            // IsoscelesTriangle
            // 
            this.IsoscelesTriangle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.IsoscelesTriangle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IsoscelesTriangle.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.IsoscelesTriangle.FlatAppearance.BorderSize = 0;
            this.IsoscelesTriangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IsoscelesTriangle.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.IsoscelesTriangle.Location = new System.Drawing.Point(222, 526);
            this.IsoscelesTriangle.Name = "IsoscelesTriangle";
            this.IsoscelesTriangle.Size = new System.Drawing.Size(38, 51);
            this.IsoscelesTriangle.TabIndex = 11;
            this.IsoscelesTriangle.Text = "Равнобедренный (не равносторонний) треугольник по двум точкам";
            this.IsoscelesTriangle.UseVisualStyleBackColor = false;
            this.IsoscelesTriangle.Click += new System.EventHandler(this.IsoscelesTriangle_Click);
            // 
            // WrongPolygon
            // 
            this.WrongPolygon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.WrongPolygon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WrongPolygon.FlatAppearance.BorderSize = 0;
            this.WrongPolygon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WrongPolygon.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.WrongPolygon.Location = new System.Drawing.Point(222, 578);
            this.WrongPolygon.Name = "WrongPolygon";
            this.WrongPolygon.Size = new System.Drawing.Size(38, 51);
            this.WrongPolygon.TabIndex = 12;
            this.WrongPolygon.Text = "N угольник по N точкам";
            this.WrongPolygon.UseVisualStyleBackColor = false;
            this.WrongPolygon.Click += new System.EventHandler(this.IrregularPolygon_Click);
            // 
            // Polygon
            // 
            this.Polygon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.Polygon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Polygon.FlatAppearance.BorderSize = 0;
            this.Polygon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Polygon.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.Polygon.Location = new System.Drawing.Point(222, 630);
            this.Polygon.Name = "Polygon";
            this.Polygon.Size = new System.Drawing.Size(38, 51);
            this.Polygon.TabIndex = 13;
            this.Polygon.Text = "Правильный N угольник по числу граней и двум точкам";
            this.Polygon.UseVisualStyleBackColor = false;
            this.Polygon.Click += new System.EventHandler(this.Polygon_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(742, 114);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(179, 20);
            this.textBox1.TabIndex = 14;
            this.textBox1.Text = "Введите количество углов";
            this.textBox1.Visible = false;
            // 
            // numericUpDown
            // 
            this.numericUpDown.Location = new System.Drawing.Point(772, 140);
            this.numericUpDown.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(121, 20);
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
            this.numericUpDown1.Location = new System.Drawing.Point(1202, 78);
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
            this.textBox2.Location = new System.Drawing.Point(1106, 77);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(90, 20);
            this.textBox2.TabIndex = 18;
            this.textBox2.Text = "Толщина кисти";
            // 
            // square
            // 
            this.square.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.square.Cursor = System.Windows.Forms.Cursors.Hand;
            this.square.FlatAppearance.BorderSize = 0;
            this.square.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.square.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.square.Location = new System.Drawing.Point(222, 87);
            this.square.Name = "square";
            this.square.Size = new System.Drawing.Size(38, 67);
            this.square.TabIndex = 19;
            this.square.Text = "квадрат";
            this.square.UseVisualStyleBackColor = false;
            this.square.Click += new System.EventHandler(this.square_Click);
            // 
            // ChColor
            // 
            this.ChColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.ChColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChColor.FlatAppearance.BorderSize = 0;
            this.ChColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChColor.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.ChColor.Location = new System.Drawing.Point(538, 50);
            this.ChColor.Name = "ChColor";
            this.ChColor.Size = new System.Drawing.Size(124, 20);
            this.ChColor.TabIndex = 20;
            this.ChColor.Text = "Цвет";
            this.ChColor.UseVisualStyleBackColor = false;
            this.ChColor.Click += new System.EventHandler(this.ChColor_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear.FlatAppearance.BorderSize = 0;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.clear.Location = new System.Drawing.Point(671, 50);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(124, 20);
            this.clear.TabIndex = 21;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // pipette
            // 
            this.pipette.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.pipette.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pipette.FlatAppearance.BorderSize = 0;
            this.pipette.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pipette.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.pipette.Location = new System.Drawing.Point(538, 78);
            this.pipette.Name = "pipette";
            this.pipette.Size = new System.Drawing.Size(124, 20);
            this.pipette.TabIndex = 22;
            this.pipette.Text = "Пипетка";
            this.pipette.UseVisualStyleBackColor = false;
            this.pipette.Click += new System.EventHandler(this.pipette_Click_1);
            // 
            // Width
            // 
            this.Width.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(46)))));
            this.Width.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Width.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.Width.Location = new System.Drawing.Point(285, 77);
            this.Width.Name = "Width";
            this.Width.Size = new System.Drawing.Size(100, 20);
            this.Width.TabIndex = 23;
            this.Width.TextChanged += new System.EventHandler(this.Width_TextChanged);
            // 
            // Height
            // 
            this.Height.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(46)))));
            this.Height.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Height.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.Height.Location = new System.Drawing.Point(391, 77);
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(100, 20);
            this.Height.TabIndex = 24;
            this.Height.TextChanged += new System.EventHandler(this.Height_TextChanged);
            // 
            // SizeLabel
            // 
            this.SizeLabel.AutoSize = true;
            this.SizeLabel.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.SizeLabel.Location = new System.Drawing.Point(368, 59);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(35, 13);
            this.SizeLabel.TabIndex = 25;
            this.SizeLabel.Text = "label1";
            // 
            // lupa
            // 
            this.lupa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.lupa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lupa.FlatAppearance.BorderSize = 0;
            this.lupa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lupa.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lupa.Location = new System.Drawing.Point(671, 78);
            this.lupa.Name = "lupa";
            this.lupa.Size = new System.Drawing.Size(124, 20);
            this.lupa.TabIndex = 26;
            this.lupa.Text = "zoom";
            this.lupa.UseVisualStyleBackColor = false;
            this.lupa.Click += new System.EventHandler(this.lupa_Click);
            // 
            // closeWindow
            // 
            this.closeWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.closeWindow.BackgroundImage = global::VectorGraphicsEditor.Properties.Resources.noun_Cross_3244675;
            this.closeWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeWindow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeWindow.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.closeWindow.FlatAppearance.BorderSize = 0;
            this.closeWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeWindow.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.closeWindow.Location = new System.Drawing.Point(1358, 12);
            this.closeWindow.Name = "closeWindow";
            this.closeWindow.Size = new System.Drawing.Size(26, 26);
            this.closeWindow.TabIndex = 27;
            this.closeWindow.UseVisualStyleBackColor = false;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.Location = new System.Drawing.Point(287, 116);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1070, 601);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 4;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDoubleClick);
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.button3.BackgroundImage = global::VectorGraphicsEditor.Properties.Resources.icons8_кисть_96;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.button3.Location = new System.Drawing.Point(109, 182);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(38, 43);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Brush_Click);
            // 
            // EditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1396, 743);
            this.Controls.Add(this.closeWindow);
            this.Controls.Add(this.lupa);
            this.Controls.Add(this.SizeLabel);
            this.Controls.Add(this.Height);
            this.Controls.Add(this.Width);
            this.Controls.Add(this.pipette);
            this.Controls.Add(this.clear);
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
            this.Controls.Add(this.button3);
            this.Controls.Add(this.createLine);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "EditorForm";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EditorForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createLine;
        private System.Windows.Forms.Button button3;
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
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.Button ChColor;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button pipette;
        private System.Windows.Forms.TextBox Width;
        private System.Windows.Forms.TextBox Height;
        private System.Windows.Forms.Label SizeLabel;
        private System.Windows.Forms.Button lupa;
        private System.Windows.Forms.Button closeWindow;
    }
}

