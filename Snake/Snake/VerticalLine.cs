using System.Collections.Generic;

namespace Snake
{
    class VerticalLine: Figure
    {
        public VerticalLine(int x, int yTop, int yBottom, char symbol)
        {
            points = new List<Point>();
            for (int i = yTop; i <= yBottom; i++)
            {
                Point p = new Point(x, i, symbol);
                points.Add(p);
            }
        }
    }
}
