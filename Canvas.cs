using System.Drawing;
using System; 
using System.Collections.Generic;

namespace VectorGraphicsEditor
{
    public class Canvas
    {
        public List<Bitmap> Layers { get; set; }
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
        public Bitmap this[int index]
        {
            get
            {
                if (index >= Length || index < 0)
                {
                    throw new IndexOutOfRangeException();
                }
                return Layers[index];
            }
            set
            {
                if (index >= Length || index < 0)
                {
                    throw new IndexOutOfRangeException();
                }
                Layers[index] = value;
            }
        }
        public Canvas(int width, int height)
        {
            Layers = new List<Bitmap>();
            MainBitmap = new Bitmap(width, height);
            Graphics = Graphics.FromImage(MainBitmap);
            Layers.Add(MainBitmap);
        }
        public void CreateLayer()
        {
            TmpBitmap = (Bitmap)MainBitmap.Clone();
            Graphics = Graphics.FromImage(TmpBitmap);
        }
        public void SaveLayer()
        {
            MainBitmap = TmpBitmap;
            //Layers.Add(MainBitmap);
        }

        public void UndoLayer()
        {
            MainBitmap = Layers[Length - 2];
            Graphics = Graphics.FromImage(MainBitmap);
        }
        

    }
}

