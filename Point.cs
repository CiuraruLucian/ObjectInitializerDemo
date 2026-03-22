using System;


namespace ObjectInitializers
{
    // Enum = a fixed set of named values
    // public so constructors can expose it safely
    public enum PointColor
    { LightBlue, BloodRed, Gold }
    // Public class representing a 2D point
    public class Point
    {
        // Auto-property for X coordinate
        public int X { get; set; }
        // Auto-property for Y coordinate
        public int Y { get; set; }
        // Property storing the point's color
        public PointColor Color { get; set; }
        // ---------------- CONSTRUCTOR #1 ----------------
        // Called when user provides X and Y
        // Example: new Point(10, 20)
        public Point( int xVal, int yVal )
        {
            X = xVal;// assign X coordinate
            Y = yVal;// assign Y coordinate
            Color = PointColor.Gold;// default color if not specified
        }
        // ---------------- CONSTRUCTOR #2 ----------------
        // Called when user provides ONLY a color
        // Example: new Point(PointColor.LightBlue)
        public Point(PointColor ptColor)
        {
            Color = ptColor;   // set color  
            // X and Y remain default (0,0)
        }

        // ---------------- CONSTRUCTOR #3 (DEFAULT) ----------------
        // Called when user writes: new Point()
        // ": this(...)" means call another constructor FIRST
        public Point()
        : this(PointColor.BloodRed) // calls constructor #2 and the default color is BloodRed
        {
            // body is empty because work is already done
        } 

        public void DisplayStats()
        {
            Console.WriteLine("[{0}, {1}]", X, Y);
            Console.WriteLine("Point is {0}", Color);
        }
    }
}
