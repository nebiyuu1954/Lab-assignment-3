using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace override_shape
{

    abstract class Shape
    {
        public abstract double calculateaArea();
        public abstract double calculatePerimeter();
    }

    class Circle : Shape
    {
        static readonly double Pi = 3.14;
        public double Radius { get; set; }

        public override double calculateaArea()
        {
            return Pi * Radius * Radius;
        }
        public override double calculatePerimeter()
        {
            return Pi * 2 * Radius;
        }
    }

    class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public override double calculateaArea()
        {
            return Length*Width;
        }
        public override double calculatePerimeter()
        {
            return 2*(Length + Width);
        }
    }

        class lab3
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            Rectangle rectangle = new Rectangle();

            circle.Radius = 2;
            rectangle.Width = 3;
            rectangle.Length = 5;

            Console.WriteLine("Radius: "+circle.Radius+"\nArea: " + circle.calculateaArea());
            Console.WriteLine("\nLength: " + rectangle.Length + "\nWidth: " + rectangle.Width+"\n"
                                +"Area: "+rectangle.calculateaArea() + rectangle.calculatePerimeter()   );

        }
    }
}