using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsProject.TransformingAlgorithms
{
    public static class Translation
    {
        public static List<Point> Translate(int tx, int ty, List<Point> newpoints)
        {
            for (int i = 0; i < newpoints.Count; i++)
                newpoints[i] = new Point(newpoints[i].X + tx, newpoints[i].Y + ty);
            return newpoints;
        }
    }
}
