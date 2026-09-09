using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationSystem
{
    public class SMSFactory : NotificationFactory
    {
        protected override Notification CreateNotification()
        {
            return new SMSNotification();
        }
    }
}
