using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Mediator
{
    public interface IChatMediator
    {
        void Join(ChatMember member);
        void Quit(ChatMember member);

        void Notify(string from, string message);
        void Notify(string from, string to, string message);
    }
}
