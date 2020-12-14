using System.Drawing;
using System; 
using System.Collections.Generic;
using System.Windows.Forms;

namespace VectorGraphicsEditor
{
    public class Canvas
    {
        public Stack<Bitmap> Layers { get; set; }
        public int Length
        {
            get
            {
                return Layers.Count;
            }
        }
        public Bitmap MainBitmap { get; set; }
        public Bitmap TmpBitmap { get; set; }        
        public Graphics Graphics { get; set; }
  
        public PictureBox PictureBox { get; set;}
        public Canvas(int width, int height)
        {
            Layers = new Stack<Bitmap>();
            MainBitmap = new Bitmap(width, height);
            Graphics = Graphics.FromImage(MainBitmap);
            Layers.Push(MainBitmap);
        }
        public void CreateLayer()
        {
            TmpBitmap = (Bitmap)MainBitmap.Clone();
            Graphics = Graphics.FromImage(TmpBitmap);
        }
        public void SaveLayer()
        {
            MainBitmap = TmpBitmap;
            Layers.Push(MainBitmap);
        }

        public void UndoLayer()
        {
            Layers.Pop();
            MainBitmap = Layers.Peek();
            Graphics = Graphics.FromImage(MainBitmap);
        }
        

    }
}

