using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsProject.TransformingAlgorithms
{
    public static class Rotation
    {
        public static List<Point> Rotate(double degree, List<Point> newpoints)
        {
            for (int i = 0; i < newpoints.Count; i++)
            {
                int newx = (int)((newpoints[i].X * Math.Cos(degree)) - (newpoints[i].Y * Math.Sin(degree)));
                int newy = (int)((newpoints[i].X * Math.Sin(degree)) + (newpoints[i].Y * Math.Cos(degree)));
                newpoints[i] = new Point(newx, newy);
            }
            return newpoints;
        }
    }
}
