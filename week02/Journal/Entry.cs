
public class Entry
{
    public string _date;
    public string _promptText = ""; 
    public string _entryText = "";
    
    public Entry()
    { 
        DateTime currentDateTime = DateTime.Now;
        _date = currentDateTime.ToShortDateString();
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText} ");
        Console.WriteLine($"{_entryText}\n");
    }
}