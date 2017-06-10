using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsProject.DrawingAlgorithms
{
    public class Line
    {
        public static List<Point> BresLineOrig(Point begin, Point end)
        {
            List<Point> res = new List<Point>();
            Point nextPoint = begin;
            int deltax = end.X - begin.X;
            int deltay = end.Y - begin.Y;
            int error = deltax / 2;
            int ystep = 1;

            if (end.Y < begin.Y)
            {
                ystep = -1;
            }

            while (nextPoint.X < end.X)
            {
                if (nextPoint != begin) res.Add(nextPoint);
                nextPoint.X++;

                error -= deltay;
                if (error < 0)
                {
                    nextPoint.Y += ystep;
                    error += deltax;
                }
            }
            return res;
        }
    }
}
