namespace Events
{
    class Program
    {

        static void Main(string[] args)
        {
            var video = new Video() { Title = "Video 1" };
            var videoEncoder = new VideoEncoder();
            var mailService = new MailService();
            var messageSerice = new MessageService();

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += messageSerice.OnVideoEncoded;
            videoEncoder.Encode(video);
        }
    }
}
 