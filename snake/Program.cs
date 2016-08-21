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
            Console.SetBufferSize(80, 25);
            Walls w = new Walls(80, 25);
            w.Draw();
            Point p = new Point(5, 2, '*');
            //Snake snake = new Snake(p, 3, Direction.RIGHT);
            Figure fs = new Snake(p, 3, Direction.RIGHT);//использовал полиморфизм т.к. змея тоже фигура,
            //snake.Draw();//НО теперь нельзя юзать все методы змейки можно только общие фигурные
            Snake snake = (Snake)fs;
            Food F = new Food(80,25,'&');
            Point food = new Point(F.FoodCreate());
          //  List<Figure> list = new List<Figure>();
          /*  Figure V = new Vertical_lines(0, 5, 3);//можно добавлять разные подтипы фигур в список и машина сама разберется где какой метод 
            Figure H = new Horizontal_lines(0, 5, 1);//применить т.к. дро у разный классов реализовон по разному
            list.Add(V);
            list.Add(H);
            list.Add(fs);
            foreach (Figure f in list)
                Draw(f);*/
            
            while (true)
            {
                if (snake.Headhitbody() || w.WallsHit(snake))
                    break;
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
               // w.Draw();
                Thread.Sleep(100);
            }
           

        }
       /* static void Draw(Figure f)
        {
            f.Draw();
        }*/
    }
}
