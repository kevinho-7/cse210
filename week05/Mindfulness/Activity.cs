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

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} activity!");
        Console.WriteLine(_description);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!");
        Console.WriteLine($"You have completed the {_name} activity.");
    }

    public void ShowSpinner(int seconds)
    {
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int index = 0;

        Console.WriteLine("Get ready...");

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
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"\r{i}");
            Thread.Sleep(1000); 
        }
        Console.WriteLine();
    }
}