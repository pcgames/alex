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
            Point p1 = new Point();
            p1.x = 5;
            p1.y = 8;
            p1.s = '&';
            p1.Draw();
           //Console.WriteLine("Hello");
           Console.ReadLine();
        }
    }
}
