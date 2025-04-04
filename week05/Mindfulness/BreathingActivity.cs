public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        // Constructor for BreathingActivity
    }

    public void SetDuration(int duration)
    {

    }

    public void Run()
    {
        DisplayStartingMessage();
        ShowSpinner(5);
        ShowCountDown(15);
        DisplayEndingMessage();
    }
}