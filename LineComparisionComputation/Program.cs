using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisionComputation
{
    public class Program
    {
        //Main method /Entry Point of program
        static void Main(string[] args)
        {
            //Showing message on console
            Console.WriteLine("Welcome to Line Comparision Computation Program");
            LineEquality.CheckLine();  // calling static method of program class.
            Console.ReadLine(); 
        }
    }
}
