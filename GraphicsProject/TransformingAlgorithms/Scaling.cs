using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsProject.TransformingAlgorithms
{
    public static class Scaling
    {
        public static List<Point> Scale(int x, int y, List<Point> newpoints)
        {
            for (int i = 0; i < newpoints.Count; i++)
                newpoints[i] = new Point(newpoints[i].X * x, newpoints[i].Y * y);
            return newpoints;
        }
    }
}
