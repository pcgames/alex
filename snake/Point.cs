using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Point
    {
        public int x;
        public int y;
        public char s;
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(s);
        }
        public Point()
        {
            //Console.WriteLine("первый нах!");
        }
        public Point(int _x, int _y, char _s) 
        {
        x = _x;
        y = _y;
        s = _s;
        }
    }
}
