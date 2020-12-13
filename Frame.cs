using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using VectorGraphicsEditor.Figure;
using VectorGraphicsEditor.Tools;

namespace VectorGraphicsEditor
{
    public class Frame
    {
        Pen pen = new Pen(Color.Black, 1);
        PointF[] p;

        public void CreateFrame(Canvas canvas, AbstractFigure ModifiedFigure)
        {
            RectangleF boundRect = ModifiedFigure.Markup.GetBounds();
            canvas.Graphics.DrawRectangle(pen,
                boundRect.X,
                boundRect.Y,
                boundRect.Width,
                boundRect.Height);

            p = new PointF[]
            {
                new PointF(boundRect.X,boundRect.Y),
                new PointF(boundRect.X,boundRect.Y+boundRect.Height/2),
                new PointF(boundRect.X,boundRect.Y+boundRect.Height),
                new PointF(boundRect.X+boundRect.Width/2,boundRect.Y+boundRect.Height),
                new PointF(boundRect.X+boundRect.Width,boundRect.Y+boundRect.Height),
                new PointF(boundRect.X+boundRect.Width,boundRect.Y+boundRect.Height/2),
                new PointF(boundRect.X+boundRect.Width,boundRect.Y),
                new PointF(boundRect.X+boundRect.Width/2,boundRect.Y)
            };
        }
        public void CreateVertex(Canvas canvas)
        {
            foreach (PointF i in p) 
            {
                PointF[] node = new PointF[]
{
                new PointF(i.X - 4, i.Y-4),
                new PointF(i.X - 4, i.Y+4),
                new PointF(i.X + 4, i.Y+4),
                new PointF(i.X + 4, i.Y-4)
};
                canvas.Graphics.DrawPolygon(pen, node);
            }
        }

    }
}
