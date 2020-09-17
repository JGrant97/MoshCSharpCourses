using System;

namespace Classes_StackOverflow_Post
{
    class Program
    {
        static void Main(string[] args)
        {
            var post = new Post();
            post.Title = "Hello World";
            post.Desc = "This is my first post";
            post.PostedDate = DateTime.Now;
            while(true)
            {
                Console.WriteLine("\nTitle: " + post.Title + "\nDescription: " + post.Desc + "\n" + "Total votes: " + post.TotalVotes +
                 "\nPosted: " + post.PostedDate + "\nYou can upvote or downvote this post by typing upvote or downvote");

                var input = Console.ReadLine();

                if(input.Contains("upvote".ToLower()))
                {
                    post.UpVote();
                }
                else if (input.Contains("downvote".ToLower()))
                {
                    post.DownVote();
                }
                else
                {
                    throw new ArgumentException("Only upvote or downvote");
                }
            }    
        }
    }
}
