public class Video
{
    public string _videoTitle = "";
    public string _videoAuthorName = "";
    public int _videoDuration = 0;

    public List<Comment> _comments = new List<Comment>();


    public void DisplayAll()
    {
        Console.WriteLine($"Video title: {_videoTitle}");
        Console.WriteLine($"Video Author: {_videoAuthorName}");
        Console.WriteLine($"Duration: {_videoDuration} seconds");
        Console.WriteLine("");
        Console.WriteLine("Comments: ");

        foreach(Comment comment in _comments)
        {
            Console.WriteLine($"{comment._authorCommentName}: {comment._commentText}");
        }

        Console.WriteLine("----------------------------------------------------------------------");
    }
}