namespace DesignPatterns.Structural.Flyweight
{
    public interface ICarFlyweight
    {
        string Manufacturer { get; set; }
        string Model { get; set; }
        string Color { get; set; }
        void Operation(Car car);
    }
}
