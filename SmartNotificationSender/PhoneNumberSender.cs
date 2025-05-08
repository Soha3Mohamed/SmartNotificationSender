using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartNotificationSender
{
    internal class PhoneNumberSender : Sender
    {
        public PhoneNumberSender(string _recipient):base(_recipient)
        {
                
        }

        public override void Send(string message)
        {
            Console.WriteLine($"sending phone number notification to {Recipient}: {message}");
        }
    }
}
