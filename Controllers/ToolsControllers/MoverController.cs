using System;
using System.Drawing;
using VectorGraphicsEditor.MarkUp;
using VectorGraphicsEditor.Painter;
using VectorGraphicsEditor.Controllers.ToolsControllers;

namespace VectorGraphicsEditor.ToolsControllers
{
    public class Mover : IToolController
    {
        private bool mouseDown;
        public bool toolSelected;
        public void KeyDown()
        {
            throw new NotImplementedException();
        }

        public void KeyUp()
        {
            throw new NotImplementedException();
        }

        public void MouseDoubleHandle(PointF point, Pen pen, IMarkUp markUp, IPainter painter, Canvas canvas)
        {
            if (toolSelected)
            {
                if (mouseDown)
                {

                }
            }
        }

        public void MouseDownHandle(PointF point, Pen pen, IMarkUp markUp, IPainter painter, Canvas canvas)
        {
            if (toolSelected)
            {
                if (mouseDown)
                {

                }
            }
        }

        public void MouseMoveHandle(PointF point, Pen pen, IMarkUp markUp, IPainter painter, Canvas canvas)
        {
            if (toolSelected)
            {
                if (mouseDown)
                {

                }
            }
        }

        public void MouseUpHandle(PointF point, Pen pen, IMarkUp markUp, IPainter painter, Canvas canvas)
        {
            if (toolSelected)
            {
                if (mouseDown)
                {

                }
            }
        }
    }
}
