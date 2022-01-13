using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisionComputation
{
    public class LineComputation
    {
        //Instace Variables.
        double pointX1, pointY1, pointX2, pointY2;
        //Constructor initilalizing values through pass by reference.
        public LineComputation(double pointX1,double pointY1,double pointX2,double pointY2)
        { 
            this.pointX1 = pointX1;
            this.pointY1 = pointY1;
            this.pointX2 = pointX2;
            this.pointY2 = pointY2;
        }
        //Method to compute length of given co-ordinates of geometery..
        public double Length()
        {
            //returning double type value after computation.
            return Math.Sqrt((pointX2 - pointX1) * (pointX2 - pointX1) + (pointY2 - pointY1) * (pointY2 - pointY1));
        }
    }
}