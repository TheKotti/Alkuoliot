using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    public abstract class Shape
    {
        public string Name { get; set; }

        public Shape() { }

        public abstract double Area();
        public abstract double Circumference();
        public override string ToString()
        {
            return " Area=" + Area() + " Circumference=" + Circumference();
        }
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }
        public override double Area()
        {
            return Math.Round((Math.Pow(Radius, 2) * Math.PI), 2);
        }
        public override double Circumference()
        {
            return Math.Round((2 * Math.PI * Radius), 2);
        }
        public override string ToString()
        {
            return Name + " Radius=" + Radius + base.ToString();
        }

    }

    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public override double Area()
        {
            return Math.Round((Width * Height), 2);
        }
        public override double Circumference()
        {
            return Math.Round((2 * Width + 2 * Height), 2);
        }
        public override string ToString()
        {
            return Name +  " Width=" + Width + " Height=" + Height + base.ToString();
        }
    }
    public class Shapes
    {
        private List<Shape> shapes;
        public List<Shape> ShapeList
        {
            get { return shapes; }
        }

        public Shapes()
        {
            shapes = new List<Shape>();
        }
        public void AddShape(Shape shape)
        {
            shapes.Add(shape);
        }
    }
}
