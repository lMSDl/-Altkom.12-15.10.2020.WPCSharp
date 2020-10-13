namespace DesignPatterns.Structural.Bridge.I
{
    public abstract class Color
    {
        public abstract string ColorValue { get; }

        public Brightness Brightness {get; set;}

        public override string ToString()
        {
            return Brightness == null ? ColorValue : Brightness.Value+ColorValue;
        }
    }
}
