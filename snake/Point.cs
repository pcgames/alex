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
        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            s = p.s;
        }
        public void Move(int offset, Direction o)
        {
            if (o == Direction.RIGHT)
                x = x + offset;
            if (o == Direction.LEFT)
                x = x - offset;
            if (o == Direction.UP)
                y = y - offset;
            if (o == Direction.DOWN)
                y = y + offset;
        }
    }
}
