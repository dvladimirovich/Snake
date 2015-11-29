using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);

            // Отрисовка рамки
            HorizontalLine topLine = new HorizontalLine(0, 78, 0, '+');
            topLine.Draw();
            HorizontalLine bottomLine = new HorizontalLine(0, 78, 24, '+');
            bottomLine.Draw();
            VerticalLine leftLine = new VerticalLine(0, 0, 24, '+');
            leftLine.Draw();
            VerticalLine rightLine = new VerticalLine(78, 0, 24, '+');
            rightLine.Draw();

            // Отрисовка змейки
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.Right);
            snake.Draw();

            Console.ReadKey();
        }
    }
}
