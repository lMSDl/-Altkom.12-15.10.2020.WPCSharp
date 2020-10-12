using SOLID;
using SOLID.III_LS_2;
using System;

namespace WPCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 3;
            var b = 5;

            Square shape = new Rectangle()
            { A = a, B = b };

            Console.WriteLine($"{a}*{b} = {shape.Area}");

            Console.ReadLine();
        }
    }
}
