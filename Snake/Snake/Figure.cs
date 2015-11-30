using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Figure
    {
        protected List<Point> points;

        public void Draw()
        {
            foreach (Point p in points)
            {
                p.Draw();
            }
        }

        internal bool IsHit(Figure figure)
        {
            foreach (Point p in points)
            {
                if (figure.IsHit(p))
                {
                    return true;
                }
            }
            return false;
        }

        private bool IsHit(Point point)
        {
            foreach (Point p in points)
            {
                if (point.IsHit(p))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
