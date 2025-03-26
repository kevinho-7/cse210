using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();

        // Video 1
        Video video1 = new Video();
        Comment comment1 = new Comment();
        
        video1._videoTitle = "Chocolate Cake Recipe";
        video1._videoAuthorName = "Maria's Kitchen";
        video1._videoDuration = 300;
        
        comment1._authorCommentName = "John";
        comment1._commentText = "I followed the recipe and it was delicious! Thanks for sharing.";
        video1._comments.Add(comment1);

        Comment comment2 = new Comment();
        comment2._authorCommentName = "Anna";
        comment2._commentText = "Can I substitute milk with almond milk?";
        video1._comments.Add(comment2);

        Comment comment3 = new Comment();
        comment3._authorCommentName = "Charles";
        comment3._commentText = "Best chocolate cake recipe I've ever made!";
        video1._comments.Add(comment3);
        
        // Video 2
        Video video2 = new Video();
        Comment comment4 = new Comment();
        
        video2._videoTitle = "Beginner HIIT Workout";
        video2._videoAuthorName = "Pedro's Fitness";
        video2._videoDuration = 600;
        
        comment4._authorCommentName = "Marian";
        comment4._commentText = "Loved the workout! Sweating a lot here.";
        video2._comments.Add(comment4);

        Comment comment5 = new Comment();
        comment5._authorCommentName = "Luke";
        comment5._commentText = "How many times a week do you recommend doing this workout?";
        video2._comments.Add(comment5);

        Comment comment6 = new Comment();
        comment6._authorCommentName = "Fern";
        comment6._commentText = "Very intense, but worth it!";
        video2._comments.Add(comment6);
        
        // Video 3
        Video video3 = new Video();
        Comment comment7 = new Comment();
        
        video3._videoTitle = "Guitar Tutorial: Playing 'Imagine'";
        video3._videoAuthorName = "John's Lessons";
        video3._videoDuration = 420;
        
        comment7._authorCommentName = "Sophia";
        comment7._commentText = "I finally managed to play this song! Thanks!";
        video3._comments.Add(comment7);

        Comment comment8 = new Comment();
        comment8._authorCommentName = "Raphael";
        comment8._commentText = "Could you do a tutorial for 'Hey Jude'?";
        video3._comments.Add(comment8);

        Comment comment9 = new Comment();
        comment9._authorCommentName = "Lucy";
        comment9._commentText = "The explanation was very clear, well done!";
        video3._comments.Add(comment9);
        
        // Video 4
        Video video4 = new Video();
        Comment comment10 = new Comment();
        
        video4._videoTitle = "New Smartphone X Review";
        video4._videoAuthorName = "Tech Reviews";
        video4._videoDuration = 480;
        
        comment10._authorCommentName = "Bruno";
        comment10._commentText = "Great review! Helped me decide to buy it.";
        video4._comments.Add(comment10);

        Comment comment11 = new Comment();
        comment11._authorCommentName = "Camille";
        comment11._commentText = "How does the battery life compare to the previous model?";
        video4._comments.Add(comment11);

        Comment comment12 = new Comment();
        comment12._authorCommentName = "Edward";
        comment12._commentText = "I missed more details about the camera.";
        video4._comments.Add(comment12);

        List<Video> videos = new List<Video>{video1, video2, video3, video4};

        foreach(Video video in videos)
        {
            Console.WriteLine("----------------------------------------------------------------------");
            video.DisplayAll();
            Console.WriteLine();
        }
        
    }
}