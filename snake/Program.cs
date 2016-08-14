using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Horizontal_lines r = new Horizontal_lines(1,10,25);
            Vertical_lines g = new Vertical_lines(1, 32, 14);
            g.Draw();
            r.Draw();
            Console.ReadLine();
        }
    }
}
