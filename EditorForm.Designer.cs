
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
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
            this.createLine.Click += new System.EventHandler(this.CreateLine_Click);
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
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
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
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox.Location = new System.Drawing.Point(91, 51);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1034, 597);
            this.pictureBox.TabIndex = 4;
            this.pictureBox.TabStop = false;
            //this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 46);
            this.button1.TabIndex = 5;
            this.button1.Text = "Прямоугольник по двум точкам";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Rectangle_Click);
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
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 272);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(73, 46);
            this.button4.TabIndex = 7;
            this.button4.Text = "Окружность по двум точкам";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Cycle_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 324);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(73, 46);
            this.button5.TabIndex = 8;
            this.button5.Text = "Эллипс по двум точкам";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Elipse_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 376);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(73, 46);
            this.button6.TabIndex = 9;
            this.button6.Text = "Треугольник по трем точкам";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Triangle_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 428);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(73, 64);
            this.button7.TabIndex = 10;
            this.button7.Text = "Прямоугольный треугольник по двум точкам";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.StraightTriangle_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(12, 498);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(73, 46);
            this.button8.TabIndex = 11;
            this.button8.Text = "Равнобедренный (не равносторонний) треугольник по двум точкам";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.IsoscelesTriangle_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(12, 550);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(73, 46);
            this.button9.TabIndex = 12;
            this.button9.Text = "N угольник по N точкам";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.WrongPolygon_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(12, 602);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(73, 46);
            this.button10.TabIndex = 13;
            this.button10.Text = "Правильный N угольник по числу граней и двум точкам";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.Polygon_Click);
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(589, 77);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(61, 20);
            this.textBox2.TabIndex = 15;
            this.textBox2.Visible = false;
            // 
            // EditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 687);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.createLine);
            this.Name = "EditorForm";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

