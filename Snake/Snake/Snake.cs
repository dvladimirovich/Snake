using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Snake : Figure
    {
        private Direction direction;
        public Snake(Point tail, int length, Direction _direction)
        {
            direction = _direction;
            points = new List<Point>();
            for (int i = 0; i < length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, _direction);
                points.Add(p);
            }
        }

        public void Move()
        {
            // удаляем точку с хвостовой части
            Point tail = points.First();
            points.Remove(tail);
            // создаем следующую точку в головной части
            Point head = GetNextPoint();
            points.Add(head);

            tail.Clear();
            head.Draw();
        }

        private Point GetNextPoint()
        {
            Point head = points.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }
    }
}
