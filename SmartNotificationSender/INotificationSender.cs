﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartNotificationSender
{
    internal interface INotificationSender
    {
        public void Send(string message);
    }
}
