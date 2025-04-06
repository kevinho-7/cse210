public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        // Constructor for BreathingActivity
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.Write("How long, in seconds, would you like for your session? - ");
        int duration = int.Parse(Console.ReadLine());
        Console.Clear();

        Console.WriteLine("Get ready...");
        ShowSpinner(5);
        Console.WriteLine();


        DateTime endTime = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in... ");
            ShowCountDown(4);
            Console.WriteLine();
            
            Console.Write("Now breathe out... ");
            ShowCountDown(6);
            Console.WriteLine();
        }
        Console.WriteLine();


        DisplayEndingMessage();
        Console.WriteLine($"You have Breathed for {duration} seconds!!");
        ShowSpinner(5);
        Console.Clear();

    }
}