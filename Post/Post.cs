

namespace StackOverflowPost
{
    public class Post
    {
        //// private fields
        //private string _title;
        //private string _description;
        //private DateTime _created;

        //private int _upvote;
        //private int _downvote;

        //private int _voteCount;


        // auto-implemented public properties

        public string Title { get; set; }
        
        public string Description { get; set; }

        public DateTime Created { get; set; }

        public int Upvote { get; set; }

        public int Downvote { get; set; }

        public int VoteCount
        {
            get
            {
                return Upvote - Downvote;
            }
        }


        // constructor 
        public Post(string title, string description)
        {
            Title = title;
            Description = description;
            Created = DateTime.Now;    
            Upvote = 0;
            Downvote = 0;
        }


        //method to upvote
        public void UpvotePost()
        {
            Upvote++;
        }

        public void DownvotePost() 
        {
            Downvote++;        
        }
    }
}
