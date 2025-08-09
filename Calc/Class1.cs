using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
   public class Circle : IShape
    {
        public double Radius;
        public Circle(double radius)
        {
            Radius = radius;
        }
        public double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    public class Square : IShape
    {
        public double Side;

        public Square(double side)
        {
            Side = side;
        }

        public double GetArea()
        {
            return Side * Side;
        }
    }

    class Rectangle : IShape
    {
        public double Width;
        public double Height;   
    
    public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }
        public double GetArea()
        {
            return Width * Height;
        }
    }

    class Program
    {
        static void Main()
        {
            IShape circle = new Circle(5);
            IShape square = new Square(4);
            IShape rectangle = new Rectangle(10, 15);

            Console.WriteLine($"Circle Area: {circle.GetArea()}");
            Console.WriteLine($"Square Area: {square.GetArea()}");
            Console.WriteLine($"Rectangle Area: {rectangle.GetArea()}");
        }
    }


}
