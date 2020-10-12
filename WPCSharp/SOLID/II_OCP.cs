using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.II_OCP
{
    abstract class Shape
    {
        public abstract float Area { get; }
    }

    class Square : Shape
    {
        public int A { get; set; }

        public override float Area => A * A;
    }

    class Rectangle : Shape
    {
        public int A { get; set; }
        public int B { get; set; }

        public override float Area => A * B;
    }

    class Circle : Shape
    {
        public int R { get; set; }

        public override float Area => R * R * (float)Math.PI;
    }

    class ShapeCalculator
    {
        float Area(Shape shape)
        {
            return shape.Area;
        }
    }
}
