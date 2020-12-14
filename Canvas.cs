using System.Drawing;
using System; 
using System.Collections.Generic;

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
        //public Bitmap this[int index]
        //{
        //    get
        //    {
        //        if (index >= Length || index < 0)
        //        {
        //            throw new IndexOutOfRangeException();
        //        }
        //        return Layers[index];
        //    }
        //    set
        //    {
        //        if (index >= Length || index < 0)
        //        {
        //            throw new IndexOutOfRangeException();
        //        }
        //        Layers[index] = value;
        //    }
        //}
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
            //for (int i = 0; i < figures.C)
            Layers.Pop();
            MainBitmap = Layers.Peek();
            Graphics = Graphics.FromImage(MainBitmap);
        }
        

    }
}

