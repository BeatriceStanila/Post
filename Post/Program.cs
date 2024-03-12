namespace StackOverflowPost
{

    internal class Program
    {
        private static void Main(string[] args)
        {


            //create a new post
            Post myPost = new Post("My C# first post", "I have an issue with...");

            Console.WriteLine("Title: " + myPost.Title);
            Console.WriteLine("Description: " + myPost.Description);
            Console.WriteLine("Date Created: " + myPost.Created);
            Console.WriteLine("Vote Count: " + myPost.VoteCount);


            myPost.UpvotePost();

            myPost.UpvotePost();

            myPost.UpvotePost();

            Console.WriteLine("Vote count after upvoting: " + myPost.VoteCount);

            myPost.DownvotePost();
            Console.WriteLine("Vote count after downvoting: " + myPost.VoteCount);






        }
    }
}