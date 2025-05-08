using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartNotificationSender
{
    internal abstract class Sender : INotificationSender
    {
        //why did i think of making an abstract class while having an interface? because of the attribute recipient
        public string Recipient { get; set; }
        protected Sender(string _recipient)
        {
            Recipient = _recipient;
        }
        public abstract void Send(string message);
    }
}
