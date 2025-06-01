public class Comment
{
    /* Properties! */
    public string CommenterName { get; set; }
    public string CommentText { get; set; }

    /* Constructor with some parameters. I'll use this later to show the comments.*/
    public Comment(string commenterName, string commentText)
    {
        CommenterName = commenterName;
        CommentText = commentText;
    }
}