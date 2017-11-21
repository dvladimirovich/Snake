using System;

namespace Snake
{
    internal class Point
    {
        public int X;
        public int Y;
        public char Symbol;

        public Point() {}

        public Point(int x, int y, char symbol)
        {
            X = x;
            Y = y;
            Symbol = symbol;
        }

        public Point(Point p)
        {
            X = p.X;
            Y = p.Y;
            Symbol = p.Symbol;
        }

        public void Draw()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(Symbol);
        }

        /// <summary>
        /// Сдвиг змейки на расстояние по направлению
        /// </summary>
        /// <param name="offset">расстояние на которое сдвиг произойдёт</param>
        /// <param name="direction">енаправление движения</param>
        public void Move(int offset, Direction direction)
        {
            switch (direction)
            {
                case Direction.Right:
                    X += offset;
                    break;
                case Direction.Left:
                    X -= offset;
                    break;
                case Direction.Up:
                    Y -= offset;
                    break;
                case Direction.Down:
                    Y += offset;
                    break;
            }
        }

        public override string ToString()
        {
            return X + "," + Y + "," + Symbol;
        }

        internal void Clear()
        {
            Symbol = ' ';
            Draw();
        }

        public bool IsHit(Point p)
        {
            return p.X == this.X && p.Y == this.Y;
        }
    }
}
