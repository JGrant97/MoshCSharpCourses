using System;
using System.Collections.Generic;
using System.Text;

namespace Exception_Handling
{
    public class YouTubeApi
    {
        public List<Video> GetVideos(string user)
        {
            try
            {
                //logic
                throw new Exception("Oops some low level youtube error.");
            }
            catch (Exception ex)
            {

                throw new YouTubeException("Coult not fetch youtube videos" , ex);
            }

            return new List<Video>();
        }
    }
}
