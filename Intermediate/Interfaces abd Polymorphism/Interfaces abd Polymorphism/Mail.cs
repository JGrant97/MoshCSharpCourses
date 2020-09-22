using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces_and_Polymorphism
{
    class Mail
    {
        public void Send(Mail mail)
        {
            Console.WriteLine("Sending email...");
        }
    }
}
