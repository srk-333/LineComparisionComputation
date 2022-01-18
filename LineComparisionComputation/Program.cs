using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisionComputation
{
    public class Program
    {
        //Main method / Entry Point of program
        static void Main(string[] args)
        {
            //Showing welcome message on console
            Console.WriteLine("Welcome to Line Comparision Computation Program \n");
            LineComputation.GetLength();  // calling static method of LineComputation class.
            Console.ReadLine(); 
        }
    }
}