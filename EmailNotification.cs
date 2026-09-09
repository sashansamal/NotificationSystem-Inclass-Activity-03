using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationSystem
{
    public class EmailNotification : Notification
    {
        public void Send()
        {
            Console.WriteLine("Email Notification Sent");
        }
    }
}
