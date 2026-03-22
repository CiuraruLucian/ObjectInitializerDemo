using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectInitializers
{
    // Represents a rectangle defined by TWO points:
    // - Top-left corner
    // - Bottom-right corner
    // we reuse the Point class — this is called COMPOSITION
    // (a Rectangle HAS Points).
    public class Rectangle
    {
        
        // IMPORTANT:
        // new Point() runs BEFORE any object initializer later.
        // => The default Constructor (Constructor 3 is called) => The color is BloodRed
        private Point topLeft = new Point();
        private Point bottomRight = new Point();

        public Point TopLeft
        {
            get { return topLeft; }
            set { topLeft = value; }
        }

        public Point BottomRight
        {
            get { return bottomRight; }
            set { bottomRight = value; }
        }

        public void DisplayStats()
        {
            Console.WriteLine(
                "[TopLeft: {0}, {1}, {2} BottomRight: {3}, {4}, {5}]",
                topLeft.X,
                topLeft.Y,
                topLeft.Color, 
                bottomRight.X, 
                bottomRight.Y, 
                bottomRight.Color
            );
        }

        // How a Juniour Should Mentally Picture this 
        /*
        Rectangle
 ├── Point(TopLeft)
 │     ├── X
 │     ├── Y
 │     └── Color
 │
 └── Point(BottomRight)
       ├── X
       ├── Y
       └── Color
        */
    }
}
