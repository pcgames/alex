using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Draw(int x, int y, char s) 
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(s);
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            int x = 6;
            int y = 8;
            char s='&';
            Draw(x,y,s);

            //Console.WriteLine("Hello");
           // Console.ReadLine();
        }
    }
}
