namespace DesignPatterns.Behavioral.ChainOfResponsibility.II
{
    public class Frame : Container
    {
        protected override void Click(bool handled)
        {
            System.Console.WriteLine("Frame flashing!");
            base.Click(handled);
        }
    }
}
