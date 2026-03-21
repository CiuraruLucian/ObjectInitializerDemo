using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectInitializers
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("***** Fun with Object Init Syntax *****\n");

            //Make a point by setting each property manually.
            Point firstPoint = new Point();
            firstPoint.X = 10;
            firstPoint.Y = 10;
            firstPoint.DisplayStats();
            //Make a point via a custom constructor.
            Point secondPoint = new Point(20,20);
            secondPoint.DisplayStats();

            //Make a Point using object init syntax.
            Point thirdPoint = new Point { X = 30, Y = 30 };
            thirdPoint.DisplayStats();

            Console.ReadLine();
        }
    }
}
