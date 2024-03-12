

namespace StackOverflowPost
{
    public class Post
    {
        // private fields
        private string _title;
        private string _description;
        private DateTime _created;

        private int _upvote;
        private int _downvote;

        private int _voteCount;


        // public properties

        public string Title
        {
            get
            {
                return _title;
            }

            set
            {
                _title = value;
            }
        }


        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
            }
        }

        public DateTime Created
        {
            get
            {
                return _created;
            }
            set
            {
                _created = value;
            }
        }

        public int Upvote
        {
            get
            {
                return _upvote;
            }
        }

        public int Downvote
        {
            get
            {
                return _downvote;
            }
        }

        public int VoteCount
        {
            get
            {
                return _upvote - _downvote;
            }
        }


        // constructor 
        public Post(string title, string description)
        {
            _title = title;
            _description = description;
            _created = DateTime.Now;    
            _upvote = 0;
            _downvote = 0;
        }


        //method to upvote
        public void UpvotePost()
        {
            _upvote++;
        }

        public void DownvotePost() 
        {
            _downvote++;        
        }
    }
}
