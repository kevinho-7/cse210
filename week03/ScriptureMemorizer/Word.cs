public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = true;
    }

    public void Hide()
    {
        _isHidden = true;
    }
}