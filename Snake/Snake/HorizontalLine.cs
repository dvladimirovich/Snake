using System.Collections.Generic;

namespace Snake
{
    internal class HorizontalLine: Figure
    {
        public HorizontalLine(int xLeft, int xRight, int y, char symbol)
        {
            points = new List<Point>();
            for (int i = xLeft; i <= xRight; i++)
            {
                Point p = new Point(i, y, symbol);
                points.Add(p);
            }
        }
    }
}
