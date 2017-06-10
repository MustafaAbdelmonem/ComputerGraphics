using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsProject.TransformingAlgorithms
{
    public class Reflection
    {

        public static List<Point> reflectX(List<Point> newpoints)
        {
            for (int i = 0; i < newpoints.Count; i++)
            {
                int newx = newpoints[i].X * -1;
                newpoints[i] = new Point(newx, newpoints[i].Y);
            }
            return newpoints;
        }
        public static List<Point> reflectY(List<Point> newpoints)
        {
            for (int i = 0; i < newpoints.Count; i++)
            {
                int newy = newpoints[i].Y * -1;
                newpoints[i] = new Point(newpoints[i].X, newy);
            }
            return newpoints;
        }
        //public static List<Point> reflectXY(List<Point> newpoints)
        //{
        //    for (int i = 0; i < newpoints.Count; i++)
        //    {
        //        int newx = newpoints[i].X * -1;
        //        int newy = newpoints[i].Y * -1;
        //        newpoints[i] = new Point(newx, newy);
        //    }
        //    return newpoints;
        //}
    }
}