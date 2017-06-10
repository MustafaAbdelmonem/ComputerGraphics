using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsProject.TransformingAlgorithms
{
   
        class calc
        {
            public float p { get; set; }
            public float q { get; set; }
            public float r { get; set; }
        };
        public static class Clipping
        {
            public static List<Point> clipLiangBarsky(int x1, int x2, int y1, int y2, int winXmin, int winYmin, int winXmax, int winYmax)
            {
                List<calc> arr = new List<calc>();
                arr.Add(new calc());
                arr.Add(new calc());
                arr.Add(new calc());
                arr.Add(new calc());
                arr[0].p = -x2 - x1;
                arr[0].q = x1 - winXmin;
                arr[0].r = arr[0].q / arr[0].p;
                arr[1].p = x2 - x1;
                arr[1].q = winXmax - x1;
                arr[1].r = arr[1].q / arr[1].p;
                arr[2].p = -y2 - y1;
                arr[2].q = y1 - winYmin;
                arr[2].r = arr[2].q / arr[2].p;
                arr[3].p = y2 - y1;
                arr[3].q = winYmax - y1;
                arr[3].r = arr[3].q / arr[3].p;
                float u1 = 0, u2 = 1;
                for (int i = 0; i < 4; i++)
                {
                    if (arr[i].p < 0 && arr[i].r > u1)
                    {
                        u1 = arr[i].r;
                    }
                    if (arr[i].p > 0 && arr[i].r < u2)
                    {
                        u2 = arr[i].r;
                    }
                }
                float newx1, newy1, newx2, newy2;
                var points = new List<Point>();
                newx1 = x1 + u1 * (x2 - x1);
                newy1 = y1 + u1 * (y2 - y1);
                newx2 = x1 + u2 * (x2 - x1);
                newy2 = y1 + u2 * (y2 - y1);
                points.Add(new Point((int)newx1, (int)newy1));
                points.Add(new Point((int)newx2, (int)newy2));
                return points;
            }
        }
    }



