public class Comment
{
    public string _authorCommentName = "";
    public string _commentText = "";


    public void DisplayComment()
    {
        Console.WriteLine($"{_authorCommentName}: {_commentText}");
    }
}