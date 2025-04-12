using System;
using System.ComponentModel;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    string[] menu = {
        "   1. Create New Goal",
        "   2. List Goals",
        "   3. Record Event",
        "   4. Save Goals",
        "   5. Load Goals",
        "   6. Quit"
    };

    public GoalManager()
    {

    }

    public void Start()
    {
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to the Eternal Quest Goal Manager!");
            Console.WriteLine("Please select an option:\n");

            foreach (string item in menu)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Please select an option: ");
            string select = Console.ReadLine();

            switch (select)
            {
                case "1":
                    // CreateGoal();
                    break;
                case "2":
                    // ListGoals();
                    break;
                case "3":
                    // RecordEvent();
                    break;
                case "4":
                    // SaveGoals();
                    break;
                case "5":
                    // LoadGoals();
                    break;
                case "6":
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid selection. Please try again.");
                    break;
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Your score is: {_score}");
    }
}