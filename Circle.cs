using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ShapesDemo
{
    public class Circle : Shape
    {
        public Circle(double width, double height)
            : base(width, height)
        {
            if (width != height)
            {
                throw new ArgumentException("unequal width and height for circle...");
            }
        }

        public override double CalculateSurface()
        {
            return Math.PI * Math.Pow(this.Width, 2);
        }
    }
}
