using DesignPatterns.Structural.Adapter.I;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Adapter.I
{
    public class SquareToCircleAdapter : ICircle
    {
        private Square _square;
        public SquareToCircleAdapter(Square square)
        {
            _square = square;
        }

        public float Radius => _square.Width * (float)Math.Sqrt(2) / 2f;
    }
}
