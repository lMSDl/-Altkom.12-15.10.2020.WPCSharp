namespace DesignPatterns.Behavioral.ChainOfResponsibility.I
{
    public interface IDiscountHandler
    {
        float MaxDiscount { get; }
        float MinPrice { get; }
        bool Discount(float value, float price);
    }
}
