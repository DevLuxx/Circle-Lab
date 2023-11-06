using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_Lab
{
    using System;

    class Circle // inside of this class are the members of the Circle class
                 // the members contain the properties and methods   
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double CalculateDiameter()
        {
            return 2 * radius;
        }

        public double CalculateCircumference()
        {
            return 2 * Math.PI * radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public void Grow()
        {
            radius *= 2;
            
        }

        public double GetRadius()
        {
            return radius;
        }
    }
}
