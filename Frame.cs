using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using VectorGraphicsEditor.Figure;
using VectorGraphicsEditor.Tools;

namespace VectorGraphicsEditor
{
    public class Frame
    {
        static public void CreateFrame(Canvas canvas, AbstractFigure ModifiedFigure)
        {
            canvas.CreateLayer();
            RectangleF boundRect = ModifiedFigure.Markup.GetBounds();
            canvas.Graphics.DrawRectangle(new Pen(Color.Black, 1),
                boundRect.X,
                boundRect.Y,
                boundRect.Width,
                boundRect.Height);
        }
    }
}
