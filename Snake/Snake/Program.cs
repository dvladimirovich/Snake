using System;
using System.Threading;

namespace Snake
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int x = 80, y = 25;
            Console.SetWindowSize(x, y);

            Walls walls = new Walls(x, y);
            walls.Draw();

            // Отрисовка змейки
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.Right);
            snake.Draw();

            // Отрисовка точки - еды
            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            // Движение змейки
            while (true)
            {
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    Console.SetCursorPosition(x / 2 - 5, y / 2);
                    Console.Write("GAME OVER!");
                    Console.ReadKey();
                    break;
                }
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }

                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
            }

        }

        static void Draw(Figure figure)
        {
            figure.Draw();
        }
    }
}
