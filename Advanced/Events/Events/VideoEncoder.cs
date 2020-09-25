using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Events
{
    class VideoEncoder
    {
        public event EventHandler<VideoEventArgs> VideoEncoded;
        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video...");
            Thread.Sleep(3000);

            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
            {
                VideoEncoded(this, new VideoEventArgs() { Video = video});
            }
        }
    }
}
