using System.Diagnostics.Contracts;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    string[] spinnerParts = new string[] { "|", "/", "-", "\\", "|", "/", "-", "\\"};

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = 0;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} activity!");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!");
        Console.WriteLine($"You have completed the {_name} activity!!");
    }

    public void ShowSpinner(int seconds)
    {
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int index = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write($"\r{spinnerParts[index]}");
            Thread.Sleep(100);
            index = (index + 1) % spinnerParts.Length;   
        }
        Console.Write("\r ");
    }
    public void ShowCountDown(int seconds)
    {
        _duration = seconds;
        for (int i = _duration; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");    
        }
    }   
}