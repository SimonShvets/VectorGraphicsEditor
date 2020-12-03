using System.Drawing;
using VectorGraphicsEditor.Painter;
using VectorGraphicsEditor.MarkUp;
using VectorGraphicsEditor.Tool;
using System.Windows.Forms;

namespace VectorGraphicsEditor
{
        public class Canvas
        {
            public Bitmap MainBitmap { get; set; }
            public Bitmap TmpBitmap { get; set; }
            public Graphics Graphics { get; set; }

            public Canvas(int width, int height)
            {
                MainBitmap = new Bitmap(width, height);
                Graphics = Graphics.FromImage(MainBitmap);
            }
            public void Save()
            {
                MainBitmap = TmpBitmap;
            }

        }
}

