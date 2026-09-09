using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            NotificationFactory emailFactory = new EmailFactory();
            emailFactory.SendNotification();

            NotificationFactory smsFactory = new SMSFactory();
            smsFactory.SendNotification();

            NotificationFactory pushFactory = new PushFactory();
            pushFactory.SendNotification();

            Console.ReadLine();
        }
    }
}
