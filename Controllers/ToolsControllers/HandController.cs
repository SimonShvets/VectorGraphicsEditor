using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using VectorGraphicsEditor.Figure;
using VectorGraphicsEditor.Tools;

namespace VectorGraphicsEditor.Controllers.ToolsControllers
{
    public class HandController : IToolController
    {
        private bool mouseDown;
        AbstractFigure ModifiedFigure;
        int _modifiedFigureIndex;
        PointF _pullStartPoint;
        Frame frame = new Frame();
        string mode = "";

        public void MouseDownHandle(PointF point, Pen pen, AbstractFigure figure, Canvas canvas, Container figures, AbstractTool tool)
        {
            mouseDown = true;
            ModifiedFigure = null;
            for (int i = 0; i < figures.Length; i++)
            {
                if (tool.Selector.Select(figures[i], point))
                {
                    mode = "Move";
                    canvas.CreateLayer();
                    ModifiedFigure = figures[i];
                    _pullStartPoint = point;
                    _modifiedFigureIndex = i;
                    figures.Remove(_modifiedFigureIndex);
                    frame.CreateFrame(canvas, ModifiedFigure);
                    frame.CreateVertex(canvas);
                    DrawAllAseptModified(pen, canvas, figure, figures);
                    break;
                }
                if (frame.Vertex != null)
                {
                    //for (int k = 0; k < frame.Vertex.Count; k += 2)
                    //{
                        if (new RectangleF(point.X, point.Y, 8, 8).IntersectsWith(frame.Vertex[k]))
                        {
                            mode = "Rotate";
                            canvas.CreateLayer();
                            ModifiedFigure = figures[i];
                            _pullStartPoint = point;
                            _modifiedFigureIndex = i;
                            figures.Remove(_modifiedFigureIndex);
                            DrawAllAseptModified(pen, canvas, figure, figures);
                            break;
                        }
                    //}
                }
            }
        }
        public void MouseMoveHandle(PointF point, Pen pen, AbstractFigure figure, Canvas canvas, Container figures, AbstractTool tool)
        {
            if (mouseDown && ModifiedFigure != null)
            {
                switch (mode)
                {
                    case "Move":
                        { 
                            canvas.CreateLayer();
                            PointF delta = new PointF(point.X - _pullStartPoint.X, point.Y - _pullStartPoint.Y);
                            if (tool is HandTool)
                            {
                            ((HandTool)tool).Move(delta, ModifiedFigure.Markup);
                            }
                            _pullStartPoint = point;
                            canvas.Graphics.DrawPath(pen, ModifiedFigure.Markup);
                            GC.Collect();
                            break;
                        }
                    case "Rotate":
                        {
                            canvas.CreateLayer();
                            PointF delta = new PointF(point.X - _pullStartPoint.X, point.Y - _pullStartPoint.Y);
                            if (tool is HandTool)
                            {
                                ((HandTool)tool).Rotate(delta, ModifiedFigure.CentrePoint, ModifiedFigure.Markup);
                            }
                            _pullStartPoint = point;
                            canvas.Graphics.DrawPath(pen, ModifiedFigure.Markup);
                            GC.Collect();
                            break;
                        }
                    case "Resize":
                        {

                            // Draw the rectangle to the screen before applying the
                            // transform.

                            //canvas.CreateLayer();
                            //// Create a matrix and scale it.
                            //Matrix myMatrix = new Matrix();
                            //myMatrix.Scale(2, 2, MatrixOrder.Append);

                            ////// Draw the rectangle to the screen again after applying the
                            ////// transform.
                            //ModifiedFigure.Markup.Transform(myMatrix);
                            //canvas.Graphics.DrawPath(pen, ModifiedFigure.Markup);
                            ////e.Graphics.DrawRectangle(myPen2, 50, 50, 100, 100);
                            break;
                        }
                }
            }
        }

        public void MouseUpHandle(PointF point, Pen pen, AbstractFigure figure, Canvas canvas, Container figures, AbstractTool tool)
        {
            mouseDown = false;
            if (ModifiedFigure != null)
            {
                figures.Insert(_modifiedFigureIndex, ModifiedFigure);
                canvas.SaveLayer();
            }
        }
        
        private void DrawAllAseptModified(Pen pen, Canvas canvas, AbstractFigure figure, Container figures)
        {
            Bitmap Tmp = new Bitmap(canvas.MainBitmap.Width, canvas.MainBitmap.Height);
            canvas.Graphics = Graphics.FromImage(Tmp);
            for (int i = 0; i < figures.Length;i++)
            {
                canvas.Graphics.DrawPath(pen, figures[i].Markup);
            }
            canvas.MainBitmap = Tmp;
        }
    }
}
