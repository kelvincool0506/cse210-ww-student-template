class Program
{
    static void Main(string[] args)
    {
        // Create video instances
        Video video1 = new Video("How to Cook Pasta", "Chef John", 600);
        Video video2 = new Video("Travel Vlog: Italy", "Alice Adventures", 900);
        Video video3 = new Video("Learn C# Programming", "Code Academy", 1200);

        // Add comments to video1
        video1.AddComment(new Comment("Mike", "Great video!"));
        video1.AddComment(new Comment("Sarah", "Very informative."));
        video1.AddComment(new Comment("John", "Thanks for the tips!"));

        // Add comments to video2
        video2.AddComment(new Comment("Emma", "Amazing scenery!"));
        video2.AddComment(new Comment("Tom", "Makes me want to visit Italy."));
        video2.AddComment(new Comment("Anna", "Beautiful vlog!"));

        // Add comments to video3
        video3.AddComment(new Comment("James", "Excellent tutorial."));
        video3.AddComment(new Comment("Lily", "Really helpful, thanks!"));
        video3.AddComment(new Comment("Oscar", "Clear and easy to follow."));

        // Store videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Iterate through videos and display their information
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.Name}: {comment.Text}");
            }

            Console.WriteLine();
        }
    }
}
