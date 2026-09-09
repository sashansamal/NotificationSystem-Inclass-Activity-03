using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationSystem
{
    public class PushNotification : Notification
    {
        public void Send()
        {
            Console.WriteLine("Push Notification Sent");
        }
    }
}
