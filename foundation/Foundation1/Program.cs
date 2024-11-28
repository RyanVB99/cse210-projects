using System;

class Program
{
    static void Main(string[] args)
    {
        // Create video instances
        Video video1 = new Video("Video 1", "Author 1", 120);
        Video video2 = new Video("Video 2", "Author 2", 150);
        Video video3 = new Video("Video 3", "Author 3", 180);
        Video video4 = new Video("Video 4", "Author 4", 210);

        // Create comments for video1
        video1.AddComment(new Comment("User1", "Great video!"));
        video1.AddComment(new Comment("User2", "Very informative."));
        video1.AddComment(new Comment("User3", "Loved it!"));

        // Create comments for video2
        video2.AddComment(new Comment("User4", "Nice explanation."));
        video2.AddComment(new Comment("User5", "Well done."));
        video2.AddComment(new Comment("User6", "Good job!"));

        // Create comments for video3
        video3.AddComment(new Comment("User7", "Awesome content."));
        video3.AddComment(new Comment("User8", "Very helpful."));
        video3.AddComment(new Comment("User9", "Thanks for sharing."));

        // Create comments for video4
        video4.AddComment(new Comment("User10", "Excellent video."));
        video4.AddComment(new Comment("User11", "Learned a lot."));
        video4.AddComment(new Comment("User12", "Fantastic!"));

        // Display videos and their comments
        video1.Display();
        video2.Display();
        video3.Display();
        video4.Display();
    }
}