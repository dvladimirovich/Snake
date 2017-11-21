using System;
using System.Collections.Generic;
using System.Linq;

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

        internal void Move()
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

        public void HandleKey(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.LeftArrow:
                    if (direction != Direction.Right)
                        direction = Direction.Left;
                    break;
                case ConsoleKey.RightArrow:
                    if (direction != Direction.Left)
                        direction = Direction.Right;
                    break;
                case ConsoleKey.UpArrow:
                    if (direction != Direction.Down)
                        direction = Direction.Up;
                    break;
                case ConsoleKey.DownArrow:
                    if (direction != Direction.Up)
                        direction = Direction.Down;
                    break;
                default: break;
            }
        }
        public bool Eat(Point food)
        {
            //Point head = GetNextPoint();
            Point head = points.Last();
            // Питание происходит при совпадении с точкой головы змейки
            if (head.IsHit(food))
            {
                food.Symbol = head.Symbol;
                points.Add(food);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Столкнулась ли с хвостом
        /// </summary>
        /// <returns></returns>
        public bool IsHitTail()
        {
            Point head = points.Last();
            for (int i = 0; i < points.Count - 2; i++)
            {
                if (head.IsHit(points[i]))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
