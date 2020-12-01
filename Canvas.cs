using System.Drawing;
using VectorGraphicsEditor.Painter;
using VectorGraphicsEditor.MarkUp;

namespace VectorGraphicsEditor
{
        public class Canvas
        {
            public Bitmap MainBitmap { get; set; } //Объект Bitmap используется для работы с изображениями, определяемыми данными пикселей
            public Bitmap TmpBitmap { get; set; }

            Graphics _graphics; //класс с методами для рисования

            public Canvas(int width, int height)
            {
                MainBitmap = new Bitmap(width, height);
                _graphics = Graphics.FromImage(MainBitmap);
            }

            public void Paint(Pen pen, BrushMarkUp marks, IPainter painter)
            {
                TmpBitmap = (Bitmap)MainBitmap.Clone();
                _graphics = Graphics.FromImage(TmpBitmap); //графикс рисует на временном битмапе
                painter.DrawFigure(pen, _graphics, marks.Calculate());
            }

            public void Save()
            {
                MainBitmap = TmpBitmap;
            }

        }
}

