using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsProject.DrawingAlgorithms
{
    public class Circle
    {
        static List<Point> res = new List<Point>();
        public static List<Point> DrawCircle(int xC, int yC, int Radius)
        {
            int P;
            int x, y;
            P = 1 - Radius;
            x = 0;
            y = Radius;
            CalcPoint(x, y, xC, yC);
            while (x <= y)
            {
                x++;
                if (P < 0)
                {
                    P += 2 * x + 1;
                }
                else
                {
                    P += 2 * (x - y) + 1;
                    y--;
                }
                CalcPoint(x, y, xC, yC);
            }
            return res;
        }
        static void CalcPoint(int x, int y, int xC, int yC)
        {
            res.Add(new Point((xC + x), (yC + y)));
            res.Add(new Point((xC + x), (yC - y)));
            res.Add(new Point((xC - x), (yC + y)));
            res.Add(new Point((xC - x), (yC - y)));
            res.Add(new Point((xC + y), (yC + x)));
            res.Add(new Point((xC - y), (yC + x)));
            res.Add(new Point((xC + y), (yC - x)));
            res.Add(new Point((xC - y), (yC - x)));
        }
    }
}
