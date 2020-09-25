using System;

namespace Events
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("NessageService: Sending a text message..." + args.Video.Title);
        }
    }
}
 