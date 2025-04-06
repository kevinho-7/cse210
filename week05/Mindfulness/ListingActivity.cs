
public class ListingActivity : Activity
{
    private string[] _prompts = new string[]
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who have you helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        // Constructor for ListingActivity
    }

    private string GetRandomPrompt()
    {
        Random rnd = new Random();
        int index = rnd.Next(_prompts.Length);
        return _prompts[index];
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.Write("How long, in seconds, would you like for your session? - ");
        int duration = int.Parse(Console.ReadLine());
        Console.Clear();

        Console.WriteLine("Get ready...");
        ShowSpinner(5);

        string prompt = GetRandomPrompt();
        Console.WriteLine("\nList as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {prompt} ---");
        Console.Write("You may begin in:  ");
        ShowCountDown(10);
        Console.WriteLine();

        DateTime endTime = DateTime.Now.AddSeconds(duration);
        int count = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            count++;
        }

        Console.WriteLine($"You listed {count} items!\n");
        DisplayEndingMessage();
        Console.WriteLine($"And you have completed this activity for {duration} seconds!!");
        ShowSpinner(5);
        Console.Clear();
        
    }
}
