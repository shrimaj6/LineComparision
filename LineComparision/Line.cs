using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparision
{
    public class Line
    {
        public double computelength(int x1, int y1, int x2, int y2)
        {

            int xabs = Math.Abs(x2 - x1);
            int yabs = Math.Abs(y2 - y1);

            int distance_square = (int)(Math.Pow(xabs, 2) + Math.Pow(yabs, 2));

            double length = Math.Sqrt(distance_square);
            return length;


        }
    }
}
