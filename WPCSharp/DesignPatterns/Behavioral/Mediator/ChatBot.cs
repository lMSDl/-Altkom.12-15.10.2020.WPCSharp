using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Mediator
{
    public class ChatBot : ChatMember
    {
        public ChatBot(string nick) : base(nick)
        {
        }

        public override void Receive(string from, string message, bool isPrivate)
        {
            if (isPrivate)
                Chat?.Notify(Nick, from, message);
            else
                Chat?.Notify(Nick, message);
        }
    }
}
