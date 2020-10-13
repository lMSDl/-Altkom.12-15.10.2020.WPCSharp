namespace DesignPatterns.Structural.Bridge.I
{
    public abstract class Shape
    {
        public Color Color { get; set; }

        public override string ToString()
        {
            return $"{Color}{GetType().Name}";
        }
    }
}
