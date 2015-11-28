﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        private static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            List<int> numList = new List<int>();
            numList.Add(0);
            numList.Add(1);
            numList.Add(2);

            int x = numList[0];
            int y = numList[1];
            int z = numList[2];

            foreach (int i in numList)
            {
                Console.WriteLine(i);    
            }

            numList.RemoveAt(0);

            List<Point> points = new List<Point>();
            points.Add(p1);
            points.Add(p2);
            Point p3 = new Point(7, 7, '$');
            Point p4 = new Point(10, 9, '&');
            points.Add(p3);
            points.Add(p4);
            foreach (Point p in points)
            {
                p.Draw();
            }
            Console.ReadKey();
        }
    }
}
