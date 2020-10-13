using System;

namespace DesignPatterns.Structural.Adapter.I
{
    public class Client
    {
        public static void Execute()
        {
            var circle = new Circle() { Radius = 5 };
            var square = new Square() { Width = 8 };

            Console.WriteLine(Check(circle));
            Console.WriteLine(Check(new SquareToCircleAdapter(square)));
            Console.WriteLine(Check(new SquareToCircleAdapter2() { Width = square.Width}));
        }

        public static bool Check(ICircle circle)
        {
            return circle.Radius <= 5;
        }
    }
}
