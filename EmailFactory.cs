using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationSystem
{
    public class EmailFactory : NotificationFactory
    {
        protected override Notification CreateNotification()
        {
            return new EmailNotification();
        }
    }
}
