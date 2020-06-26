using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Assignment
{
    class ShapesOverload
    {
        public void CalculateArea(float x)
        {
            Console.WriteLine("Area of Square is " + x * x + " sq units");
        }
        public void CalculateArea(double r)
        {
            double area = 3.14 * r * r;
            Console.WriteLine("Area of Circle is " + area + " sq units");
        }

        public void CalculateArea(double x, double y)
        {
            Console.WriteLine("Area of Reactangle is " + x * y + " sq units");
        }

        public void CalculateArea(float height, float Base)
        {
            Console.WriteLine("Area of Traiangle is " + (height * Base) / 2 + " sq units");
        }

    }
    class Test_Area
    {
        static void Main()
        {
            ShapesOverload sp = new ShapesOverload();
            sp.CalculateArea(4.1);
            sp.CalculateArea(5, 4);
            sp.CalculateArea(13, 64);
            sp.CalculateArea(7.8, 35.9);
            Console.ReadKey();

        }
    }
}



