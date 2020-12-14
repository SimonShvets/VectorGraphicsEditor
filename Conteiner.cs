using System;
using System.Collections.Generic;
using VectorGraphicsEditor.Figure;
using System.Drawing;

namespace VectorGraphicsEditor
{
    public class Container
    {
        List<AbstractFigure> Figures { get; set; }
        public int Length 
        { 
            get
            {
                return Figures.Count;
            } 
        }
        public AbstractFigure this[int index]
        {
            get
            {
                if (index >= Length || index < 0)
                {
                    throw new IndexOutOfRangeException();
                }
                return Figures[index];
            }
            set
            {
                if (index >= Length || index < 0)
                {
                    throw new IndexOutOfRangeException();
                }
                Figures[index] = value;
            }
        }
        public Container()
        {
            Figures = new List<AbstractFigure>();
        }
            public void Add(AbstractFigure markUp)
        {
            Figures.Insert(0, markUp);
        }

        public void Insert(int index, AbstractFigure figureToReplace)
        {
            Figures.Insert(index, figureToReplace);
        }
        public void Remove(int index)
        {
            Figures.RemoveAt(index);
        }
        public void Clear() 
        {
            Figures.Clear();
        }
    }
}
