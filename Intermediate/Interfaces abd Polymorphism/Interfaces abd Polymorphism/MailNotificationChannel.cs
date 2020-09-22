using System;

namespace Interfaces_and_Polymorphism
{
    public class MailNotificationChannel : INotificationChannel
    {
        public void Send(Message message)
        {
            Console.WriteLine("Sending mail..");
        }
    }
}
