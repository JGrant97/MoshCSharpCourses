using System;
using System.IO;

namespace Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            //most specific catch first, most generic catch last
            try
            {
                //using (var streamReader = new StreamReader(@"c\file.zip"))
                //{
                //    var content = streamReader.ReadToEnd();

                //}

                var api = new YouTubeApi();
                var video = api.GetVideos("Jack");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
