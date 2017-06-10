using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsProject.DrawingAlgorithms
{
    public class Eclipse
    {
        static List<Point> res = new List<Point>();
        public static List<Point> DrawEclipse(double xc, double yc, double rx, double ry)
        {
            double rxSq = rx * rx;
            double rySq = ry * ry;
            double x = 0, y = ry, p;
            double px = 0, py = 2 * rxSq * y;
            CalcPoint(xc, yc, x, y);
            p = rySq - (rxSq * ry) + (0.25 * rxSq);
            while (px < py)
            {
                x++;
                px = px + 2 * rySq;
                if (p < 0)
                    p = p + rySq + px;
                else
                {
                    y--;
                    py = py - 2 * rxSq;
                    p = p + rySq + px - py;
                }
                CalcPoint(xc, yc, x, y);
            }
            //Region 2
            p = rySq * (x + 0.5) * (x + 0.5) + rxSq * (y - 1) * (y - 1) - rxSq * rySq;
            while (y > 0)
            {
                y--;
                py = py - 2 * rxSq;
                if (p > 0)
                    p = p + rxSq - py;
                else
                {
                    x++;
                    px = px + 2 * rySq;
                    p = p + rxSq - py + px;
                }
                CalcPoint(xc, yc, x, y);
            }
            return res;
        }
        static void CalcPoint(double xc, double yc, double x, double y)
        {
            res.Add(new Point((int)(xc + x), (int)(yc + y)));
            res.Add(new Point((int)(xc - x), (int)(yc + y)));
            res.Add(new Point((int)(xc + x), (int)(yc - y)));
            res.Add(new Point((int)(xc - x), (int)(yc - y)));
        }
    }
}
