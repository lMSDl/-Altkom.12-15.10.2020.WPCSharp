﻿namespace DesignPatterns.Behavioral.Visitor.I
{
    public class HtmlVisitor : IVisitor
    {
        public string Output { get; set; }

        public void Visit(PlainText plainText)
        {
            Output += plainText.Plain;
        }

        public void Visit(BoldText boldText)
        {
            Output += $"<b>{boldText.Bold}</b>";
        }

        public void Visit(Hyperlink hyperlink)
        {
            Output += $"<a href=\"{hyperlink.Url}\">{hyperlink.Label}</a>";
        }
    }
}
