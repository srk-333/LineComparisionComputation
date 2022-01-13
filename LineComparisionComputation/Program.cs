using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisionComputation
{
    public class Program
    {
        //instance variable to store distance of given co-ordinates.
        static double distance1, distance2;

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
            Console.WriteLine(distance1);
            Console.WriteLine(distance2);
        }
        //Main method /Entry Point of program
        static void Main(string[] args)
        {
            //Showing message on console
            Console.WriteLine("Welcome to Line Comparision Computation Program");
            Program.CheckLine();  // calling static method of program class.
            Console.ReadLine(); 
        }
    }
}
