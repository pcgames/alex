using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace snake
{
    class Program
    {

        static void Main(string[] args)
        {
          /*  Point p1 = new Point(5,8,'&');
            p1.Draw();
            Point p2 = new Point(6, 7, '*');
            p2.Draw();
            List<int> l1=new List<int>();
            l1.Add( 17);
            l1.Add( 1);
            l1.Add( 99);
            foreach (int i in l1)
            {
                Console.WriteLine(i);
            }

           //Console.WriteLine("Hello");
            l1.Clear();
            List<Point> tp = new List<Point>();
            tp.Add(p1);
            tp.Add(p2);*/
            Console.SetBufferSize(80, 45);
            Point p = new Point(6, 7, '*');
            Snake snake = new Snake(p, 3, Direction.RIGHT);
            snake.Draw();
            Food F = new Food(80,45,'&');
            Point food = new Point(F.FoodCreate());
            
            while (true)
            {
                if (snake.EatSnake(food))
                {
                    food = F.FoodCreate();
                }
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.DirectionMove(key);
                }
                snake.Move();
                Thread.Sleep(100);
            }
            
        }
    }
}
