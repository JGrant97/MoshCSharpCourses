using System;

namespace Classes_StackOverflow_Post
{
    public class Post
    {
        private string _title;
        private string _desc;
        private DateTime _postedDate;
        private int _totalVotes;

        public Post()
        {
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public string Desc
        {
            get { return _desc; }
            set { _desc = value; }
        }

        public DateTime PostedDate
        {
            get { return _postedDate; }
            set { _postedDate = value; }
        }

        public int TotalVotes
        {
            get { return _totalVotes; }
            private set { _totalVotes = value; }
        }

        public void UpVote()
        {
             _totalVotes = _totalVotes + 1;
        }

        public void DownVote()
        {

            _totalVotes = _totalVotes - 1;
        }

    }
}
