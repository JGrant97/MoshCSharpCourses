using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http;

namespace Interfaces_and_Polymorphism
{
    public class VideoEncoder
    {
        private readonly IList<INotificationChannel> _notificationCjannels;
        public VideoEncoder()
        {
            _notificationCjannels = new List<INotificationChannel>();
        }

        public void Encode(Video video)
        {
            foreach (var channel in _notificationCjannels)
            {
                channel.Send(new Message());
            }
        }

        public void RegisterNotificationChannel(INotificationChannel channel)
        {
            _notificationCjannels.Add(channel); 
        }
    }
}
