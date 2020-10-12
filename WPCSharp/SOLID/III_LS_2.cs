namespace SOLID.III_LS_2
{
    public abstract class Shape
    {
        public abstract int Area { get; }
    }

    public class Rectangle : Square
    {
        public int B { get; set; }

        public override int Area => A * B;
    }

    public class Square : Shape
    {
        public int A { get; set; }
        public override int Area => A * A;
    }

}
