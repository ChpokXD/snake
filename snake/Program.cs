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
            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point( 4, 5, '#');
            p2.Draw();

            HorizontalLine hLine1 = new HorizontalLine( 5, 10, 8, '+');
            hLine1.DrawLine();

            VerticalLine vLine1 = new VerticalLine(10, 15, 12, '*');
            vLine1.DrawLine();
                   

            Console.ReadLine();
            
        }                
    }
}
