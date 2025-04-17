using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine();

        List<Activity> _act = new List<Activity>();
        Running run1 = new Running("Running", 30, 5, 10, 6);
        Cycling cycle1 = new Cycling("Cycling", 45, 20, 15, 4);
        Swimming swimming1 = new Swimming(20, "Swimming", 60, 1, 2, 3);
        _act.Add(run1);
        _act.Add(cycle1);
        _act.Add(swimming1);

        foreach (Activity activity in _act)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
        }
    }
}