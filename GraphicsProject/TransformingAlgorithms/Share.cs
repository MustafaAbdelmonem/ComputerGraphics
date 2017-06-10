using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsProject.TransformingAlgorithms
{
    public class Share
    {
        public static List<Point> ShareXY(int shx, int shy, List<Point> newpoints)
        {
            for (int i = 0; i < newpoints.Count; i++)
            {
                int newx = newpoints[i].X + (newpoints[i].Y * shx);
                int newy = newpoints[i].Y + (newpoints[i].X * shy);
                newpoints[i] = new Point(newx, newy);
            }
            return newpoints;
        }
    }
}
