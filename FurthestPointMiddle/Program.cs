using System;

namespace FurthestPointMiddle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            /*var portland = new Loc
            {
                X = 45.5051,
                Y = 122.6750
            };*/

            var portland = new Loc
            {
                X = 52.4811,
                Y = 1.7534
            };

            var raleigh = new Loc
            {
                X = 35.7796,
                Y = 78.6382
            };

            Console.WriteLine("X: " + Loc.GetMiddle(portland, raleigh).X);
            Console.WriteLine("Y: " + Loc.GetMiddle(portland, raleigh).Y);

            Console.WriteLine("X: " + Loc.GetFarthestMiddle(portland, raleigh).X);
            Console.WriteLine("Y: " + Loc.GetFarthestMiddle(portland, raleigh).Y);
        }
    }

    public class Loc
    {
        public double X { get; set; }
        public double Y { get; set; }

        public static Loc GetMiddle(Loc loc1, Loc loc2)
        {
            var newLoc = new Loc
            {
                X = (loc1.X + loc2.X) / 2,
                Y = (loc1.Y + loc2.Y) / 2
            };
            return newLoc;
        }

        public static Loc GetFarthestMiddle(Loc loc1, Loc loc2)
        {
            var newLoc1 = new Loc();
            var newLoc2 = new Loc();
            newLoc1.X = loc1.X * -1;
            newLoc2.X = loc2.X * -1;

            if ((loc1.Y - 180) < -180.0)
            {
                newLoc1.Y = loc1.Y + 180.0;
            } 
            else
            {
                newLoc1.Y = loc1.Y - 180.0;
            }

            if ((loc2.Y - 180) < -180.0)
            {
                newLoc2.Y = loc2.Y + 180.0;
            }
            else
            {
                newLoc2.Y = loc2.Y - 180.0;
            }


            return GetMiddle(newLoc1, newLoc2);
        }
    }
}
