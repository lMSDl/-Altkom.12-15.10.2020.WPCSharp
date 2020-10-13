using System;

namespace DesignPatterns.Structural.Bridge.I
{
    public class Client
    {
        public static void Execute()
        {
            var shape = new Circle();
            shape.Color = new RedColor();
            shape.Color.Brightness = new DarkBrightness();

            Console.WriteLine(shape);

        }
    }
}
