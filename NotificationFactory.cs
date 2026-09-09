using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationSystem
{
    public abstract class NotificationFactory
    {
        public Notification SendNotification()
        {
            Notification notification = CreateNotification();

            notification.Send();

            return notification;
        }

        protected abstract Notification CreateNotification();
    }
}
