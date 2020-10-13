using System;

namespace DesignPatterns.Behavioral.ChainOfResponsibility.II
{
    public class TextBox : Container
    {
        public string InputText { get; set; }

        protected override void Click(bool handled)
        {
            if (handled)
            {
                base.Click(false);
            }
            else
            {
                Console.WriteLine("TextBox has focus");
                base.Click(true);
            }
        }
    }
}
