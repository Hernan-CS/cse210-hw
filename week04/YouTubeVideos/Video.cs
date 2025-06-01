using System;

public class Video
{
    /* Making use of properties as I've been doing lately. */
    public string Title { get; set; }
    public string Author { get; set; }
    public int LengthSeconds { get; set; }
    private List<Comment> _comments;

    /* Constructor with the due parameters which I'll pass the values through. */
    public Video(string title, string author, int lengthSeconds)
    {
        /* Asigning the parameters to properties so I can pass values in them. */
        Title = title;
        Author = author;
        LengthSeconds = lengthSeconds;
        _comments = new List<Comment>();
    }

    /* Method to add a comment! */
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    /* Method to get the length of the list, that is, the amount of comments. */
    public int GetCommentAmount()
    {
        return _comments.Count;
    }
    
    /* Method to get the list. */
    public List<Comment> GetComments()
    {
        return _comments;
    }
}