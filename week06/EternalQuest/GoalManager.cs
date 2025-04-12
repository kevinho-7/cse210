using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public GoalManager()
    {

    }

    public void Start()
    {
            string[] principalMenu = {
                "   1. Create New Goal",
                "   2. List Goals",
                "   3. Record Event",
                "   4. Save Goals",
                "   5. Load Goals",
                "   6. Quit"
            };

        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("-- Welcome to the Eternal Quest Goal Manager! --");

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("Menu options:");

            foreach (string item in principalMenu)
            {
                Console.WriteLine(item);
            }

            Console.Write("Please select an option: ");
            string selectOption = Console.ReadLine();

            switch (selectOption)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    Console.Clear();
                    ListGoalDetails();
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

    public void ListGoalName()
    {
        for (int i = 1; i < _goals.Count(); i++)
        {
            Console.WriteLine($"{i}. {_goals[i - 1].GetShortName()}");
        }
    }

    public void ListGoalDetails()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void CreateGoal()
    {
            string[] goalMenu = {
                "   1. Simple Goal",
                "   2. Eternal Goal",
                "   3. ChekList Goal"
            };

        Console.WriteLine("The types of goals are:");

        foreach (string item in goalMenu)
        {
            Console.WriteLine(item);
        }
        
        Console.Write("Which type of goal would you like to create? - ");
        string selectGoalType = Console.ReadLine();

        switch (selectGoalType)
        {
            case "1":
            Console.Write("What is the name of your goal? - "); string sName = Console.ReadLine();
            Console.Write("What is a short description of it? - "); string sDescription = Console.ReadLine();
            Console.Write("What is the amount os points associated with this goal? - "); string sPoints = Console.ReadLine();

            SimpleGoal s1 = new SimpleGoal(sName, sDescription, int.Parse(sPoints));
            _goals.Add(s1);
                break;
        }
    }

}