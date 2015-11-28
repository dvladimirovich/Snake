using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine
    {
        private List<Point> points;

        public VerticalLine(int x, int yTop, int yBottom, char symbol)
        {
            points = new List<Point>();
            for (int i = yTop; i <= yBottom; i++)
            {
                Point p = new Point(x, i, symbol);
                points.Add(p);
            }
        }

        public void Draw()
        {
            foreach (Point p in points)
            {
                p.Draw();
            }
        }
    }
}
