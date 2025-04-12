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
            DisplayPlayerInfo();
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
                    Console.Clear();
                    CreateGoal();
                    break;
                case "2":
                    Console.Clear();
                    ListGoalDetails();
                    break;
                case "3":
                    Console.Clear();
                    RecordEvent();
                    break;
                case "4":
                    Console.Clear();
                    SaveGoals();
                    break;
                case "5":
                    Console.Clear();
                    LoadGoals();
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
    public void CreateGoal()
    {
            string[] goalMenu = {
                "   1. Simple Goal",
                "   2. Eternal Goal",
                "   3. ChekList Goal",
                "   4. Back to the menu"
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
                Console.Write("What is the amount of points associated with this goal? - "); string sPoints = Console.ReadLine();

                SimpleGoal s1 = new SimpleGoal(sName, sDescription, int.Parse(sPoints));
                _goals.Add(s1);
                break;
            case "2":
                Console.Write("What is the name of your goal? - "); string eName = Console.ReadLine();
                Console.Write("What is a short description of it? - "); string eDescription = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal? - "); string ePoints = Console.ReadLine();

                EternalGoal e1 = new EternalGoal(eName, eDescription, int.Parse(ePoints));
                _goals.Add(e1);
                break;
            case "3":
                Console.Write("What is the name of your goal? - "); string cName = Console.ReadLine();
                Console.Write("What is a short description of it? - "); string cDescription = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal? - "); string cPoints = Console.ReadLine();
                Console.Write("How many times does this goal need to be accomplished for bonus - "); string cTarget = Console.ReadLine();
                Console.Write("What is the bonus for accomplishing it that many times? - "); string cBonus  = Console.ReadLine();

                ChecklistGoal c1 = new ChecklistGoal(cName, cDescription, int.Parse(cPoints), 0, int.Parse(cTarget), int.Parse(cBonus));
                _goals.Add(c1);
                break;
            case "4":
                return;
            default:
                Console.WriteLine("Invalid selection. Please try again.");
                break;
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Your score is: {_score}");
    }

    public void ListGoalName()
    {
        for (int i = 1; i <= _goals.Count; i++)
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

    public void RecordEvent()
    {
        Console.WriteLine("The types of goals are:");
        ListGoalName();

        Console.Write("Which gol did you accomplish? - "); string completedGoal = Console.ReadLine();

        int i;
        if (int.TryParse(completedGoal, out i) && i >= 1 && i<= _goals.Count)
        {
            int pointsEarned = _goals[i - 1].RecordEvent();
            _score += pointsEarned;

            if (pointsEarned > 0)
            {
                Console.WriteLine($"Congratulations! You earned {pointsEarned} points!");
            }
            else
            {
                Console.WriteLine("This goal is already complete. No points awarded.");
            }
            Console.WriteLine($"Your current score is: {_score}");
        }
        else
        {
            Console.WriteLine("Invalid goal selection. Please try again.");
        }
    }

    public void SaveGoals()
    {
        Console.Write("What's the file name for the goal file? - "); string fileName = Console.ReadLine();

         using (StreamWriter outputFile = new StreamWriter(fileName))
         {
            outputFile.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
         }
         Console.WriteLine($"The {fileName} has been created.");
    }

    public void LoadGoals()
    {
        Console.Write("What's the file name for the goal file? - ");
        string fileName = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(fileName);

        _score = int.Parse(lines[0]);

        _goals.Clear();

        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];
            string[] parts1 = line.Split(':');
            string goalType = parts1[0].Trim();

            string[] parts2 = parts1[1].Split(",");
            string shortName = parts2[0].Trim();
            string description = parts2[1].Trim();
            int points = int.Parse(parts2[2].Trim());

            switch (goalType)
            {
                case "Simple Goal":
                    bool simpleIsComplete = bool.Parse(parts2[3].Trim());
                    SimpleGoal s1 = new SimpleGoal(shortName, description, points);
                    if (simpleIsComplete)
                    {
                        s1.RecordEvent();
                    }
                    _goals.Add(s1);
                    break;

                case "Eternal Goal":
                    bool eternalIsComplete = bool.Parse(parts2[3].Trim());
                    EternalGoal e1 = new EternalGoal(shortName, description, points);
                    if (eternalIsComplete)
                    {
                        e1.RecordEvent();
                    }
                    _goals.Add(e1);
                    break;

                case "Checklist Goal":
                    int amountCompleted = int.Parse(parts2[3].Trim());
                    int target = int.Parse(parts2[4].Trim());
                    int bonus = int.Parse(parts2[5].Trim());
                    ChecklistGoal c1 = new ChecklistGoal(shortName, description, points, amountCompleted, target, bonus);
                    _goals.Add(c1);
                    break;

                default:
                    Console.WriteLine($"Unknown goal type: {goalType}");
                    break;
            }
        }
    }

}