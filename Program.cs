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
            Point secondPoint = new Point(20, 20);
            secondPoint.DisplayStats();

            //Make a Point using object init syntax (Calling the default constructor implicitly)
            Point thirdPoint = new Point { X = 30, Y = 30 };
            thirdPoint.DisplayStats();

            //Make a Point using object init syntax (Calling the default constructor explicitly)
            Point fourthPoint = new Point() { X = 40, Y = 40 };
            fourthPoint.DisplayStats();

            // Calling a custom constructor.
            Point pt = new Point(10, 16) { X = 100, Y = 100 };
            pt.DisplayStats();

            // Calling a more interesting custom contructor with init syntax
            Point goldPoint = new Point(PointColor.Gold) { X = 90, Y = 90 };


            // Create and initialize a Rectangle.
            Rectangle myRect = new Rectangle()
            { 
                TopLeft = new Point { X = 10, Y = 10  },
                BottomRight = new Point { X = 200, Y = 200 }
            };

            myRect.DisplayStats();
            Console.ReadLine();
        }
    }
}
