using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using VectorGraphicsEditor.Figure;
using VectorGraphicsEditor.Tools;

namespace VectorGraphicsEditor
{
    public class Frame
    {
        Pen pen = new Pen(Color.Black, 1);
        public RectangleF FrameRectanle { get; set; }
        public List<Rectangle> Vertex { get; set; }

        PointF[] p;

        public void CreateFrame(Canvas canvas, AbstractFigure ModifiedFigure)
        {
            FrameRectanle = ModifiedFigure.Markup.GetBounds();
            Vertex = new List<Rectangle>();
            canvas.Graphics.DrawRectangle(pen,
                FrameRectanle.X,
                FrameRectanle.Y,
                FrameRectanle.Width,
                FrameRectanle.Height);
            p = new PointF[]
            {
                new PointF(FrameRectanle.X,FrameRectanle.Y),
                new PointF(FrameRectanle.X,FrameRectanle.Y+FrameRectanle.Height/2),
                new PointF(FrameRectanle.X,FrameRectanle.Y+FrameRectanle.Height),
                new PointF(FrameRectanle.X+FrameRectanle.Width/2,FrameRectanle.Y+FrameRectanle.Height),
                new PointF(FrameRectanle.X+FrameRectanle.Width,FrameRectanle.Y+FrameRectanle.Height),
                new PointF(FrameRectanle.X+FrameRectanle.Width,FrameRectanle.Y+FrameRectanle.Height/2),
                new PointF(FrameRectanle.X+FrameRectanle.Width,FrameRectanle.Y),
                new PointF(FrameRectanle.X+FrameRectanle.Width/2,FrameRectanle.Y)
            };
        }
        public void CreateVertex(Canvas canvas)
        {
            foreach (PointF i in p) 
            {
                Rectangle node = new Rectangle
                (
                (int)i.X - 4,
                (int)i.Y - 4,
                8, 8);
                canvas.Graphics.DrawRectangle(pen, node);
                Vertex.Add(node);
            }
        }

    }
}
