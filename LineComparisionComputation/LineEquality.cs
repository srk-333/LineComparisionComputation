using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisionComputation
{
    public class LineEquality
    {

        //instance variable to store distance of given co-ordinates.
        static double distance1, distance2, distance3;

        // Method for creating co-ordinates
        public static void CheckLine()
        {
            /* passing values to constructor while creating class object.
             * calling Length method to get length of co-ordinates.
             */
            LineComputation lc1 = new LineComputation(2.3, 3.4, 1.5, 2.5);
            distance1 = lc1.Length();
            LineComputation lc2 = new LineComputation(3.2, 4.5, 2.4, 4.2);
            distance2 = lc2.Length();
            LineComputation lc3 = new LineComputation(2.3, 3.4, 1.5, 2.5);
            distance3 = lc3.Length();
            Console.WriteLine("Length of Line1: " + distance1);
            Console.WriteLine("Length of Line2: " + distance2);
            Console.WriteLine("Length of Line3: " + distance3);

            //checking equality of lines using equals method 
            if (distance1.Equals(distance2))
            {
                Console.WriteLine("lines one and two are equal");
            }
            else if (distance2.Equals(distance3))
            {
                Console.WriteLine("lines two and three are equal");
            }
            else if (distance1.Equals(distance3))
            {
                Console.WriteLine("lines one and three are equal");
            }
            else
            {
                Console.WriteLine("Lines are not Equal");
            }
        }
    }
}
