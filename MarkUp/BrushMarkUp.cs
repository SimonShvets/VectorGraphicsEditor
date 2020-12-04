﻿using System.Collections.Generic;
using System.Drawing;

namespace VectorGraphicsEditor.MarkUp
{
    public class BrushMarkUp:IMarkUp
    {
        public List<PointF> PointList { get; set; }
        public int Length 
        { 
            get
            {
                return PointList.Count;
            }
            set
            {
                //??? Уточнить у макса, т к set нужно делать приватным, 
                //но интервейс не позволяет этого сделать
            }
        }

        public BrushMarkUp()
        {
            PointList = new List<PointF>();
        }
        public void AddPoint(PointF point)
        {
            PointList.Add(point);
        }
        public PointF[] Calculate()
        {
            //PointF[] point = new PointF[2];
            //point[0] = _pointList[_pointList.Count - 2];
            ////point[1] = _pointList[_pointList.Count - 1];
            //return point;
            return PointList.ToArray();
        }
    }
}
