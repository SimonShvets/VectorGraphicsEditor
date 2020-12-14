
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.Width = new System.Windows.Forms.TextBox();
            this.Height = new System.Windows.Forms.TextBox();
            this.SizeLabel = new System.Windows.Forms.Label();
            this.square = new System.Windows.Forms.Button();
            this.Elipse = new System.Windows.Forms.Button();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.Cycle = new System.Windows.Forms.Button();
            this.Max = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.lupa = new System.Windows.Forms.Button();
            this.pipette = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.ChColor = new System.Windows.Forms.Button();
            this.Polygon = new System.Windows.Forms.Button();
            this.WrongPolygon = new System.Windows.Forms.Button();
            this.IsoscelesTriangle = new System.Windows.Forms.Button();
            this.RightTriangle = new System.Windows.Forms.Button();
            this.Triangle = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Rectangle = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.brush = new System.Windows.Forms.Button();
            this.createLine = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.minusLupa = new System.Windows.Forms.Button();
            this.WindowButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(568, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(179, 20);
            this.textBox1.TabIndex = 14;
            this.textBox1.Text = "Введите количество углов";
            this.textBox1.Visible = false;
            // 
            // numericUpDown
            // 
            this.numericUpDown.Location = new System.Drawing.Point(598, 87);
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
            this.numericUpDown1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(46)))));
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.numericUpDown1.Location = new System.Drawing.Point(28, 305);
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
            this.numericUpDown1.Size = new System.Drawing.Size(56, 20);
            this.numericUpDown1.TabIndex = 17;
            this.numericUpDown1.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // Width
            // 
            this.Width.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(46)))));
            this.Width.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Width.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.Width.Location = new System.Drawing.Point(25, 342);
            this.Width.Name = "Width";
            this.Width.Size = new System.Drawing.Size(59, 20);
            this.Width.TabIndex = 23;
            this.Width.TextChanged += new System.EventHandler(this.Width_TextChanged);
            this.Width.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Width_KeyPress);
            // 
            // Height
            // 
            this.Height.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(46)))));
            this.Height.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Height.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.Height.Location = new System.Drawing.Point(25, 368);
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(59, 20);
            this.Height.TabIndex = 24;
            this.Height.TextChanged += new System.EventHandler(this.Height_TextChanged);
            this.Height.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Height_KeyPress);
            // 
            // SizeLabel
            // 
            this.SizeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SizeLabel.AutoSize = true;
            this.SizeLabel.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.SizeLabel.Location = new System.Drawing.Point(8, 721);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(35, 13);
            this.SizeLabel.TabIndex = 25;
            this.SizeLabel.Text = "label1";
            // 
            // square
            // 
            this.square.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.square.BackgroundImage = global::VectorGraphicsEditor.Properties.Resources.noun_Rectangle_Tool_646339;
            this.square.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.square.Cursor = System.Windows.Forms.Cursors.Hand;
            this.square.FlatAppearance.BorderSize = 0;
            this.square.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.square.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.square.Location = new System.Drawing.Point(62, 250);
            this.square.Name = "square";
            this.square.Size = new System.Drawing.Size(45, 34);
            this.square.TabIndex = 19;
            this.square.UseVisualStyleBackColor = false;
            this.square.Click += new System.EventHandler(this.square_Click);
            // 
            // Elipse
            // 
            this.Elipse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.Elipse.BackgroundImage = global::VectorGraphicsEditor.Properties.Resources.ellipse1;
            this.Elipse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Elipse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Elipse.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Elipse.FlatAppearance.BorderSize = 0;
            this.Elipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Elipse.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.Elipse.Location = new System.Drawing.Point(11, 131);
            this.Elipse.Name = "Elipse";
            this.Elipse.Size = new System.Drawing.Size(45, 34);
            this.Elipse.TabIndex = 8;
            this.Elipse.UseVisualStyleBackColor = false;
            this.Elipse.Click += new System.EventHandler(this.Ellipse_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.minimizeButton.BackgroundImage = global::VectorGraphicsEditor.Properties.Resources.noun_Minus_3244686;
            this.minimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.minimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.minimizeButton.Location = new System.Drawing.Point(1185, 1);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(42, 34);
            this.minimizeButton.TabIndex = 29;
            this.minimizeButton.UseVisualStyleBackColor = false;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // Cycle
            // 
            this.Cycle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.Cycle.BackgroundImage = global::VectorGraphicsEditor.Properties.Resources.noun_Circle_22564161;
            this.Cycle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Cycle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cycle.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Cycle.FlatAppearance.BorderSize = 0;
            this.Cycle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cycle.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.Cycle.Location = new System.Drawing.Point(62, 130);
            this.Cycle.Name = "Cycle";
            this.Cycle.Size = new System.Drawing.Size(45, 34);
            this.Cycle.TabIndex = 7;
            this.Cycle.UseVisualStyleBackColor = false;
            this.Cycle.Click += new System.EventHandler(this.Circle_Click);
            // 
            // Max
            // 
            this.Max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Max.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Max.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.Max.BackgroundImage = global::VectorGraphicsEditor.Properties.Resources.window2;
            this.Max.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Max.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Max.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Max.FlatAppearance.BorderSize = 0;
            this.Max.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Max.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.Max.Location = new System.Drawing.Point(1233, 1);
            this.Max.Name = "Max";
            this.Max.Size = new System.Drawing.Size(42, 34);
            this.Max.TabIndex = 28;
            this.Max.UseVisualStyleBackColor = false;
            this.Max.Click += new System.EventHandler(this.Max_Click);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.closeButton.BackgroundImage = global::VectorGraphicsEditor.Properties.Resources.close;
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.closeButton.Location = new System.Drawing.Point(1281, 1);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(42, 34);
            this.closeButton.TabIndex = 27;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // lupa
            // 
            this.lupa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.lupa.BackgroundImage = global::VectorGraphicsEditor.Properties.Resources.noun_magnifier_33571371;
            this.lupa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.lupa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lupa.FlatAppearance.BorderSize = 0;
            this.lupa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lupa.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lupa.Location = new System.Drawing.Point(335, 23);
            this.lupa.Name = "lupa";
            this.lupa.Size = new System.Drawing.Size(45, 34);
            this.lupa.TabIndex = 26;
            this.lupa.UseVisualStyleBackColor = false;
            this.lupa.Click += new System.EventHandler(this.lupa_Click);
            // 
            // pipette
            // 
            this.pipette.BackgroundImage = global::VectorGraphicsEditor.Properties.Resources.noun_pipette_32417002;
            this.pipette.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pipette.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pipette.FlatAppearance.BorderSize = 0;
            this.pipette.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pipette.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.pipette.Location = new System.Drawing.Point(260, 23);
            this.pipette.Name = "pipette";
            this.pipette.Size = new System.Drawing.Size(45, 34);
            this.pipette.TabIndex = 22;
            this.pipette.UseVisualStyleBackColor = false;
            this.pipette.Click += new System.EventHandler(this.pipette_Click_1);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.clear.BackgroundImage = global::VectorGraphicsEditor.Properties.Resources.noun_Delete_2785496;
            this.clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear.FlatAppearance.BorderSize = 0;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.clear.Location = new System.Drawing.Point(209, 23);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(45, 34);
            this.clear.TabIndex = 21;
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // ChColor
            // 
            this.ChColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.ChColor.BackgroundImage = global::VectorGraphicsEditor.Properties.Resources.noun_palette_3647420;
            this.ChColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ChColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChColor.FlatAppearance.BorderSize = 0;
            this.ChColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChColor.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.ChColor.Location = new System.Drawing.Point(158, 23);
            this.ChColor.Name = "ChColor";
            this.ChColor.Size = new System.Drawing.Size(45, 34);
            this.ChColor.TabIndex = 20;
            this.ChColor.UseVisualStyleBackColor = false;
            this.ChColor.Click += new System.EventHandler(this.ChColor_Click);
            // 
            // Polygon
            // 
            this.Polygon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.Polygon.BackgroundImage = global::VectorGraphicsEditor.Properties.Resources.noun_Polygon_Tool_6463381;
            this.Polygon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Polygon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Polygon.FlatAppearance.BorderSize = 0;
            this.Polygon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Polygon.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.Polygon.Location = new System.Drawing.Point(11, 250);
            this.Polygon.Name = "Polygon";
            this.Polygon.Size = new System.Drawing.Size(45, 34);
            this.Polygon.TabIndex = 13;
            this.Polygon.UseVisualStyleBackColor = false;
            this.Polygon.Click += new System.EventHandler(this.Polygon_Click);
            // 
            // WrongPolygon
            // 
            this.WrongPolygon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.WrongPolygon.BackgroundImage = global::VectorGraphicsEditor.Properties.Resources.noun_Polygonal_Lasso_2700180;
            this.WrongPolygon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.WrongPolygon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WrongPolygon.FlatAppearance.BorderSize = 0;
            this.WrongPolygon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WrongPolygon.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.WrongPolygon.Location = new System.Drawing.Point(62, 210);
            this.WrongPolygon.Name = "WrongPolygon";
            this.WrongPolygon.Size = new System.Drawing.Size(45, 34);
            this.WrongPolygon.TabIndex = 12;
            this.WrongPolygon.UseVisualStyleBackColor = false;
            this.WrongPolygon.Click += new System.EventHandler(this.IrregularPolygon_Click);
            // 
            // IsoscelesTriangle
            // 
            this.IsoscelesTriangle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.IsoscelesTriangle.BackgroundImage = global::VectorGraphicsEditor.Properties.Resources.noun_triangle_2256414;
            this.IsoscelesTriangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.IsoscelesTriangle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IsoscelesTriangle.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.IsoscelesTriangle.FlatAppearance.BorderSize = 0;
            this.IsoscelesTriangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IsoscelesTriangle.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.IsoscelesTriangle.Location = new System.Drawing.Point(11, 210);
            this.IsoscelesTriangle.Name = "IsoscelesTriangle";
            this.IsoscelesTriangle.Size = new System.Drawing.Size(45, 34);
            this.IsoscelesTriangle.TabIndex = 11;
            this.IsoscelesTriangle.UseVisualStyleBackColor = false;
            this.IsoscelesTriangle.Click += new System.EventHandler(this.IsoscelesTriangle_Click);
            // 
            // RightTriangle
            // 
            this.RightTriangle.BackgroundImage = global::VectorGraphicsEditor.Properties.Resources.noun_Right_triangle_22336803;
            this.RightTriangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RightTriangle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RightTriangle.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.RightTriangle.FlatAppearance.BorderSize = 0;
            this.RightTriangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RightTriangle.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.RightTriangle.Location = new System.Drawing.Point(62, 170);
            this.RightTriangle.Name = "RightTriangle";
            this.RightTriangle.Size = new System.Drawing.Size(45, 34);
            this.RightTriangle.TabIndex = 10;
            this.RightTriangle.UseVisualStyleBackColor = false;
            this.RightTriangle.Click += new System.EventHandler(this.RightTriangle_Click);
            // 
            // Triangle
            // 
            this.Triangle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.Triangle.BackgroundImage = global::VectorGraphicsEditor.Properties.Resources.trianglePoints2;
            this.Triangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Triangle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Triangle.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Triangle.FlatAppearance.BorderSize = 0;
            this.Triangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Triangle.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.Triangle.Location = new System.Drawing.Point(11, 170);
            this.Triangle.Name = "Triangle";
            this.Triangle.Size = new System.Drawing.Size(45, 34);
            this.Triangle.TabIndex = 9;
            this.Triangle.UseVisualStyleBackColor = false;
            this.Triangle.Click += new System.EventHandler(this.Triangle_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.button2.BackgroundImage = global::VectorGraphicsEditor.Properties.Resources.noun_Cursor_7995341;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.button2.Location = new System.Drawing.Point(11, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 34);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Hand_Click);
            // 
            // Rectangle
            // 
            this.Rectangle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.Rectangle.BackgroundImage = global::VectorGraphicsEditor.Properties.Resources.rectangle;
            this.Rectangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Rectangle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Rectangle.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Rectangle.FlatAppearance.BorderSize = 0;
            this.Rectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rectangle.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.Rectangle.Location = new System.Drawing.Point(62, 90);
            this.Rectangle.Name = "Rectangle";
            this.Rectangle.Size = new System.Drawing.Size(45, 34);
            this.Rectangle.TabIndex = 5;
            this.Rectangle.UseVisualStyleBackColor = false;
            this.Rectangle.Click += new System.EventHandler(this.Rectangle_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.Location = new System.Drawing.Point(113, 63);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1149, 612);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 4;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDoubleClick);
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // brush
            // 
            this.brush.BackgroundImage = global::VectorGraphicsEditor.Properties.Resources.noun_Brush_6460592;
            this.brush.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.brush.Cursor = System.Windows.Forms.Cursors.Hand;
            this.brush.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.brush.FlatAppearance.BorderSize = 0;
            this.brush.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brush.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.brush.Location = new System.Drawing.Point(62, 53);
            this.brush.Name = "brush";
            this.brush.Size = new System.Drawing.Size(45, 34);
            this.brush.TabIndex = 2;
            this.brush.UseVisualStyleBackColor = false;
            this.brush.Click += new System.EventHandler(this.Brush_Click);
            // 
            // createLine
            // 
            this.createLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.createLine.BackgroundImage = global::VectorGraphicsEditor.Properties.Resources.noun_line_chart_626979;
            this.createLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.createLine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createLine.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.createLine.FlatAppearance.BorderSize = 0;
            this.createLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createLine.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.createLine.Location = new System.Drawing.Point(11, 90);
            this.createLine.Name = "createLine";
            this.createLine.Size = new System.Drawing.Size(45, 34);
            this.createLine.TabIndex = 1;
            this.createLine.UseVisualStyleBackColor = false;
            this.createLine.Click += new System.EventHandler(this.Curve_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 1);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(56, 24);
            this.menuStrip1.TabIndex = 30;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.toolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(48, 20);
            this.toolStripMenuItem1.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.сохранитьToolStripMenuItem.Text = "Save";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Location = new System.Drawing.Point(15, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Толщина кисти";
            // 
            // minusLupa
            // 
            this.minusLupa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.minusLupa.BackgroundImage = global::VectorGraphicsEditor.Properties.Resources.noun_magnifier_33571371;
            this.minusLupa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.minusLupa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minusLupa.FlatAppearance.BorderSize = 0;
            this.minusLupa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minusLupa.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.minusLupa.Location = new System.Drawing.Point(414, 23);
            this.minusLupa.Name = "minusLupa";
            this.minusLupa.Size = new System.Drawing.Size(45, 34);
            this.minusLupa.TabIndex = 32;
            this.minusLupa.UseVisualStyleBackColor = false;
            this.minusLupa.Click += new System.EventHandler(this.minusLupa_Click);
            // 
            // WindowButton
            // 
            this.WindowButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.WindowButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.WindowButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.WindowButton.BackgroundImage = global::VectorGraphicsEditor.Properties.Resources.noun_copy_32446742;
            this.WindowButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.WindowButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WindowButton.Enabled = false;
            this.WindowButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.WindowButton.FlatAppearance.BorderSize = 0;
            this.WindowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WindowButton.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.WindowButton.Location = new System.Drawing.Point(1233, 1);
            this.WindowButton.Name = "WindowButton";
            this.WindowButton.Size = new System.Drawing.Size(42, 34);
            this.WindowButton.TabIndex = 33;
            this.WindowButton.UseVisualStyleBackColor = false;
            this.WindowButton.Visible = false;
            this.WindowButton.Click += new System.EventHandler(this.WindowButton_Click);
            // 
            // EditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1324, 743);
            this.Controls.Add(this.WindowButton);
            this.Controls.Add(this.minusLupa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Elipse);
            this.Controls.Add(this.Cycle);
            this.Controls.Add(this.square);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.Max);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.lupa);
            this.Controls.Add(this.SizeLabel);
            this.Controls.Add(this.Height);
            this.Controls.Add(this.Width);
            this.Controls.Add(this.pipette);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.ChColor);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Polygon);
            this.Controls.Add(this.WrongPolygon);
            this.Controls.Add(this.IsoscelesTriangle);
            this.Controls.Add(this.RightTriangle);
            this.Controls.Add(this.Triangle);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Rectangle);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.brush);
            this.Controls.Add(this.createLine);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EditorForm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EditorForm_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EditorForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.EditorForm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createLine;
        private System.Windows.Forms.Button brush;
        private System.Windows.Forms.Button Rectangle;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Triangle;
        private System.Windows.Forms.Button RightTriangle;
        private System.Windows.Forms.Button IsoscelesTriangle;
        private System.Windows.Forms.Button WrongPolygon;
        private System.Windows.Forms.Button Polygon;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button square;
        private System.Windows.Forms.Button ChColor;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button pipette;
        private System.Windows.Forms.TextBox Width;
        private System.Windows.Forms.TextBox Height;
        private System.Windows.Forms.Label SizeLabel;
        private System.Windows.Forms.Button lupa;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button Max;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Button Elipse;
        private System.Windows.Forms.Button Cycle;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button minusLupa;
        private System.Windows.Forms.Button WindowButton;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
    }
}

