using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartNotificationSender
{
    internal class PushSender : Sender
    {
        public PushSender(string _recipient): base(_recipient) 
        {
            
        }

        public override void Send(string message)
        {
            Console.WriteLine($"sending push notification to {Recipient}: {message}");
        }
    }
}
