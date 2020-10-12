using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SOLID
{
    public interface ISend
    {
        void Send();
    }

    internal class SMS : ISend
    {
        public string Number { get; set; }
        public string Content { get; set; }

        public void Send()
        {
            SendSMS();
        }

        public void SendSMS()
        {
            Console.WriteLine("Sending SMS...");
        }
    }

    internal class MMS : ISend
    {
        public string Number { get; set; }
        public byte[] Content { get; set; }

        public void Send()
        {
            SendMMS();
        }

        public void SendMMS()
        {
            Console.WriteLine("Sending MMS...");
        }
    }

    internal class Mail : ISend
    {
        public string Address { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }

        public void Send()
        {
            SendMail();
        }

        public void SendMail()
        {
            Console.WriteLine("Sending Mail...");
        }
    }

    internal class Messenger
    {
        public IEnumerable<ISend> Messages { get; set; }


        public void SendMessage()
        {
            Messages?.ToList().ForEach(x => x.Send());
        }
    }
}
