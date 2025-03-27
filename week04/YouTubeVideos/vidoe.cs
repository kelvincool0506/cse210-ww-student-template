public class Video
{
    // Properties
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; }
    private List<Comment> Comments { get; set; }

    // Constructor
    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        Comments = new List<Comment>();
    }

    // Add a comment to the video
    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

    // Get the list of comments
    public List<Comment> GetComments()
    {
        return Comments;
    }

    // Get the number of comments
    public int GetNumberOfComments()
    {
        return Comments.Count;
    }
}
